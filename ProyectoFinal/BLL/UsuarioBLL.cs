using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ProyectoFinal.BLL
{
    public class UsuarioBLL
    {
        public static bool Guardar(Usuario use)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.usuarios.Add(use) != null)
                {
                    db.SaveChanges();
                    paso = true;
                }


            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.usuarios.Find(Id);
                if (eliminar != null)
                {
                    db.Entry(eliminar).State = EntityState.Deleted;
                    if (db.SaveChanges() > 0)
                    {
                        paso = true;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static bool Modificar(Usuario use)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(use).State = EntityState.Modified;
                if (db.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        public static Usuario Buscar(int id)
        {
            Usuario usuario = new Usuario();
            Contexto db = new Contexto();
            try
            {
                usuario = db.usuarios.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return usuario;
        }

        public static List<Usuario> GetList(Expression<Func<Usuario, bool>> usuarios)
        {
            List<Usuario> usuario = new List<Usuario>();
            Contexto db = new Contexto();
            try
            {
                usuario = db.usuarios.Where(usuarios).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return usuario;
        }


    }
}
