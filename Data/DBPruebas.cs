using LibClass;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class DBPruebas : ICapaDatos
    {
        private int ultimaIdEntrada = 0;
        private int ultimaIdUsuario = 0;
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Entrada> entradas = new List<Entrada>();

        public List<Usuario> Usuarios { get => usuarios; }
        public List<Entrada> Entradas { get => entradas; }

        public DBPruebas()
        {
            int idPepe = this.AnadirUsuario("Pepe", "pepe@gmail.com", false, "1234");
            int idPaco = this.AnadirUsuario("Paco", "paco@gmail.com", true, "5678");

            int idEnt1Pepe = this.AnadirEntrada(idPepe, "abcd");
            int idEnt2Pepe = this.AnadirEntrada(idPepe, "fghi");
            int idEnt1Paco = this.AnadirEntrada(idPaco, "jklm");

            GetEntrada(idEnt1Pepe).anadirAccesoAUsuario(GetUsuario(idPaco));
        }

        public bool BorrarEntrada(int idEntrada)
        {
            foreach (Entrada entrada in entradas)
            {
                if (entrada.IdEntrada == idEntrada)
                {
                    return entradas.Remove(entrada);
                }
            }
            return false;
        }

        public bool BorrarEntradasDeUsuario(int idUsuario)
        {
            List<Entrada> entradas_temp = new List<Entrada>();
            bool hayEntradasEncontradas = false;
            foreach (Entrada entrada in entradas)
            {
                if (entrada.Usuario.IdUsuario != idUsuario)
                    entradas_temp.Add(entrada);
                else
                    hayEntradasEncontradas = true;
            }
            this.entradas = entradas_temp;
            return hayEntradasEncontradas;
        }

        public bool BorraUsuario(int idUsuario)
        {
            foreach (Usuario usuario in usuarios) {
                if (usuario.IdUsuario == idUsuario) {
                    BorrarAcesosUsuario(usuario);
                    BorrarEntradasDeUsuario(idUsuario);
                    return usuarios.Remove(usuario);
                }
            }
            return false;
        }

        private void BorrarAcesosUsuario(Usuario usuario)
        {
            foreach(Entrada entrada in entradas)
            {
                entrada.eleminarAccesoAUsuario(usuario);
            }
        }

        public bool BorraUsuario(string nombre)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nombre == nombre){
                    BorrarAcesosUsuario(usuario);
                    BorrarEntradasDeUsuario(usuario.IdUsuario);
                    return usuarios.Remove(usuario);
                }
            }
            return false;
        }

        public Usuario GetUsuario(string nombre)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nombre == nombre)
                {
                    return usuario;
                }
            }
            return null;
        }

        public Usuario GetUsuario(int idUsuario)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.IdUsuario == idUsuario)
                {
                    return usuario;
                }
            }
            return null;
        }

        public int NumeroUsuarios()
        {
            return usuarios.Count;
        }

        public int NumeroEntradas()
        {
            return entradas.Count;
        }

        public int AnadirUsuario(string nombre, string email, bool esGestor, string contrasena)
        {
            int id = -1;
            if (!new EmailAddressAttribute().IsValid(email))
                return id;
            if (ExisteUsuario(email))
                return id;
            if (!Util.comprobarContrasena(contrasena))
                return id;

            id = ultimaIdUsuario++;
            usuarios.Add(new Usuario(id, nombre, email, esGestor, Util.Encriptar(contrasena)));
            return id;
        }

        private bool ExisteUsuario(int idUsuario) {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.IdUsuario == idUsuario)
                {
                    return true;
                }
            }
            return false;
        }

        private bool ExisteUsuario(string email)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        public Usuario GetUsuarioEmail(string email)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Email == email)
                {
                    return usuario;
                }
            }
            return null;
        }

        public int AnadirEntrada(int idUsuario, string contrasena)
        {
            int id = -1;
            if (!Util.comprobarContrasena(contrasena))
                return -1;
            if (!ExisteUsuario(idUsuario))
                return -1;

            id = ultimaIdEntrada++;
            entradas.Add(new Entrada(id, GetUsuario(idUsuario), Util.Encriptar(contrasena)));
            return id;
        }

        public Entrada GetEntrada(int idEntrada)
        {
            foreach (Entrada entrada in entradas)
            {
                if (entrada.IdEntrada == idEntrada)
                {
                    return entrada;
                }
            }

            return null;
        }
    }
}