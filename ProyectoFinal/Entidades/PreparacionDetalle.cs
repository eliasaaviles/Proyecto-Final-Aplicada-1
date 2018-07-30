using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    class PreparacionDetalle
    {
        [Key]
        public int Id { get; set; }
        public int PreparacionId { get; set; }
        public DateTime FechaPresentar { get; set; }
        public int ResponsableId { get; set; }
        public int HermanoId { get; set; }
        public string Tema { get; set; }
        public string Responsable { get; set; }
        public string Integrante { get; set; }
              
    }
}
