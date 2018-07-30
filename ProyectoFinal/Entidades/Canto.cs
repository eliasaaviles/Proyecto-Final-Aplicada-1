using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
   public class Canto
    {
        [Key]
        public int CantoId { get; set; }
        public string Nombre { get; set; }
        public string Versiculo { get; set; }
        public int pagina { get; set; }
        public string Color { get; set; }
        public string Momento { get; set; }
        public string Tiempo { get; set; }


        public Canto()
        {
            CantoId = 0;
            Nombre = string.Empty;
            Versiculo = string.Empty;
            pagina = 0;
            Color = string.Empty;
            Momento = string.Empty;
            Tiempo = string.Empty;

        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
