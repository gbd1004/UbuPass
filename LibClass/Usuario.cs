using System.ComponentModel.DataAnnotations;

namespace LibClass
{
    public class Usuario
    {
        private int idUsuario;
        private string nombre;
        private string apellidos;
        private string email;
        private string contraseña_encriptada;

        public Usuario(int idUsuario, string nombre, string apellidos, string email, string contraseña_encriptada)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.contraseña_encriptada = contraseña_encriptada;
        }

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}