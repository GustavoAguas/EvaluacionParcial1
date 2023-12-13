using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionParcial1.Ejercicios
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Calificacion { get; set; }



        // Ampliando la clase
        public void MostrarInformacion()
        {
            Console.WriteLine("Detalles del Estudiante\n");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Calificación: {Calificacion}");
        }
    }

    internal class Ejercicio3
    {
        public static void EjecutarEjercicio3()
        {
            Estudiante estudiante1 = new Estudiante
            {
                Nombre = "Gustavo",
                Edad = 21,
                Calificacion = 9.5
            };
            Console.WriteLine("Informacion del Estudiante\n");
            Console.WriteLine($"Nombre: {estudiante1.Nombre}");
            Console.WriteLine($"Edad: {estudiante1.Edad}");
            Console.WriteLine($"Calificación: {estudiante1.Calificacion}");
        }
    }
}
