int numero;

Console.Write("Digite um número para analisar: ");
numero = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"O número digitado é {numero}, seu antecessor é {numero - 1} e seu sucessor é {numero + 1}");

Console.ReadLine();