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
                Titulo = "Ingeniero En Software"
            };

            Console.WriteLine("Informacion del Estudiante Graduado\n");
            graduado1.MostrarInformacion();
            Console.WriteLine($"Titulo: {graduado1.Titulo}");
        }
    }
}
