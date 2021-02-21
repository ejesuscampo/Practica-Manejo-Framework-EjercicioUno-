using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_Promedio__EjercicioUno_
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaUno = 0;
            double notaDos = 0;
            double notaTres = 0;
            double promedio = 0;

            Console.WriteLine("CAPTURA DE NOTAS Y CALCULO DE PROMEDIO DE ASIGNATURA");     Console.WriteLine("");

            //Captura de notas
            Console.Write("Digite la nota del 1er corte: ");
            notaUno = double.Parse(Console.ReadLine());
            Console.Write("Digite la nota del 2do corte: ");
            notaDos = double.Parse(Console.ReadLine());
            Console.Write("Digite la nota del 3er corte: ");
            notaTres = double.Parse(Console.ReadLine());

            //Calcula el promedio de la asignatura
            promedio = (notaUno * 0.3) + (notaDos * 0.3) + (notaTres * 0.4);

            Console.WriteLine($"El promedio de la asignatura es: {promedio}");      Console.WriteLine("");

            //Determinar si ganó o perdió la materia
            if (promedio >= 3.0)
            {
                Console.WriteLine("El estudiante -GANÓ- la asignatura");
            }
            else
            {
                Console.WriteLine("El estudiante -PERDIÓ- la asignatura");
            }

            Console.ReadKey();
        }
    }
}
