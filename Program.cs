using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizde3x4imprimirfilasycolmn
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz = new int[3, 4];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($"Ingrese el valor asignado.  {f} {c}:");
                    matriz[f, c] = int.Parse(Console.ReadLine());
                }


                Console.WriteLine("\n" + "\t\tMATRIZ COMPLETA" + "\n");
            }
            Console.WriteLine("Esta es la primera fila: " + matriz[0, 0] + " " + matriz[0, 1] + " " + matriz[0, 2] + " " + matriz[0, 3] + "\n");
            Console.WriteLine("Esta es la ultima fila: " + matriz[2, 0] + " " + matriz[2, 1] + " " + matriz[2, 2] + " " + matriz[2, 3] + "\n");
            Console.WriteLine("Esta es la primera columna: " + matriz[0, 0] + " " + matriz[1, 0] + " " + matriz[2, 0] + "\n");

            for (int f = 0; f < 3; f++)

            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("\t" + matriz[f, c] + "\t");

                }
                Console.WriteLine("");

            }

            Console.ReadKey();

        }
    }
}
