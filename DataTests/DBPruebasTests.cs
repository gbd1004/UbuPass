using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibClass;
using System.Diagnostics;

namespace Data.Tests
{
    [TestClass()]
    public class DBPruebasTests
    {
        [TestMethod()]
        public void DBPruebasTest()
        {
            DBPruebas test = new DBPruebas();
            Assert.IsNotNull(test);

            Assert.IsTrue(test.Usuarios.Count == 2);
            Assert.IsTrue(test.Entradas.Count == 3);

            Assert.IsTrue(test.GetEntrada(0).Usuarios.Count == 1);
        }

        [TestMethod()]
        public void BorrarEntradaTest()
        {
            DBPruebas test = new DBPruebas();
            test.BorrarEntrada(0);

            Assert.IsTrue(test.Entradas.Count == 2);
            Entrada e = test.GetEntrada(1);
            Assert.IsNotNull(e);
        }

        [TestMethod()]
        public void BorrarEntradasDeUsuarioTest()
        {
            DBPruebas test = new DBPruebas();

            int count = test.NumeroEntradas();
            Assert.IsTrue(test.BorrarEntradasDeUsuario(0));
            Assert.IsTrue(count > test.NumeroEntradas());
            Assert.IsFalse(test.BorrarEntradasDeUsuario(0));
        }

        [TestMethod()]
        public void BorraUsuarioTest()
        {
            DBPruebas test = new DBPruebas();

            int count_usuarios = test.NumeroUsuarios();
            int count_entradas = test.NumeroEntradas();
            Assert.IsTrue(test.BorraUsuario(1));
            Assert.IsTrue(count_usuarios > test.NumeroUsuarios());
            Assert.IsTrue(count_entradas > test.NumeroEntradas());
            Assert.IsTrue(test.GetEntrada(0).Usuarios.Count == 0);
            Assert.IsFalse(test.BorraUsuario(1));
        }

        [TestMethod()]
        public void BorraUsuarioTest1()
        {
            DBPruebas test = new DBPruebas();

            int count_usuarios = test.NumeroUsuarios();
            int count_entradas = test.NumeroEntradas();
            Assert.IsTrue(test.BorraUsuario("Paco"));
            Assert.IsTrue(count_usuarios > test.NumeroUsuarios());
            Assert.IsTrue(count_entradas > test.NumeroEntradas());
            Assert.IsTrue(test.GetEntrada(0).Usuarios.Count == 0);
            Assert.IsFalse(test.BorraUsuario("Paco"));
        }

        [TestMethod()]
        public void GetUsuarioTest()
        {
            DBPruebas test = new DBPruebas();

            Assert.IsNotNull(test.GetUsuario(0));
            Assert.IsNotNull(test.GetUsuario(1));
            Assert.IsNull(test.GetUsuario(2));
        }

        [TestMethod()]
        public void GetUsuarioTest1()
        {
            DBPruebas test = new DBPruebas();

            Assert.IsNotNull(test.GetUsuario("Pepe"));
            Assert.IsNotNull(test.GetUsuario("Paco"));
            Assert.IsNull(test.GetUsuario("Juan"));
        }

        [TestMethod()]
        public void NumeroUsuariosTest()
        {
            DBPruebas test = new DBPruebas();
            Assert.IsTrue(test.NumeroUsuarios() == 2);
        }

        [TestMethod()]
        public void NumeroEntradasTest()
        {
            DBPruebas test = new DBPruebas();
            Assert.IsTrue(test.NumeroEntradas() == 3);
        }

        [TestMethod()]
        public void AnadirUsuarioTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetUsuarioEmailTest()
        {
            DBPruebas test = new DBPruebas();

            Assert.IsNotNull(test.GetUsuarioEmail("pepe@gmail.com"));
            Assert.IsNotNull(test.GetUsuarioEmail("paco@gmail.com"));
            Assert.IsNull(test.GetUsuarioEmail("juan@gmail.com"));
        }

        [TestMethod()]
        public void AnadirEntradaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetEntradaTest()
        {
            DBPruebas test = new DBPruebas();

            Entrada e = test.GetEntrada(0);
            Assert.IsNotNull(e);
            Assert.IsTrue(e.IdEntrada == 0);
            Assert.IsTrue(e.Usuario.IdUsuario == 0);
            Assert.IsTrue(e.Usuarios.Count == 1);

            Assert.IsNotNull(test.GetEntrada(1));
            Assert.IsNotNull(test.GetEntrada(2));
            Assert.IsNull(test.GetEntrada(3));
        }
    }
}