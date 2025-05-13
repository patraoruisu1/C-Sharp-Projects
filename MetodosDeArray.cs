// Métodos úteis para trabalhar com arrays
int[] numeros = { 5, 3, 8, 1, 7, 2 };

// Ordenando o array
Array.Sort(numeros); // numeros agora é { 1, 2, 3, 5, 7, 8 }

// Invertendo a ordem
Array.Reverse(numeros); // numeros agora é { 8, 7, 5, 3, 2, 1 }

// Encontrando índices
int indice = Array.IndexOf(numeros, 7); // retorna 1

// Verificando se um elemento existe
bool existe = Array.Exists(numeros, x => x > 5); // retorna true

// Encontrando elementos
int valor = Array.Find(numeros, x => x % 2 == 0); // retorna 8 (primeiro par)
int[] pares = Array.FindAll(numeros, x => x % 2 == 0); // retorna { 8, 2 }