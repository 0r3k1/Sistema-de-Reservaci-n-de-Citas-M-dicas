using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace CapaDatos.Database {
    public static class ConexionSqlite {
        private static readonly string dbFile = "clinica.db";
        private static readonly string connectionString = $"Data Source={dbFile}";

        public static SqliteConnection GetConnection() {
            // Si no existe el archivo, se crea automáticamente al abrir la conexión.
            return new SqliteConnection(connectionString);
        }
    }
}
