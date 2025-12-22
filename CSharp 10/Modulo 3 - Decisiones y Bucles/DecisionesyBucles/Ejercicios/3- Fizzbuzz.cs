namespace DecisionesyBucles.Ejercicios
{
    /*
    Escribir un programa que muestre en pantalla los n�meros del 1 hasta n, sustituyendo los m�ltiplos de 3 por la palabra �fizz�, los m�ltiplos de 5 por �buzz� y los m�ltiplos de ambos, es decir, los m�ltiplos de 3 y 5 (o de 15), por la palabra �fizzbuzz�.

    La variable n es un entero la cual ya viene dada, no tienes que declararla.

    Ejemplo, si n es 15, pues en la consola se debe imprimir (f�jate que es fizz, buzz y fizbuzz sin may�sculas):

    1
    2
    fizz
    4
    buzz
    fizz
    7
    8
    fizz
    buzz
    11
    fizz
    13
    14
    fizzbuzz

    Nota: Para este ejercicio, siempre debes usar Console.WriteLine para imprimir en la consola.
     */

    public class FizzBuzz
    {
        public static void Realizar(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}