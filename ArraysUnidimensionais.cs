// Declaração de array
int[] numeros = new int[5]; // Array de 5 inteiros

// Inicialização com valores
int[] valores = new int[] { 10, 20, 30, 40, 50 };
// Forma simplificada
int[] valores2 = { 10, 20, 30, 40, 50 };

// Acessando elementos do array
int primeiro = valores[0]; // Acessa o primeiro elemento (10)
valores[2] = 35; // Modifica o terceiro elemento para 35

// Iterando sobre um array
for (int i = 0; i < valores.Length; i++)
{
    Console.WriteLine($"valores[{i}] = {valores[i]}");
}

// Usando foreach
foreach (int valor in valores)
{
    Console.WriteLine(valor);
}