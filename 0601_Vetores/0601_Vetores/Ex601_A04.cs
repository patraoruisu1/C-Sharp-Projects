//***********************************************************************
//* Conjuntos de valores inteiros
//***********************************************************************
//* Conteúdos: "Array" de números inteiros em C/C++. 
//***********************************************************************
//* Enunciado: faça um programa que recebe sete valores de 
//* caixas vendidas durante os vários dias da semana e apresenta os 
//* valores inseridos, o total de vendas da semana e o valor 
//* das vendas em euros. 
//***********************************************************************
//* Entrada(s): sete valores das vendas, preço de uma caixa. 
//* Saida(s): total de vendas e valor de vendas. 
//***********************************************************************
using System;

namespace Ex0601_Vetores
{
    class Ex601_A04
    {
        static void Main1(string[] args)
        {
            // 1. Declaração e a inicialização das variáveis
            int[] vendas = new int[7]; // O "Array" de sete valores
            float custoCaixa = 0;
            int soma = 0;

            vendas[0] = 0; vendas[1] = 0; vendas[2] = 0;
            vendas[3] = 0; vendas[4] = 0; vendas[5] = 0; vendas[6] = 0;

            // 2. Obter as vendas para os dias da semana
            Console.Write("Quantas caixas vendeu na Segunda? ");
            vendas[0] = Convert.ToInt16(Console.ReadLine());

            Console.Write("Quantas caixas vendeu na Terça? ");
            vendas[1] = Convert.ToInt16(Console.ReadLine());

            Console.Write("Quantas caixas vendeu na Quarta? ");
            vendas[2] = Convert.ToInt16(Console.ReadLine());

            Console.Write("Quantas caixas vendeu na Quinta? ");
            vendas[3] = Convert.ToInt16(Console.ReadLine());

            Console.Write("Quantas caixas vendeu na Sexta? ");
            vendas[4] = Convert.ToInt16(Console.ReadLine());

            Console.Write("Quantas caixas vendeu no Sábado? ");
            vendas[5] = Convert.ToInt16(Console.ReadLine());

            Console.Write("Quantas caixas vendeu no Domingo? ");
            vendas[6] = Convert.ToInt16(Console.ReadLine());

            // 3. Apresenta os valores lidos
            Console.WriteLine("\n->Lista de vendas \n");
            Console.WriteLine("Vendas na Segunda: {0}.", vendas[0]);
            Console.WriteLine("Vendas na Terça: {0}.", vendas[1]);
            Console.WriteLine("Vendas na Quarta: {0}.", vendas[2]);
            Console.WriteLine("Vendas na Quinta: {0}.", vendas[3]);
            Console.WriteLine("Vendas na Sexta: {0}.", vendas[4]);
            Console.WriteLine("Vendas no Sábado: {0}.", vendas[5]);
            Console.WriteLine("Vendas no Domingo: {0}.", vendas[6]);

            // 4. Apresenta o valor das vendas das caixas
            soma = vendas[0] + vendas[1] + vendas[2] + vendas[3] +
                       vendas[4] + vendas[5] + vendas[6];
            Console.WriteLine("\nTotal de vendas: {0}. \n\n", soma);

            // 5. Pede o valor do custo de cada caixa
            Console.Write("Quanto custa cada caixa? ");
            custoCaixa = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\n\n");

            // 6. O display
            Console.WriteLine("Valor total de vendas: {0,7:F2} euros!\n", custoCaixa * soma);

            Console.WriteLine();
            Console.Write("Prima qualquer tecla para continuar...");
            Console.ReadKey();  // Wait for any key press
        } // fim do Main1()
    } // fim da classe
} // fim do namespace
