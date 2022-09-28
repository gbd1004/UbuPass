namespace LibClass
{
    public  class Logger
    {
        private List<string> logs;

        public Logger()
        {
            logs = new List<string>();
        }

        public void addLogUsuario(int idusuario)
        {
            DateTime fecha = DateTime.Now;
            string texto = "<" + fecha.ToString() + "> El usuario " + idusuario + " inició sesión.";
            this.logs.Add(texto);
        }

        public void addLogEntradaNueva(int idusuario, int idEntrada)
        {
            DateTime fecha = DateTime.Now;
            string texto = "<" + fecha.ToString() + "> El usuario " + idusuario + " ha creado la entrada " + idEntrada + ".";
            this.logs.Add(texto);
        }

        public void addLogEntradaAccesoCorrecto(int idusuario, int idEntrada)
        {
            DateTime fecha = DateTime.Now;
            string texto = "<" + fecha.ToString() + "> El usuario " + idusuario + " ha accedido a la entrada " + idEntrada + ".";
            this.logs.Add(texto);
        }

        public void addLogEntradaAccesoInorrecto(int idusuario, int idEntrada)
        {
            DateTime fecha = DateTime.Now;
            string texto = "<" + fecha.ToString() + "> El usuario " + idusuario + " ha intentado acceder a la entrada " + idEntrada + ". Permiso denegado.";
            this.logs.Add(texto);
        }

        public String obtenerLista()
        {
            string texto = "";
            foreach (string i in this.logs) {
                texto += i + "\n";
            }

            return texto;
        }
    }
}
