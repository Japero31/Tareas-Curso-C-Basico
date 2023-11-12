
namespace Edad_de_persona.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public string VerificarMayorEdad()
        {
            if (Edad >= 18)
            {
                return "Es mayor de edad.";
            }
            else
            {
                return "No es mayor de edad.";
            }
        }
    }
}
