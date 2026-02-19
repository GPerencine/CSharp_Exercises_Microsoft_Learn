Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay())
{
    PlayGame();
}
else
{
    Console.WriteLine("Maybe next time!");
}

bool ShouldPlay() 
{
    while (true)
    {
        string? input = Console.ReadLine();

        if (input != null)
        {
            input = input.Trim().ToLower();

            if (input == "y")
            {
                return true;
            }
                
            if (input == "n")
            {
                Console.WriteLine("See you!");
                return false;
            }
        }

        Console.WriteLine("Invalid input. Please enter Y or N.");
    }
}

string WinOrLose(int roll, int target)
{
   return roll > target ? "You win!" : "You lose!";
}

void PlayGame() 
{
    bool play = true;

    while (play) 
    {
        int target = random.Next(1, 5);
        int roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));

        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}