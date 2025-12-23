using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Ejercicios
{
    /*
    Crea una funci�n, llamada Saludar, la cual reciba un par�metro del tipo string, y devuelva el mensaje:

    "Hola, VALOR_DEL_PARAMETRO"

    Donde VALOR_DEL_PARAMETRO representa el valor del par�metro de la funci�n.
     */

    public class FuncionConParametro
    {
        string Saludar(string nombre)
        {
            return $"Hola, {nombre}";
        }

    }
}
