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
    public class ResponsableBLL
    {
        public static bool Guardar(Responsable responsable)
        {
            bool guardado = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.responsables.Add(responsable) != null)
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

        public static bool Modificar(Responsable responsable)
        {

            bool modificado = false;

            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(responsable).State = EntityState.Modified;
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

                Responsable responsable = contexto.responsables.Find(id);
                contexto.responsables.Remove(responsable);
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

        public static Responsable Buscar(int id)
        {

            Responsable responsable = new Responsable();
            Contexto contexto = new Contexto();

            try
            {
                responsable = contexto.responsables.Find(id);
                contexto.Dispose();

            }

            catch (Exception)
            {

                throw;

            }

            return responsable;

        }

        public static List<Responsable> GetList(Expression<Func<Responsable, bool>> expression)
        {

            List<Responsable> responsable = new List<Responsable>();
            Contexto contexto = new Contexto();

            try
            {

                responsable = contexto.responsables.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return responsable;
        }

        public static string RetornarNombre(string Autor)
        {
            string nombre = string.Empty;
            var lista = GetList(x => x.Nombre.Equals(Autor));
            foreach (var item in lista)
            {
                nombre = item.Nombre;
            }

            return nombre;
        }
    }
}

