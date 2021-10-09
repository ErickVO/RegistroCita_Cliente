using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCita_Cliente.Models
{
  public class Citas
    {
     [Required(ErrorMessage = "Este campo no puede estar vacio.")]
     public int CitaId { get; set; }
     [Required(ErrorMessage = "Este campo no puede estar vacio.")]
     public string Descripcion { get; set; }
     [Required(ErrorMessage = "Este campo no puede estar vacio.")]
     public DateTime Fecha_Cita { get; set; }


      public Citas()
      {
        CitaId = 0;
        Descripcion = string.Empty;
        Fecha_Cita = DateTime.Now;
        
      }
        
  }
}
