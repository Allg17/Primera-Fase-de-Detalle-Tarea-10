using Incripcion.DAL;
using Incripcion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Incripcion.BLL
{
    public class ArticulosBLL
    {
        public static bool Guardar(Articulos articulo)
        {
            bool paso = false;
            try
            {
                Contexto contex = new Contexto();
                if (contex.Articulo.Add(articulo) != null)
                {
                    contex.SaveChanges();
                    paso = true;
                }


            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static bool Eliminar(int ID)
        {
            bool paso = false;
            try
            {
                Contexto contex = new Contexto();
                var Articulo = contex.Articulo.Find(ID);
                if (contex.Articulo.Remove(Articulo) != null)
                {
                    contex.SaveChanges();
                    paso = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static bool Modificar(Articulos articulo)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();
                contex.Entry(articulo).State = System.Data.Entity.EntityState.Modified;
                if (contex.SaveChanges() > 0)
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

        public static Articulos Buscar(int ID)
        {
            Articulos articulos = new Articulos();
            try
            {
                Contexto contex = new Contexto();
                articulos = contex.Articulo.Find(ID);

            }
            catch (Exception)
            {

                throw;
            }
            return articulos;
        }

        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> articulo)
        {
            List<Articulos> articulos = new List<Articulos>();
            try
            {
                Contexto contex = new Contexto();
                articulos = contex.Articulo.Where(articulo).ToList();

            }
            catch (Exception)
            {

                throw;
            }
            return articulos;
        }


    }
}


