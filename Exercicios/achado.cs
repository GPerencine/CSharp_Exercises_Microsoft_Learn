int[] numbers = { 4, 8, 15, 16, 23, 42 };
bool found = false;
int total = 0;
foreach (int number in numbers)
{
    total += number;

    if (number == 23)
    {
       found = true;
        break;
    }
}

if (found) 
{
    Console.WriteLine("Set contains 23");
}

Console.WriteLine($"Total: {total}");