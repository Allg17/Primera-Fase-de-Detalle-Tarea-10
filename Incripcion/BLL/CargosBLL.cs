using Incripcion.DAL;
using Incripcion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Incripcion.BLL
{
    class CargosBLL
    {
        public static bool Guardar(Cargos cargo)
        {
            bool paso = false;
            try
            {
                Contexto contex = new Contexto();
                if(contex.Cargo.Add(cargo)!=null)
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
                var cargo = contex.Cargo.Find(ID);
                if(contex.Cargo.Remove(cargo)!=null)
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

        public static bool Modificar(Cargos cargo)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();
                contex.Entry(cargo).State = System.Data.Entity.EntityState.Modified;
                if(contex.SaveChanges()>0)
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

        public static Cargos Buscar(int ID)
        {
            Cargos cargo = new Cargos();
            try
            {
                Contexto contex = new Contexto();
                cargo =  contex.Cargo.Find(ID);

            }
            catch (Exception)
            {

                throw;
            }
            return cargo;
        }

        public static List<Cargos> GetList(Expression<Func<Cargos, bool >> Cargo)
        {
            List<Cargos> cargo = new List<Cargos>();
            try
            {
                Contexto contex = new Contexto();
                cargo =  contex.Cargo.Where(Cargo).ToList();

            }
            catch (Exception)
            {

                throw;
            }
            return cargo;
        }
    }
}
