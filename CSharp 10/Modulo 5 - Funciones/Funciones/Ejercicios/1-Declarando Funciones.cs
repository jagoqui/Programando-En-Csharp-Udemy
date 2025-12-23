using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Ejercicios
{
    /*
   Haz que la funci�n DiaActual:

    - Devuelva el tipo de dato int

    - Devuelva el n�mero del d�a de hoy en el mes

    Nota: Recuerda que puedes usar DateTime para obtener la fecha actual.
     */

    public class DeclarandoFunciones
    {
        public int ObtenerDiaActual()
        {
            return DateTime.Today.Day;
        }
    }
}
