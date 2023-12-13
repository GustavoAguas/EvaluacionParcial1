using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionParcial1.Ejercicios
{
    public class EstudianteGraduado : Estudiante
    {
        public string Titulo { get; set; }

    }



    internal class Ejercicio5
    {
        public static void EjecutarEjercicio5()
        {

            EstudianteGraduado graduado1 = new EstudianteGraduado
            {
                Nombre = "Gustavo",
                Edad = 21,
                Calificacion = 20,
                Titulo = "Ingeniero en Software"
            };

            Console.WriteLine("\nInformacion del Estudiante Graduado\n");
            graduado1.MostrarInformacion();
            Console.WriteLine($"Titulo: {graduado1.Titulo}");
        }
    }
}
