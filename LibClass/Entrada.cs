using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClass
{
    public class Entrada
    {
        private readonly int idEntrada;
        private readonly Usuario usuario;
        private string contraseñaEncriptada;
        private List<Usuario> usuarios;

        public Entrada(int idEntrada, Usuario usuario, string contraseñaEncriptada)
        {
            this.idEntrada = idEntrada;
            this.usuario = usuario;
            this.contraseñaEncriptada = contraseñaEncriptada;
            this.usuarios = new List<Usuario>();
        }

        public int IdEntrada => idEntrada;

        public Usuario Usuario => usuario;

        public string ContraseñaEncriptada { set => contraseñaEncriptada = value; }
        public List<Usuario> Usuarios { get => usuarios; }
    }
}
