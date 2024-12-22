double distancia_metros;

Console.Write("Digite uma distancia em metros: ");
distancia_metros = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Distancia em km: " + (distancia_metros / 1000));
Console.WriteLine("Distancia em hm: " + (distancia_metros / 100));
Console.WriteLine("Distancia em dam: " + (distancia_metros / 10));
Console.WriteLine("Distancia em m: " + (distancia_metros));
Console.WriteLine("Distancia em dm: " + (distancia_metros * 10));
Console.WriteLine("Distancia em cm: " + (distancia_metros * 100));
Console.WriteLine("Distancia em mm: " + (distancia_metros * 1000));

