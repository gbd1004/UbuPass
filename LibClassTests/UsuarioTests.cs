using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClass.Tests
{
    [TestClass()]
    public class UsuarioTests
    {
        [TestMethod()]
        public void UsuarioTest()
        {
            Usuario u = new Usuario(1, "Pedro", "Jaja", "sisisisisis@pito.cum", "1234");

            Assert.IsNotNull(u);
            Assert.AreEqual(u.Nombre, "Pedro");
            u.Nombre = "Peter";
            Assert.AreEqual(u.Nombre, "Peter");
            Assert.IsFalse(u.Nombre.Equals("Pedro"));
        }
    }
}