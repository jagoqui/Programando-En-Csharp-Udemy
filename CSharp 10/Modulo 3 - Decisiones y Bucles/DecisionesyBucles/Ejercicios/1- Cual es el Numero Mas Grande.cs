namespace DecisionesyBucles.Ejercicios
{
    /*
    Utiliza "if-else" para determinar cu�l entero es m�s grande, a o b. No tienes que declarar estas variables, pues ya esto est� hecho.

    Debes asignar el valor m�s grande a la variable resultado.

    T� c�digo debe ir debajo del comentario y encima del return.

    Remueve las dos l�neas indicadas m�s abajo para descomentar el c�digo y comenzar el ejercicio.
     */

    public class NumeroMayor
    {
       public int DeterminarElNumeroMayor(int a, int b){
            int resultado = a > b ? a : b;
            return resultado;
        }
    }
}