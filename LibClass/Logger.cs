namespace LibClass
{
    public  class Log
    {
        private List<string> logs;

        public Log()
        {
            logs = new List<string>();
        }

        public void addLogUsuario(string nombre)
        {
            DateTime fecha = DateTime.Now;
            string texto = "<" + fecha.ToString() + "> El usuario " + nombre + " inició sesión.";
            this.logs.Add(texto);
        }

        public void addLogEntradaNueva(string nombre, int idEntrada)
        {
            DateTime fecha = DateTime.Now;
            string texto = "<" + fecha.ToString() + "> El usuario " + nombre + " ha creado la entrada " + idEntrada + ".";
            this.logs.Add(texto);
        }

        public void addLogEntradaAccesoCorrecto(string nombre, int idEntrada)
        {
            DateTime fecha = DateTime.Now;
            string texto = "<" + fecha.ToString() + "> El usuario " + nombre + " ha accedido a la entrada " + idEntrada + ".";
            this.logs.Add(texto);
        }

        public void addLogEntradaAccesoInorrecto(string nombre, int idEntrada)
        {
            DateTime fecha = DateTime.Now;
            string texto = "<" + fecha.ToString() + "> El usuario " + nombre + " ha intentado acceder a la entrada " + idEntrada + ". Permiso denegado.";
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
