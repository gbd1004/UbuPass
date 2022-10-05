namespace LibClass
{
    public class Usuario
    {
        private readonly int idUsuario;
        private string nombre;
        private string email;
        private bool esGestor;
        private string contraseñaEncriptada;

        public Usuario(int idUsuario, string nombre, string email, bool esGestor, string contraseñaEncriptada)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.email = email;
            this.esGestor = esGestor;
            this.contraseñaEncriptada = contraseñaEncriptada;
        }

        public int IdUsuario { get => idUsuario; }
        public string Nombre { get => Nombre1; set => Nombre1 = value; }
        public string Nombre1 { get => nombre; set => nombre = value; }
        public string ContraseñaEncriptada { set => contraseñaEncriptada = value; }
        public string Email { get => email; set => email = value; }
    }
}