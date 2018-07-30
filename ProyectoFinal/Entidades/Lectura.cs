using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
   public class Lectura
    {
        [Key]

        public int LecturaId { get; set; }
        public string Autor { get; set; }
        public string Tipo { get; set; }
        public string Abreviatura { get; set; }
       
        

        public Lectura()
        {
            LecturaId = 0;
            Autor = string.Empty;
            Tipo = string.Empty;
            Abreviatura = string.Empty;

        }

        public override string ToString()
        {
            return this.Autor;
        }
    }
}
