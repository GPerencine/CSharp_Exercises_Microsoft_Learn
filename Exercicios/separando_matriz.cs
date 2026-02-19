string[] values = { "12,3", "45", "ABC", "11", "DEF" };
float soma = 0.0f;
string frase = "";
foreach (string value in values)
{
    if (float.TryParse(value, out float result))
    {
        soma += (float)result;
    }
    else
    {
        frase += value;
    }
    
}
Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Frase: {frase}");