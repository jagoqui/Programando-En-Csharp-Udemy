using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Ejercicios
{
    /*
    Tenemos una funci�n ImprimirSumaYMultiplicacion la cual recibe 3 par�metros del tipo entero. La idea es:

    - Sumar los dos primeros par�metros

    - Multiplicar los dos primeros par�metros

    - Imprimir en la consola n veces el siguiente texto:

    VALOR_SUMA - VALOR_MULTIPLICACION

    Donde VALOR_SUMA es el resultado de sumar los dos primeros par�metros, mientras que VALOR_MULTIPLICACION 
    es el resultado de multiplicar los dos primeros par�metros.

    Aqu� un ejemplo de lo que esperamos tener impreso en la consola si a = 3, b = 4 y veces = 2:

    7 - 12
    7 - 12

    FIN DEL EJEMPLO.
    
    Lo que debes hacer

    - Crear 3 variables que almacecen una funci�n cada una

    - En una variable sumar debes colocar una funci�n an�nima que sume sus dos par�metros

    - En una variable multiplicar debes colocar una funci�n an�nima que multiplique sus dos par�metros

    - En una variable imprimir debes colocar una funci�n an�nima que imprima n veces el texto con el formato descrito arriba.

    - Colocar estas variables en el lugar indicado en el c�digo.

    Nota: Para imprimir en la consola utiliza Console.WriteLine.

    Remueve las dos l�neas indicadas m�s abajo para descomentar el c�digo y comenzar el ejercicio.

     */

    public class FuncionesAnonimas
    {
        public void ImprimirSumaYMultiplicacion(int a, int b, int veces)
        {
            // T� codigo va debajo de aqu�
            Func<int, int, int> sumar = (int x, int y) =>  x + y;
            Func<int, int, int> multiplicar = (int x, int y) => x * y;
            Action<int, int, int> imprimir = (int suma, int multiplicacion, int n) =>
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"{suma} - {multiplicacion}");
                }
            };



            // T� codigo va encima de aqu�

            int suma = sumar(a, b);
            int multiplicacion = multiplicar(a, b);
            imprimir(suma, multiplicacion, veces);
        }

    }
}
