using System;

namespace Ex0601_Vetores
{
    class Ex601_A08
    {
        static void MainA08(string[] args)
        {
            double[] notas = new double[7];
            double soma = 0.0;
            int i = 0;

            do
            {
                Console.Write($"Introduza a nota {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                soma += notas[i];
                i++;
            } while (i < notas.Length);

            Console.WriteLine("\nNotas introduzidas:");
            i = 0;
            do
            {
                Console.WriteLine($"Nota {i + 1}: {notas[i]:F2}");
                i++;
            } while (i < notas.Length);

            double media = soma / notas.Length;
            Console.WriteLine($"\nMédia das notas: {media:F2}");
            Console.Write("Prima qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
