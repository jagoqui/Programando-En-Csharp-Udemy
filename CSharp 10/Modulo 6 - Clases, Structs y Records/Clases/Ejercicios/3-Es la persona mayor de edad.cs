namespace Clases.Ejercicios.Ejercicio3
{
  /*
  Debajo tenemos una clase Persona, la cual tiene 3 propiedades. Una de ellas es FechaNacimiento. 
  Vamos a implementar un m�todo, llamado EsMayorDeEdad, que, como su nombre lo indica, devuelve true si 
  la persona es mayor de edad, de otro modo, devuelve false.

  Nota: Para este ejercicio vamos a asumir que se cumple la mayor�a de edad a los 18. Es decir, una persona 
  con una edad mayor o igual a 18, es mayor de edad.
    */

  public class Persona
  {
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }

    bool EsMayorDeEdad()
    {
      DateTime fechaActual = DateTime.Now;
      int edad = fechaActual.Year - FechaNacimiento.Year;

      // Verificar si la persona ya ha cumplido años este a�o
      if (fechaActual.Month < FechaNacimiento.Month ||
          (fechaActual.Month == FechaNacimiento.Month && fechaActual.Day < FechaNacimiento.Day))
      {
        edad--;
      }

      return edad >= 18;
    }
  }

}