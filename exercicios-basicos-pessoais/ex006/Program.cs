double numero;

Console.Write("Digite um numero para mostrar sua raiz quadrada: ");
numero = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"A raiz quadrada de {numero} é: " + Math.Sqrt(numero));

Console.ReadLine();