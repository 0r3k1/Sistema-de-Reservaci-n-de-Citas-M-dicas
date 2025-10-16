using CapaDatos.Modelos;
using CapaDatos.Repositorios;
using System.Security.Cryptography;
using System.Text;

namespace CapaLogica.Servicios {
    public class AuthService {
        private readonly UsuarioRepository _usuarioRepo = new UsuarioRepository();

        public Usuario? Login(string nombreUsuario, string contrasena) {
            string hash = CalcularHash(contrasena);
            return _usuarioRepo.ValidarUsuario(nombreUsuario, hash);
        }

        public static string CalcularHash(string input) {
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
