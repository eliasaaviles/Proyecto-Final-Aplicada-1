using System;
using ProyectoFinal.Entidades;
using System.Collections.Generic;
using ProyectoFinal.DAL;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Linq.Expressions;

namespace ProyectoFinal.BLL
{
   public class CantoBLL
    {
        public static bool Guardar(Canto canto)
        {
            bool guardado = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.cantos.Add(canto) != null)
                {
                    contexto.SaveChanges();
                    guardado = true;
                }

                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return guardado;
        }

        public static bool Modificar(Canto canto)
        {

            bool modificado = false;

            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(canto).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    modificado = true;

                }

                contexto.Dispose();

            }

            catch (Exception)
            {

                throw;

            }

            return modificado;
            
        }
        
        public static bool Eliminar(int id)
        {

            bool eliminado = false;

            Contexto contexto = new Contexto();

            try
            {

                Canto canto = contexto.cantos.Find(id);
                contexto.cantos.Remove(canto);
                if (contexto.SaveChanges() > 0)
                {

                    eliminado = true;

                }

                contexto.Dispose();

            }

            catch (Exception)
            {

                throw;

            }

            return eliminado;

        }
        
        public static Canto Buscar(int id)
        {

            Canto canto = new Canto();
            Contexto contexto = new Contexto();

            try
            {
                canto = contexto.cantos.Find(id);
                contexto.Dispose();

            }

            catch (Exception)
            {

                throw;

            }

            return canto;

        }

        public static List<Canto> GetList(Expression<Func<Canto, bool>> expression)
        {

            List<Canto> canto = new List<Canto>();
            Contexto contexto = new Contexto();

            try
            {

                canto = contexto.cantos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return canto;
        }

        public static string RetornarNombre(string Nombre)
        {
            string nombre = string.Empty;
            var lista = GetList(x => x.Nombre.Equals(Nombre));
            foreach (var item in lista)
            {
                nombre = item.Nombre;
            }

            return nombre;
        }
    }
}
