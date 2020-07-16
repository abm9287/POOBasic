
namespace SimulacionEconomica
{
    class Persona
    {
        //Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }

        //Métodos (Comportamiento)
        public string Saludar(string Nombre)
        {

            return $"Hola {Nombre} me llamo {this.Nombre} ";
        }
    }
}
