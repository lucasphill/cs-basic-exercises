string texto;

Console.Write("Digite algo: ");
texto = Console.ReadLine()!;

Console.WriteLine("Texto em maíusculas: " + texto.ToLower());
Console.WriteLine("Texto em minúsculas: " + texto.ToUpper());
Console.WriteLine("O tipo é: " + texto.GetType()); //Foi declarado anteriormente como string e aqui se trata de uma linguagem fortemente tipada
Console.WriteLine("Está normalizada: " + texto.IsNormalized());
Console.WriteLine("Tocando as letras A por E: " + texto.Replace('A', 'E').Replace('a', 'e'));


Console.ReadLine();