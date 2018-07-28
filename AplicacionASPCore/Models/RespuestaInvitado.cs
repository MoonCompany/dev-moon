using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace AplicacionASPCore.Models
{
    public class RespuestaInvitado
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Nombre { get; set; } 
        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool? Asistira { get; set; }
    }
}
