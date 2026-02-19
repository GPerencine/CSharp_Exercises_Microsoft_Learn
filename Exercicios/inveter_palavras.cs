string pangram = "The quick brown fox jumps over the lazy dog";
Console.WriteLine(pangram);
string[] palavras = pangram.Split(' ');
foreach (string palavra in palavras){
    char[] caracteres = palavra.ToCharArray();
    Array.Reverse(caracteres);
    string palavraInvertida = new string(caracteres);
    Console.Write(palavraInvertida + " ");
}

Console.WriteLine("\n");
string input = "there are snakes at the zoo";
Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input) 
{
    string result = "";
    string[] words = input.Split(" ");
    foreach(string word in words) 
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}

string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}