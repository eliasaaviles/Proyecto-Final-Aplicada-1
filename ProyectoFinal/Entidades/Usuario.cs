using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string NombreUsuario { get; set; }
        public string Comentario { get; set; }

        public Usuario(int idUsuario, string nombre, string clave, string nombreUsuario, DateTime fecha, string comentario)
        {
            this.IdUsuario = idUsuario;
            this.Nombre = nombre;
            this.Clave = clave;
            this.NombreUsuario = nombreUsuario;
            this.Comentario = comentario;
        }

        public Usuario()
        {
            this.IdUsuario = 0;
            this.Nombre = string.Empty;
            this.Clave = string.Empty;
            this.NombreUsuario = string.Empty;
            this.Comentario = string.Empty;
        }
    }
}
