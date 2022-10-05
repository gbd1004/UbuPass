using LibClass;
using System.Collections.Generic;

namespace Data
{
    public class Class1 : ICapaDatos
    {

        private List<Usuario> usuarios = new List<Usuario>();
        private List<Entrada> entradas = new List<Entrada>();

        bool ICapaDatos.BorraUsuario(int idUsuario)
        {
            foreach (Usuario usuario in usuarios) {
                if (usuario.IdUsuario == idUsuario) {
                    BorrarAcesosUsuario(usuario);
                    // BORRAR ENTRADAS USUARIO
                    return usuarios.Remove(usuario);
                }
            }
            return false;
        }

        private bool ExisteEntradaDeUsuario(Usuario usuario)
        {
            foreach(Entrada entrada in entradas)
            {
                if (entrada.Usuario == usuario)
                {
                    return true;
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

        bool ICapaDatos.BorraUsuario(string nombre)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nombre == nombre){
                    return usuarios.Remove(usuario);
                }
            }
            return false;
        }

        Usuario ICapaDatos.getUsuario(string nombre)
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

        Usuario ICapaDatos.getUsuario(int idUsuario)
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

        int ICapaDatos.NumeroUsuarios()
        {
            return usuarios.Count;
        }
    }
}