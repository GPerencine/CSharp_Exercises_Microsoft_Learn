Random moeda = new Random();
int resultado = moeda.Next(0, 2); // 1 para Cara, 2 para Coroa
Console.WriteLine(resultado);
Console.WriteLine(resultado == 0 ? "Cara" : "Coroa");