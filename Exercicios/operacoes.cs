int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

int first = 7;
int second = 5;
decimal quotiefiente = (decimal)first / (decimal)second;
Console.WriteLine(quotiefiente);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

int valor = 1;
valor++;
Console.WriteLine("First: " + valor);
Console.WriteLine($"Second: {valor++}");
Console.WriteLine("Third: " + valor);
Console.WriteLine("Fourth: " + (++valor));

int fahrenheit = 94;
float celsius = 0.0f;
celsius = (fahrenheit - 32) * 5 / (float)9;

Console.Write($"{celsius:f1}°");