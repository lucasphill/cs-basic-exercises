int numero;

Console.Write("Digite um número inteiro para mostrar a tabuada: ");
numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("O numero digitado é: " + numero);
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero} * {i} = {numero * i}");
}


Console.ReadLine();