
using System.Reflection;
using Variables.Ejercicios;

namespace Pruebas
{
    [TestClass]
    public class NumerosEnterosPruebas
    {
        [TestMethod]
        public void ElMetodoDevuelve42()
        {
            var clase = new NumerosEnteros();
            var tipo = clase.GetType();

            var metodo = tipo.GetMember("Ejercicio");

            if (metodo.Length == 0)
            {
                Assert.Fail("Debes implementar el m�todo Ejercicio");
            }

            var respuesta = tipo.InvokeMember("Ejercicio", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod, 
                null, clase, new object[] { });
            
            if (respuesta is not int)
            {
                Assert.Fail("El tipo de dato de retorno debe ser un entero");
            }

            var respuestaINT = (int)respuesta;
            Assert.AreEqual(42, respuestaINT);
        }
    }
}