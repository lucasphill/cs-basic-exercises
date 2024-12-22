double nota_1;
double nota_2;

Console.Write("Digite a primeira nota: ");
nota_1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
nota_2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"A média entre as notas {nota_1} e {nota_2} é: " + ((nota_1 + nota_2) / 2));

Console.ReadLine();