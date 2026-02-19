string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a number between 5 and 10:");
do
{
    readResult = Console.ReadLine();
    if (int.TryParse(readResult, out int number))
    {
        if (number >= 5 && number <= 10)
        {
            validEntry = true;
        }
        else if (number < 5 || number > 10)
        {
            Console.WriteLine($"Your input {number} is invalid, please enter a number between 5 and 10.");
        }
        
    }
    else
    {
        Console.WriteLine($"Your input {readResult} is a invalid number.");
    }
} while (validEntry == false);