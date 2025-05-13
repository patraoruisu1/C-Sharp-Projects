// Criando uma List<T>
List<string> nomes = new List<string>();

// Adicionando elementos
nomes.Add("Ana");
nomes.Add("Carlos");
nomes.Add("Maria");

// Inicialização com valores
List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

// Acessando elementos
string primeiroNome = nomes[0]; // Ana

// Modificando elementos
nomes[1] = "Roberto";

// Verificando se contém um elemento
bool contemMaria = nomes.Contains("Maria"); // true

// Encontrando o índice de um elemento
int indice = nomes.IndexOf("Maria"); // 2

// Removendo elementos
nomes.Remove("Maria");
nomes.RemoveAt(0); // Remove o primeiro elemento

// Inserindo em posição específica
nomes.Insert(0, "Pedro"); // Insere no início

// Iterando sobre a lista
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

// Métodos úteis
numeros.Sort(); // Ordena a lista
numeros.Reverse(); // Inverte a ordem
int total = numeros.Count; // Número de elementos
numeros.Clear(); // Remove todos os elementos