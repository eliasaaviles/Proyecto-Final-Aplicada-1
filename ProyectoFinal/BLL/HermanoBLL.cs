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
           public class HermanoBLL
        {
            public static bool Guardar(Hermano hermano)
            {
                bool guardado = false;
                Contexto contexto = new Contexto();
                try
                {
                    if (contexto.hermanos.Add(hermano) != null)
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

            public static bool Modificar(Hermano hermano)
            {

                bool modificado = false;

                Contexto contexto = new Contexto();

                try
                {
                    contexto.Entry(hermano).State = EntityState.Modified;
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

                    Hermano hermano = contexto.hermanos.Find(id);

             
                contexto.hermanos.Remove(hermano);
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

            public static Hermano Buscar(int id)
            {

                Hermano hermano = new Hermano();
                Contexto contexto = new Contexto();

                try
                {
                    hermano = contexto.hermanos.Find(id);
                    contexto.Dispose();

                }

                catch (Exception)
                {

                    throw;

                }

                return hermano;

            }

            public static List<Hermano> GetList(Expression<Func<Hermano, bool>> expression)
            {

                List<Hermano> hermano = new List<Hermano>();
                Contexto contexto = new Contexto();

                try
                {

                    hermano = contexto.hermanos.Where(expression).ToList();
                    contexto.Dispose();
                }
                catch (Exception)
                {

                    throw;
                }

                return hermano;
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

