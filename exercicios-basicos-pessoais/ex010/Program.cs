double carteira;
double cotacao_dolar = 6.24;
double cotacao_euro = 6.50;

Console.Write("Digite quantos R$ tem na carteira: ");
carteira = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"O valor de {carteira} reais em dolar é: ${carteira / cotacao_dolar} na cotação de {cotacao_dolar}");
Console.WriteLine($"O valor de {carteira} reais em euro é: €{carteira / cotacao_euro} na cotacao de {cotacao_euro}");

Console.ReadLine();