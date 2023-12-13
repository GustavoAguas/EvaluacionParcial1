using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionParcial1.Ejercicios
{
    internal class Ejercicio4
    {
        public static void EjecutarEjercicio4()
        {
            Estudiante estudiante1 = new Estudiante
            {
                Nombre = "Gustavo",
                Edad = 21,
                Calificacion = 9.5
            };

            estudiante1.MostrarInformacion();
        }
    }
}
