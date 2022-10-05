using System.Security.Cryptography;

namespace LibClass
{
    public static class Util
    {
        public static string Encriptar(string password)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
            SHA256 mySHA256 = SHA256.Create();
            bytes = mySHA256.ComputeHash(bytes);
            return (System.Text.Encoding.ASCII.GetString(bytes));
        }

        public static bool comprobarContrasena(string contrasena) { 
            return true;
        }
    }
}
