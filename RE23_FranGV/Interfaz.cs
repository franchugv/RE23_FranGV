using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE23_FranGV
{
    public static class Interfaz
    {


        public static float SolicitarNum()
        {
            // VARIABLES
            float data = 0;
            string aux = null;
            bool esValido;

            do
            {
                esValido = true;

                // Entrada - Interfaz en Modo Texto
                Console.Write("Introduzca Horas: ");
                aux = Console.ReadLine();

                try
                {
                    // Proceso de Validación
                    data = Comprobaciones.ValidarNum(aux);
                }
                catch (Exception error)
                {
                    // SALIDA - Retroalimentación de Errores
                    esValido = false;   // Actualización del detector de errores
                    Console.WriteLine("ERROR: " + error.Message);
                }

            } while (!esValido);

            // SALIDA - Método
            return data;
        }

    }
}
