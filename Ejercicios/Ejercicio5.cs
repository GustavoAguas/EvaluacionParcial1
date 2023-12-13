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
        public new void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Calificación: {Calificacion}");
            Console.WriteLine($"Calificación: {Titulo}");
        }

    }



    internal class Ejercicio5
    {
        public static void EjecutarEjercicio5()
        {

            EstudianteGraduado graduado1 = new EstudianteGraduado
            {
                Nombre = "Gustavo",
                Edad = 21,
                Calificacion = 9.5,
                Titulo = "Ingeniero En Software"
            };

            Console.WriteLine("\nInformacion del Estudiante Graduado\n");
            graduado1.MostrarInformacion();
        }
    }
}
