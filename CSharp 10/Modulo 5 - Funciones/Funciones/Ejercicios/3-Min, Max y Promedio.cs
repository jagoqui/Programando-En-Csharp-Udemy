using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Ejercicios
{
    /*
    Implementa una funci�n, llamada ObtenerMinMaxPromedio, que reciba un arreglo de enteros, y devuelva el valor m�ximo de dicho arreglo, 
    el valor m�nimo, y el valor promedio.

    Para este ejercicio, utilizaremos par�metros out para extraer los tres valores.

    La funci�n devolver� true si el arreglo de enteros tiene al menos un elemento, si tiene cero elementos devolver� false.

    El orden de los par�metros es: int[] numeros, int minimo, int maximo, double promedio

    Nota: debes de colocar out en los par�metros adecuados.
     */

    public class MinMaxPromedio
    {
        public static bool ObtenerMinMaxPromedio(int[] numeros, out int minimo, out int maximo, out double promedio)
        {
            if (numeros.Length == 0)
            {
                minimo = 0;
                maximo = 0;
                promedio = 0;
                return false;
            }

            minimo = numeros.Min();
            maximo = numeros.Max();
            promedio = numeros.Average();

            return true;
        }
    }
}
