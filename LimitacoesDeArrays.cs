// Exemplo de limitações de array
int[] numeros = new int[3] { 1, 2, 3 };

// Para adicionar um elemento, precisamos criar um novo array
int[] novoArray = new int[4];
Array.Copy(numeros, novoArray, 3);
novoArray[3] = 4;

// Agora numeros aponta para o novo array
numeros = novoArray;

// Com coleções genéricas, é mais simples
List<int> listaNumeros = new List<int> { 1, 2, 3 };
listaNumeros.Add(4); // Adiciona sem precisar recriar a lista