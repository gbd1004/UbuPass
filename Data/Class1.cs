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
                    return usuarios.Remove(usuario);
                }
            }
            return false;
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