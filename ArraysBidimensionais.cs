// Declaração de array bidimensional
int[,] matriz = new int[3, 2]; // 3 linhas, 2 colunas

// Inicialização com valores
int[,] matriz2 = {
    { 1, 2 },
    { 3, 4 },
    { 5, 6 }
};

// Acessando elementos
int elemento = matriz2[1, 0]; // Acessa linha 1, coluna 0 (valor 3)
matriz2[2, 1] = 7; // Modifica o elemento na linha 2, coluna 1 para 7

// Obtendo dimensões
int linhas = matriz2.GetLength(0); // 3
int colunas = matriz2.GetLength(1); // 2

// Iterando sobre todos os elementos
for (int i = 0; i < linhas; i++)
{
    for (int j = 0; j < colunas; j++)
    {
        Console.Write($"{matriz2[i, j]} ");
    }
    Console.WriteLine(); // Nova linha após cada linha da matriz
}