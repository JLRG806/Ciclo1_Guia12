using System;

namespace Ejercicio_1
{
    class Program
    {
        struct programa
        {                
            public String Universidad;
            public String Carrera;
        }
        struct Estudiante
        {
            public String nombre;
            public int edad;
            public programa Estudios;
        }

        static void Main(string[] args)
        {
            int maxE;
            Console.Title = "Ejemplo de estructuras anidadas";
            Estudiante student = new Estudiante();
            Console.Write("Digite la cantidad de estudiantes a Ingresar:");
            maxE = int.Parse(Console.ReadLine());

            Estudiante[] estudiantes = new Estudiante[maxE];
            //Entrada de datos
            int l = 1;
            for (int i = 0; i < maxE; i++)
            {
                int h = i + 1;
                Console.Write("\nEstudiante #" + h);
                Console.Write("\nIngrese Nombre:");
                estudiantes[i].nombre = Console.ReadLine();
                Console.Write("\nEdad:");
                estudiantes[i].edad = int.Parse(Console.ReadLine());
                Console.Write("\nCarrera:");
                //miembros de otra estructura
                estudiantes[i].Estudios.Carrera = Console.ReadLine();                
                Console.Write("\nUniversidad:");
                estudiantes[i].Estudios.Universidad = Console.ReadLine();
                Console.Clear();

                
                
                

                
            }
            Console.WriteLine("\nMostrando datos:");
            Console.Write("\n///////////////////////////////////");

            for (int i = 0; i < estudiantes.Length; i++)
            {
                int h = i + 1;                
                
                Console.Write("\nEstudiante #" + h);
                Console.WriteLine("\nEstudiante: " + estudiantes[i].nombre);
                Console.WriteLine("\nEdad: " + estudiantes[i].edad);
                Console.WriteLine("\nCarrera: " + estudiantes[i].Estudios.Carrera);
                Console.WriteLine("\nUniversidad: " + estudiantes[i].Estudios.Universidad);
                Console.Write("\n///////////////////////////////////");
            }
            Console.ReadKey();

        }
    }
}
