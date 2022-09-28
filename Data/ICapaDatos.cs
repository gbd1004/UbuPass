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

        bool BorrauUsuario(string nombre);

        bool BorraUsuario(int idUsuario);
    }
}
