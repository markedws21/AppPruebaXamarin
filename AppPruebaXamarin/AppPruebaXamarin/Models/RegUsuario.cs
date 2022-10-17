using System;
using System.Collections.Generic;
using System.Text;

namespace AppPruebaXamarin.Models
{
    public class RegUsuario
    {
        public Guid usuarioId { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
    }
}
