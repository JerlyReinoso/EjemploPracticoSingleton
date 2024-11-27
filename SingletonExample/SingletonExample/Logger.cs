using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    internal class Logger
    {
        // Campo estático que guarda la instancia única
        private static Logger _instance;

        // Constructor privado
        private Logger()
        {
            Console.WriteLine("Logger creado.");
        }

        // Método público para obtener la instancia única
        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        // Método para registrar mensajes
        public void LogMessage(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}

