using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCita_Cliente.Models
{
    public class Usuarios
    {
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string NombreUsuario { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Contraseña { get; set; }

        public bool Accesibilidad { get; set; }
        public string Token { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            Apellidos = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
            NombreUsuario = string.Empty;
            Contraseña = string.Empty;
            Accesibilidad = true;
            Token = string.Empty;
        }
        
    }
}
