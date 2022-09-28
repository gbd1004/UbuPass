using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace LibClass.Tests
{
    [TestClass()]
    public class LoggerTests
    {
        [TestMethod()]
        public void LoggerTest()
        {
            Assert.IsNotNull(new Logger());
        }

        [TestMethod()]
        public void addLogUsuarioTest()
        {
            Logger l = new Logger();
            l.addLogUsuario(11111);
            Assert.AreEqual("<" + DateTime.Now.ToString() + "> El usuario " + "11111" + " inició sesión.\n", l.obtenerLista());
        }

        [TestMethod()]
        public void addLogEntradaNuevaTest()
        {
            Logger l = new Logger();
            l.addLogEntradaNueva(1234, 4321);
            Assert.AreEqual("<" + DateTime.Now.ToString() + "> El usuario " + "1234" + " ha creado la entrada " + "4321" + ".\n", l.obtenerLista());
        }

        [TestMethod()]
        public void addLogEntradaAccesoCorrectoTest()
        {
            Logger l = new Logger();
            l.addLogEntradaAccesoCorrecto(1234, 4321);
            Assert.AreEqual("<" + DateTime.Now.ToString() + "> El usuario " + "1234" + " ha accedido a la entrada " + "4321" + ".\n", l.obtenerLista());
        }

        [TestMethod()]
        public void addLogEntradaAccesoInorrectoTest()
        {
            Logger l = new Logger();
            l.addLogEntradaAccesoInorrecto(1234, 4321);
            Assert.AreEqual("<" + DateTime.Now.ToString() + "> El usuario " + "1234" + " ha intentado acceder a la entrada " + "4321" + ". Permiso denegado.\n", l.obtenerLista());
        }

        //[TestMethod()]
        //public void obtenerListaTest()
        //{
        //    Assert.Fail();
        //}
    }
}