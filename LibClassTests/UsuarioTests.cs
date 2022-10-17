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
        // Este método prueba tanto el constructor, como getters y setters de la clase Usuario
        [TestMethod()]
        public void UsuarioTest()
        {
            Usuario test = new Usuario(0, "Pepe", "pepe@gmail.com", true, "contraseña");
            Assert.IsNotNull(test);

            Assert.AreEqual(test.IdUsuario, 0);

            Assert.AreEqual(test.Email, "pepe@gmail.com");
            test.Email = "pepe@hotmail.com";
            Assert.AreEqual(test.Email, "pepe@hotmail.com");

            Assert.AreEqual(test.EsGestor, true);
            test.EsGestor = false;
            Assert.AreEqual(test.EsGestor, false);

            Assert.AreEqual(test.ContraseñaEncriptada, "contraseña");
            test.ContraseñaEncriptada = "contraseñaNueva";
            Assert.AreEqual(test.ContraseñaEncriptada, "contraseñaNueva");
        }
    }
}