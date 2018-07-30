using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Hermano
    {
        [Key]
        public int HermanoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoCelular { get; set; }
        public string TelefonoOtro { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int TotalHermano  { get; set; }


        public Hermano()
        {
            HermanoId = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Direccion = string.Empty;
            TelefonoCasa = string.Empty;
            TelefonoCelular = string.Empty;
            TelefonoOtro = string.Empty;
            Cedula = string.Empty;
            FechaNacimiento = DateTime.Now;
            TotalHermano = 0;

        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
