string[] myStrings = new string[2] 
{ 
    "I like pizza. I like roast chicken. I like salad", 
    "I like all three of the menu choices" 
};

int periodLocation = 0;

foreach (string myString in myStrings)
{
    string currentString = myString;

    periodLocation = currentString.IndexOf(".");

    while (periodLocation != -1)
    {
        // Extrai a frase até o ponto
        string sentence = currentString.Substring(0, periodLocation);

        // Remove espaços no início
        sentence = sentence.TrimStart();

        // Exibe a frase (sem o ponto)
        Console.WriteLine(sentence);

        // Remove a frase já processada + o ponto
        currentString = currentString.Remove(0, periodLocation + 1);

        // Remove espaços restantes no início
        currentString = currentString.TrimStart();

        // Procura o próximo ponto
        periodLocation = currentString.IndexOf(".");
    }

    // Se não houver ponto, exibe o restante da string
    if (currentString.Length > 0)
    {
        Console.WriteLine(currentString.TrimStart());
    }
}
