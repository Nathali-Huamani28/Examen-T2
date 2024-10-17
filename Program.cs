using System;
using System.Collections.Generic;


namespace Colegio
{
    public class Salon
    {
        public Entrenador Entrenador { get; set; }
        public List Estudiantes { get; set; }

        public Salon()
        {
            Estudiantes = new List<estudiante>();
        }

        
        public void PasarAsistencia()
        {
            Console.WriteLine("Entrenador: " + Entrenador.Nombre);
            for (int i = 0; i < Estudiantes.Count; i++)
            {
                Console.WriteLine("Estudiante: " + Estudiantes().Nombre);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Salon salon = new Salon();

            
            for (int i = 0; i < 3; i++)
            {
                estudiante estudiante = new estudiante();

                Console.WriteLine("Ingrese nombre del estudiante " + (i + 1) + ":");
                estudiante.Nombre = Console.ReadLine();

                salon.Estudiantes.Add(estudiante);
            }

            
            salon.Entrenador = new Entrenador();
            Console.WriteLine("Ingrese nombre del entrenador:");
            salon.Entrenador.Nombre = Console.ReadLine();

           
            salon.PasarAsistencia();

            
            salon.Estudiantes(0).Estudia();
            salon.Entrenador.HaceEjercicio();

            Console.WriteLine("Fin del programa");
        }
    }
}