using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
   public class Responsable
    {
        public int ResponsableId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoCelular { get; set; }
        public string TelefonoOtro { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Numero { get; set; }
        public int TotalResponsable { get; set; }
        
        public Responsable()
        {
            ResponsableId = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Direccion = string.Empty;
            TelefonoCasa = string.Empty;
            TelefonoCelular = string.Empty;
            TelefonoOtro = string.Empty;
            Cedula = string.Empty;
            FechaNacimiento = DateTime.Now;
            Numero = 0;
            TotalResponsable = 0;

        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}

