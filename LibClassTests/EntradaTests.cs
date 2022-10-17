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
    public class EntradaTests
    {
        private Usuario usuario = new Usuario(1, "usuario1", "pepe@email.com", false, Util.Encriptar("1234"));

        [TestMethod()]
        public void EntradaTest()
        {
            Entrada e = new Entrada(1, usuario, Util.Encriptar("1234"));
            Usuario usuario2 = new Usuario(2, "usuario1", "pepe@email.com", false, Util.Encriptar("1234"));
            Assert.IsNotNull(e);
            Assert.IsNotNull(e.Usuarios);
            e.anadirAccesoAUsuario(usuario2);
            Assert.AreEqual(e.Usuarios[0], usuario2);
            e.ContraseñaEncriptada = Util.Encriptar("1234");
            Assert.AreEqual(e.ContraseñaEncriptada, Util.Encriptar("1234"));

        }

        [TestMethod()]
        public void numeroDeUsuariosConAccesoTest()
        {

            Entrada e = new Entrada(1, usuario, Util.Encriptar("1234"));
            Usuario usuario1 = new Usuario(1, "usuario1", "pepe@email.com", false, Util.Encriptar("1234"));
            Usuario usuario2 = new Usuario(2, "usuario2", "pepe@email.com", false, Util.Encriptar("1234"));
            Usuario usuario3 = new Usuario(3, "usuario3", "pepe@email.com", false, Util.Encriptar("1234"));

            e.anadirAccesoAUsuario(usuario1);
            e.anadirAccesoAUsuario(usuario2);
            e.anadirAccesoAUsuario(usuario3);
            Assert.AreEqual(e.numeroDeUsuariosConAcceso(), 3);

        }

        [TestMethod()]
        public void anadirAccesoAUsuarioTest()
        {
            Entrada e = new Entrada(1, usuario, Util.Encriptar("1234"));
            Usuario usuario1 = new Usuario(1, "usuario1", "pepe@email.com", false, Util.Encriptar("1234"));
            Usuario usuario2 = new Usuario(2, "usuario2", "pepe@email.com", false, Util.Encriptar("1234"));
            Usuario usuario3 = new Usuario(3, "usuario3", "pepe@email.com", false, Util.Encriptar("1234"));

            e.anadirAccesoAUsuario(usuario1);
            e.anadirAccesoAUsuario(usuario2);
            e.anadirAccesoAUsuario(usuario3);
            Assert.AreEqual(e.numeroDeUsuariosConAcceso(), 3);
        }

        [TestMethod()]
        public void eleminarAccesoAUsuarioTest()
        {
            Entrada e = new Entrada(1, usuario, Util.Encriptar("1234"));
            Usuario usuario1 = new Usuario(1, "usuario1", "pepe@email.com", false, Util.Encriptar("1234"));
            Usuario usuario2 = new Usuario(2, "usuario2", "pepe@email.com", false, Util.Encriptar("1234"));
            Usuario usuario3 = new Usuario(3, "usuario3", "pepe@email.com", false, Util.Encriptar("1234"));

            e.anadirAccesoAUsuario(usuario1);
            e.anadirAccesoAUsuario(usuario2);
            e.anadirAccesoAUsuario(usuario3);
            e.eleminarAccesoAUsuario(usuario1);
            Assert.AreEqual(e.numeroDeUsuariosConAcceso(), 2);
        }
    }
}