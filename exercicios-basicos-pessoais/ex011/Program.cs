double altura;
double largura;
double area;

Console.Write("Digite a altura da parede: ");
altura = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a largura da parede: ");
largura = Convert.ToDouble(Console.ReadLine());

//1l de tinta atende 2m
area = largura * altura;

Console.WriteLine($"A área da parede é de {area}m e para pintar essa parede será necessário {area / 2} litros de tinta.");

Console.ReadLine();