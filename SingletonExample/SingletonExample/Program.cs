using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Obtener la instancia única del Logger
            Logger logger1 = Logger.GetInstance();
            logger1.LogMessage("Primera entrada de log.");

            // Obtener la misma instancia
            Logger logger2 = Logger.GetInstance();
            logger2.LogMessage("Segunda entrada de log.");

            // Verificar si ambas instancias son iguales
            Console.WriteLine(Object.ReferenceEquals(logger1, logger2)
                ? "Las instancias son iguales."
                : "Las instancias son diferentes.");
        }
    }
}

