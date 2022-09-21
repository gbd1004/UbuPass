using System.ComponentModel.DataAnnotations;

namespace LibClass
{
    public class Usuario
    {
        private int idUsuario;
        private string nombre;
        private string rol;
        private string contraseña_encriptada;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Contraseña_encriptada { set => contraseña_encriptada = value; }
    }
}