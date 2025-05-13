// Arrays Jagged (Serrilhados) - Arrays de arrays
int[][] jaggedArray = new int[3][];

// Inicializando cada array interno com tamanhos diferentes
jaggedArray[0] = new int[2] { 1, 2 };
jaggedArray[1] = new int[3] { 3, 4, 5 };
jaggedArray[2] = new int[1] { 6 };

// Acessando elementos
int valor = jaggedArray[1][2]; // Acessa o elemento 5

// Iterando sobre um array jagged
for (int i = 0; i < jaggedArray.Length; i++)
{
    Console.Write($"Linha {i}: ");
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write($"{jaggedArray[i][j]} ");
    }
    Console.WriteLine();
}