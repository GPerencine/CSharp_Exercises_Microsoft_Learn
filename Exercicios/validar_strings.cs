string? readResult;
bool validEntry = false;
Console.Write("Enter your role name: (administrator, manager, user) ");
do
{
    readResult = Console.ReadLine();
    string? resposta = readResult?.ToLower().Trim();
    if (resposta == "administrator" || resposta == "manager" || resposta == "user")
    {
        Console.WriteLine($"Welcome, {resposta}!");
        validEntry = true;
    }
    else
    {
        Console.WriteLine($"Your input {readResult} is a invalid.");
    }
} while (validEntry == false);