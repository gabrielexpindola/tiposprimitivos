
// Exercício 1

Console.Write("Digite o nome do produto: ");
string nomeProduto = Console.ReadLine();

Console.Write("Digite a quantidade comprada: ");
int quantidade = int.Parse(Console.ReadLine());

Console.Write("Digite o preço unitário: R$ ");
decimal precoUnitario = decimal.Parse(Console.ReadLine());

decimal valorTotal = quantidade * precoUnitario;

Console.WriteLine("\n--- RESUMO DA COMPRA ---");
Console.WriteLine($"Produto: {nomeProduto}");
Console.WriteLine($"Quantidade: {quantidade}");
Console.WriteLine($"Preço unitário: R$ {precoUnitario:F2}");
Console.WriteLine($"Valor total: R$ {valorTotal:F2}");

// Exercício 2
Console.Write("Digite o nome do Aluno: ");
string nomeAluno = Console.ReadLine();

Console.Write("Digite sua nota de 0 a 10: ");
decimal nota = decimal.Parse(Console.ReadLine());

switch (nota)
{
    case >= 7 and <= 10:
        Console.WriteLine("Aprovado.");
        break;
    case >= 5 and < 7:
        Console.WriteLine("Recuperação.");
        break;
    case < 5:
        Console.WriteLine("Reprovado.");
        break;
    case < 0 or > 10:
        Console.WriteLine("Nota inválida.");
        break;
}

// Exercício 3
int numeroSecreto = 77;
int quantidadeTentativas = 0;

while (true)
{
    Console.Write("Digite um número entre 0 e 100: ");
    int palpite = int.Parse(Console.ReadLine());

    if (palpite < 0 || palpite > 100)
    {
        Console.WriteLine("Número inválido. Tente novamente.");
        continue;
    }

    if (palpite == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número secreto!");
        Console.WriteLine($"Quantidade de tentativas: {quantidadeTentativas}");
        break;
    }
    else if (palpite < numeroSecreto)
    {
        Console.WriteLine("O número secreto é maior. Tente novamente.");
        quantidadeTentativas++;
    }
    else
    {
        Console.WriteLine("O número secreto é menor. Tente novamente.");
        quantidadeTentativas++;
    }
}

// Exercício 4

static double somar(double num1, double num2)
{
    return num1 + num2;
}

static double multiplicar(double num1, double num2)
{
    return num1 * num2;
}

static void Main()
{
    Console.Write("Digite o primeiro número: ");
    double numero1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    double numero2 = double.Parse(Console.ReadLine());

    double resultadoSoma = somar(numero1, numero2);
    double resultadoMultiplicacao = multiplicar(numero1, numero2);

    Console.WriteLine("\nRESULTADOS");
    Console.WriteLine($"Soma: {resultadoSoma}");
    Console.WriteLine($"Multiplicação: {resultadoMultiplicacao}");
}

// Exercício 5
int[] notas = new int[3];
Console.WriteLine("Digite as 3 notas do aluno:");
notas[0] = int.Parse(Console.ReadLine());
notas[1] = int.Parse(Console.ReadLine());
notas[2] = int.Parse(Console.ReadLine());

Console.WriteLine("\nNotas do aluno:");
for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Nota {i + 1}: {notas[i]}");
}

int soma = 0;
foreach (int n in notas)
{
    soma += n;
}
double media = (double)soma / notas.Length;
Console.WriteLine($"Média das notas: {media:F2}");

// Exercício 6
List<string> produtos = new List<string>();
Console.WriteLine("Digite 3 produtos para cadastrar:");
produtos.Add(Console.ReadLine());
produtos.Add(Console.ReadLine());
produtos.Add(Console.ReadLine());

Console.WriteLine("\nProdutos cadastrados:");
foreach (string produto in produtos)
{
    Console.WriteLine(produto);
}

Console.WriteLine("\nDigite um produto para pesquisar:");
string pesquisa = Console.ReadLine();

if (produtos.Contains(pesquisa))
{
    Console.WriteLine("O produto pesquisado está na lista.");
}
else
{
    Console.WriteLine("O produto pesquisado não está na lista.");
}



Console.WriteLine("\nDigite um produto para remover:");
string remover = Console.ReadLine();

if (produtos.Remove(remover))
{
    Console.WriteLine("Produto removido com sucesso.");
}
else
{
    Console.WriteLine("Produto não encontrado.");
}



Console.WriteLine("\nLista atualizada de produtos cadastrados:");

foreach (string produto in produtos)
{
    Console.WriteLine(produto);
}