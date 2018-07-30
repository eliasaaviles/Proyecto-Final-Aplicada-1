using System;
using ProyectoFinal.Entidades;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFinal.DAL
{
   
        public class Contexto : DbContext
        {
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Canto> cantos { get; set; }
            public DbSet<Hermano> hermanos { get; set; }
            public DbSet<Lectura> lecturas { get; set; }
            public DbSet<Responsable> responsables { get; set; }
            
            public Contexto() : base("ConStr") { }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
            }
        }
    }

