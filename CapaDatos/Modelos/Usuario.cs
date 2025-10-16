using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelos {
    public class Usuario {
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string ContrasenaHash { get; set; }
        public string NombreCompleto { get; set; }
        public int RolId { get; set; }
        public string RolNombre { get; set; } // Se llenará con JOIN
    }
}
