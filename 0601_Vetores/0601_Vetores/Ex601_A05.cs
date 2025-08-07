using System;

namespace Ex0601_Vetores
{
    class Ex601_A05
    {
        static void MainA05(string[] args)
        {
            string[] dias = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo" };
            int[] vendas = new int[7];
            int soma = 0;

            // Leitura do ciclo for
            for (int i = 0; i < vendas.Length; i++)
            {
                Console.Write($"Quantas caixas vendeu na {dias[i]}? ");
                vendas[i] = Convert.ToInt32(Console.ReadLine());
                soma += vendas[i];
            }

            // Lista de vendas
            Console.WriteLine("\n-> Lista de vendas");
            for (int i = 0; i < vendas.Length; i++)
            {
                Console.WriteLine($"Vendas na {dias[i]}: {vendas[i]}.");
            }
            Console.WriteLine($"\nTotal de vendas: {soma}.");

            Console.Write("Quanto custou cada caixa? ");
            float custoCaixa = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"\nValor total de vendas: {custoCaixa * soma,7:F2} euros!\n");
            Console.Write("Prima qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
