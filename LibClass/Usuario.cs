using System.ComponentModel.DataAnnotations;

namespace LibClass
{
    public class Usuario
    {
        private readonly int idUsuario;
        private string nombre;
        private bool esGestor;
        private string contraseñaEncriptada;

        public int IdUsuario { get => idUsuario; }
        public string Nombre { get => Nombre1; set => Nombre1 = value; }
        public string Nombre1 { get => nombre; set => nombre = value; }
        public string ContraseñaEncriptada { set => contraseñaEncriptada = value; }
    }
}