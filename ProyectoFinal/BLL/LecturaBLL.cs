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
    public class LecturaBLL
    {
        public static bool Guardar(Lectura lectura)
        {
            bool guardado = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.lecturas.Add(lectura) != null)
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

        public static bool Modificar(Lectura lectura)
        {

            bool modificado = false;

            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(lectura).State = EntityState.Modified;
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

                Lectura lectura = contexto.lecturas.Find(id);
                contexto.lecturas.Remove(lectura);
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

        public static Lectura Buscar(int id)
        {

            Lectura lectura = new Lectura();
            Contexto contexto = new Contexto();

            try
            {
                lectura = contexto.lecturas.Find(id);
                contexto.Dispose();

            }

            catch (Exception)
            {

                throw;

            }

            return lectura;

        }

        public static List<Lectura> GetList(Expression<Func<Lectura, bool>> expression)
        {

            List<Lectura> lectura = new List<Lectura>();
            Contexto contexto = new Contexto();

            try
            {

                lectura = contexto.lecturas.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return lectura;
        }

        public static string RetornarAutor(string Autor)
        {
            string autor = string.Empty;
            var lista = GetList(x => x.Autor.Equals(Autor));
            foreach (var item in lista)
            {
                autor = item.Autor;
            }

            return autor;
        }
    }
}

