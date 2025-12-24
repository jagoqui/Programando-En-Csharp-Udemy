namespace Clases.Ejercicios.Ejercicio1
{
  /*
  Este ejercicio se divide en dos partes:

  A) Crea una clase llamada "Persona" la cual va a tener 3 campos: 

  1) _nombre (tipo de dato string), 

  2) _apellido (tipo de datostring), 

  3) _fechaNacimiento�(tipo de dato DateTime).

  Nota: respeta las may�sculas en los nombres, tanto de la clase como de los campos.

  Nota 2: La clase debe tener el modificador de acceso "public". (Igual que la clase Ejercicio que tenemos m�s abajo).

  Nota 3: Igualmente, los campos deben tener el modificador de acceso public.

  B) Crea un m�todo llamado ConstruirPersona dentro de la clase Ejercicio. Este m�todo debe:

  1) Tener Persona como tipo de dato de salida

  2) Tener 3 par�metros: nombre (string), apellido�(string) y fechaNacimiento (DateTime)

  3) El m�todo debe instanciar una Persona utilizando los 3 par�metros.

  4) El m�toro debe devolver dicha instancia de la clase Persona.
    */

  // Aqu� puedes crear la clase (Nota: col�cala como public)


  public class Persona
  {
    public string _nombre;
    public string _apellido;
    public DateTime _fechaNacimiento;
  }


  public class Ejercicio
  {

    public Persona ConstruirPersona(string nombre, string apellido, DateTime fechaNacimiento)
    {
      Persona persona = new Persona();
      persona._nombre = nombre;
      persona._apellido = apellido;
      persona._fechaNacimiento = fechaNacimiento;

      return persona;
    }

  }

}