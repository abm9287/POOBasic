namespace SimulacionEconomica
{
    class Persona
    {
        // Propiedades - Estado
        public int Id { get; set; }
        public string Nombre { get; set; }

        Celular celular;
        public Celular MiCelular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
                celular.Propietario = this;
            }
        }

        // Métodos - Comportamiento
        public string Saludar(string nombre)
        {
            return $"Hola {nombre} me llamo {Nombre}";
        }

        public string Productos()
        {
            if (celular != null)
                return $"Tengo un celular {celular.Modelo}";
            else
                return "No tengo celular";
        }
    }
}