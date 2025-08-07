using System;

namespace Ex0601_Vetores
{
    class Ex601_A06
    {
        static void MainA06(string[] args)
        {
            double[] notas = new double[7];
            double soma = 0.0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Introduza a nota {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                soma += notas[i];
            }

            Console.WriteLine("\nNotas introduzidas:");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Nota {i + 1}: {notas[i]:F2}");
            }

            double media = soma / notas.Length;
            Console.WriteLine($"\nMédia das notas: {media:F2}");

            Console.Write("Prima qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
