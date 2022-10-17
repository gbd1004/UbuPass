using LibClass;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal interface ICapaDatos
    {

        // Métodos copiados de la pantalla del profesor
        // Hay que hacer una clase que implemente esta interfaz

        int NumeroUsuarios();

        int NumeroEntradas();

        bool BorraUsuario(string nombre);

        bool BorraUsuario(int idUsuario);

        Usuario GetUsuario(string nombre);

        Usuario GetUsuario(int idUsuario);

        Usuario GetUsuarioEmail(string email);

        bool BorrarEntradasDeUsuario(int idUsuario);

        bool BorrarEntrada(int idEntrada);

        int AnadirUsuario(string nombre, string email, bool esGestor, string contrasena);

        int AnadirEntrada(int idUsuario, string contrasena);

        Entrada GetEntrada(int idEntrada);
    }
}
