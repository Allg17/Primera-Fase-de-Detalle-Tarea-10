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
    class PagosCargosBLL
    {
        public static bool Guardar(PagosCargos pagos)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();
                contex.PagoCargo.Add(pagos);
                contex.SaveChanges();
                paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(PagosCargos pago)
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

                var pago = contex.PagoCargo.Find(Id);

                contex.PagoCargo.Remove(pago);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static PagosCargos Buscar(int EstudianteId)
        {
            PagosCargos pagos = new PagosCargos();

            try
            {
                Contexto contex = new Contexto();
                pagos = contex.PagoCargo.Find(EstudianteId);
            }
            catch (Exception)
            {
                throw;
            }

            return pagos;
        }

        public static List<PagosCargos> GetList(Expression<Func<PagosCargos, bool>> criterioBusqueda)
        {
            List<PagosCargos> pagos = new List<PagosCargos>();
            try
            {
                Contexto contex = new Contexto();
                pagos = contex.PagoCargo.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return pagos;
        }
    }
}
