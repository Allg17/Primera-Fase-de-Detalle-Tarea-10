using Microsoft.VisualStudio.TestTools.UnitTesting;
using Incripcion.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Incripcion.Entidades;

namespace Incripcion.BLL.Tests
{
    [TestClass()]
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Articulos art = new Articulos();

            art.ArticuloID = 1;
            art.Descripcion = "Mentas";
            art.Precio = 100;
            bool paso;
            paso = BLL.ArticulosBLL.Guardar(art);
            Assert.AreEqual(paso, true);
         
        }
      

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}