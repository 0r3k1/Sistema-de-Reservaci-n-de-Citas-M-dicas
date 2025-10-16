using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos.Database;
using CapaDatos.Modelos;
using Microsoft.Data.Sqlite;

namespace CapaDatos.Repositorios {
    public class UsuarioRepository {
        public Usuario? ValidarUsuario(string nombreUsuario, string contrasenaHash) {
            using(var conn = ConexionSqlite.GetConnection()) {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    SELECT u.UsuarioId, u.NombreUsuario, u.ContrasenaHash, u.NombreCompleto,
                           r.RolId, r.Nombre AS RolNombre
                    FROM Usuario u
                    INNER JOIN Rol r ON u.RolId = r.RolId
                    WHERE u.NombreUsuario = @nombreUsuario AND u.ContrasenaHash = @hash;
                ";
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@hash", contrasenaHash);

                using(var reader = cmd.ExecuteReader()) {
                    if(reader.Read()) {
                        return new Usuario {
                            UsuarioId = reader.GetInt32(0),
                            NombreUsuario = reader.GetString(1),
                            ContrasenaHash = reader.GetString(2),
                            NombreCompleto = reader.IsDBNull(3) ? "" : reader.GetString(3),
                            RolId = reader.GetInt32(4),
                            RolNombre = reader.GetString(5)
                        };
                    }
                }
                conn.Close();
            }
            return null;
        }
    }
}
