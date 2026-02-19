double pi = 3.14159;

while (true)
{
    Console.Write("Enter the radius of the circle: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out int radius))
    {
        PrintCircleInfo(radius);
        break; // Exit the loop after processing valid input
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area:N3}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference:N3}");
}



void PrintCircleInfo(int radius) 
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}


