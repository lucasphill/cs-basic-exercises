Console.Write("Digite uma temperatura em ºC: ");
double temp = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"A temperatura em ºF é: {(temp*1.8)+32}");
Console.WriteLine($"A temperatura em ºK é: {temp + 273.15}");

Console.ReadLine();