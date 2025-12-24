namespace Clases.Ejercicios.Ejercicio4
{
    /*
    Debajo tenemos una clase Persona, la cual tiene 3 propiedades. En esta clase debes colocar dos constructores:

    1) El primer constructor tendr� los valores de Nombre y Apellido (en ese mismo orden).

    2) El segundo constructor tendr� los valores de Nombre, Apellido y FechaNacimiento (en ese mismo orden).

    Nota: Si vas a utilizar el valor por defecto de un tipo (como DateTime)
     */

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        // Primer constructor
        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = default; // Valor por defecto de DateTime
        }

        // Segundo constructor
        public Persona(string nombre, string apellido, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }
    }
}