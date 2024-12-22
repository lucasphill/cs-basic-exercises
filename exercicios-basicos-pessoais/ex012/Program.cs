Console.Write("Digite o preço do produto: ");
double preco = Convert.ToDouble(Console.ReadLine());
double preco_desconto = preco - (preco * 0.05);

string valor_formatado = string.Format("{0:C}", preco_desconto); // ou {0:.00}

Console.WriteLine($"O preço do produto com desconto de 5% é de R{valor_formatado}");

Console.ReadLine();