using System;

namespace SimulacionEconomica
{
    class Program
    {
        public static void Main(string []args)
        {
            Console.WriteLine("Hola mundo!");

            int id = 1;
            string nombre = "Anita";

            Persona investigador = new Persona
            {
                Id = id,
                Nombre = nombre
            };

            string personaLaQueSaludo = "Gabriel García Moreno ";
            string saludo = investigador.Saludar(personaLaQueSaludo);

            Console.WriteLine(saludo);
            Console.ReadKey();
        }
    }
}
