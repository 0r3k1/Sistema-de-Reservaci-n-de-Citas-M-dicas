using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.Sqlite;

namespace CapaDatos.Database {
    public static class InicializarDB {
        public static void CrearTablas() {
            using(var conn = ConexionSqlite.GetConnection()) {
                conn.Open();

                // Crear tablas
                var command = conn.CreateCommand();
                command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Rol (
                    RolId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL UNIQUE
                );

                CREATE TABLE IF NOT EXISTS Usuario (
                    UsuarioId INTEGER PRIMARY KEY AUTOINCREMENT,
                    NombreUsuario TEXT NOT NULL UNIQUE,
                    ContrasenaHash TEXT NOT NULL,
                    NombreCompleto TEXT,
                    RolId INTEGER NOT NULL,
                    FOREIGN KEY(RolId) REFERENCES Rol(RolId)
                );

                CREATE TABLE IF NOT EXISTS Paciente (
                    PacienteId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL,
                    DPI TEXT,
                    Telefono TEXT,
                    Correo TEXT,
                    FechaNacimiento TEXT,
                    Direccion TEXT
                );

                CREATE TABLE IF NOT EXISTS Especialidad (
                    EspecialidadId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL UNIQUE
                );

                CREATE TABLE IF NOT EXISTS Doctor (
                    DoctorId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL,
                    EspecialidadId INTEGER,
                    HorarioInicio TEXT,
                    HorarioFin TEXT,
                    FOREIGN KEY(EspecialidadId) REFERENCES Especialidad(EspecialidadId)
                );

                CREATE TABLE IF NOT EXISTS Consultorio (
                    ConsultorioId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL,
                    Ubicacion TEXT
                );

                CREATE TABLE IF NOT EXISTS Cita (
                    CitaId INTEGER PRIMARY KEY AUTOINCREMENT,
                    PacienteId INTEGER NOT NULL,
                    DoctorId INTEGER NOT NULL,
                    ConsultorioId INTEGER,
                    Fecha DATE NOT NULL,
                    HoraInicio TEXT NOT NULL,
                    DuracionMinutos INTEGER DEFAULT 30,
                    Estado TEXT DEFAULT 'Agendada',
                    Observaciones TEXT,
                    FOREIGN KEY(PacienteId) REFERENCES Paciente(PacienteId),
                    FOREIGN KEY(DoctorId) REFERENCES Doctor(DoctorId),
                    FOREIGN KEY(ConsultorioId) REFERENCES Consultorio(ConsultorioId)
                );

                CREATE TABLE IF NOT EXISTS HistorialAtencion (
                    HistorialId INTEGER PRIMARY KEY AUTOINCREMENT,
                    CitaId INTEGER NOT NULL,
                    FechaAtencion TEXT,
                    Diagnostico TEXT,
                    Recomendaciones TEXT,
                    DerivadoA INTEGER,
                    FOREIGN KEY(CitaId) REFERENCES Cita(CitaId),
                    FOREIGN KEY(DerivadoA) REFERENCES Doctor(DoctorId)
                );
                ";
                command.ExecuteNonQuery();

                // Insertar roles y usuario admin de prueba
                var insertCmd = conn.CreateCommand();
                string adminHash = CalcularHash("admin123");

                insertCmd.CommandText = @"
                    INSERT OR IGNORE INTO Rol (Nombre) 
                    VALUES ('Admin'), ('Doctor'), ('Secretaria'), ('Enfermera'), ('MedicoGeneral');

                    INSERT OR IGNORE INTO Usuario (NombreUsuario, ContrasenaHash, NombreCompleto, RolId)
                    SELECT 'admin', @hash, 'Administrador del Sistema', RolId 
                    FROM Rol WHERE Nombre = 'Admin';
                ";

                insertCmd.Parameters.AddWithValue("@hash", adminHash);
                insertCmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        private static string CalcularHash(string input) {
            using(var sha256 = SHA256.Create()) {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder();
                foreach(var b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}
