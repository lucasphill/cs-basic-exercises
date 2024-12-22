Console.Write("Digite quantos dias o carro ficou alugado: ");
int dias = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite KM foram rodados: ");
int km = int.Parse(Console.ReadLine()!);

Console.WriteLine($"O carro alugado por {dias} custará R${(dias*60) + (km*0.15)}");

Console.ReadLine();