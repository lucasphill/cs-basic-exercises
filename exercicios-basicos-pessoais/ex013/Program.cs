Console.Write("Digite o valor do salário do funcionário: ");
double salario = Convert.ToDouble(Console.ReadLine());

string salario_formatado = string.Format("{0:.00}", salario + (salario * 0.15)); // removendo as casas decimais excedentes sem arredondamento

Console.WriteLine($"O valor do salário do funcionário com aumento de 15% é de R${salario_formatado}");

Console.ReadLine();