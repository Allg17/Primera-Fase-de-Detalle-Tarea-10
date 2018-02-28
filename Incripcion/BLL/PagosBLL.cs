using Incripcion.DAL;
using Incripcion.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Incripcion.BLL
{
    class PagosBLL
    {
        
            public static bool Guardar(Pagos pagos)
            {
                bool paso = false;

                try
                {
                    Contexto contex = new Contexto();
                    contex.Pagos.Add(pagos);
                    contex.SaveChanges();
                    paso = true;
                }
                catch (Exception)
                {
                    throw;
                }
                return paso;
            }

            public static bool Modificar(Pagos pago)
            {
                bool paso = false;

                try
                {
                    Contexto contex = new Contexto();

                    contex.Entry(pago).State = EntityState.Modified;
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

            public static bool Eliminar(int Id)
            {
                bool paso = false;

                try
                {
                    Contexto contex = new Contexto();

                    var pago = contex.Pagos.Find(Id);

                    contex.Pagos.Remove(pago);
                    contex.SaveChanges();

                    paso = true;
                }
                catch (Exception)
                {
                    throw;
                }

                return paso;
            }

            public static Pagos Buscar(int EstudianteId)
            {
                Pagos pagos = new Pagos();

                try
                {
                    Contexto contex = new Contexto();
                    pagos = contex.Pagos.Find(EstudianteId);
                }
                catch (Exception)
                {
                    throw;
                }

                return pagos;
            }

            public static List<Pagos> GetList(Expression<Func<Pagos, bool>> criterioBusqueda)
            {
                List<Pagos> pagos = new List<Pagos>();
                try
                {
                    Contexto contex = new Contexto();
                    pagos = contex.Pagos.Where(criterioBusqueda).ToList();
                }
                catch (Exception)
                {
                    throw;
                }

                return pagos;
            }
        
    }
}
