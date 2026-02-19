double usd = 100.0;
int rate = 5;
int RS = UsdToRS(usd, rate);

Console.WriteLine($"{usd:F2} USD = {RS:C} ");
Console.WriteLine($"{RS:C}  = {RSToUsd(RS, rate):F2} USD");

int UsdToRS(double usd, int rate)
{
    return (int)(rate * usd);
}

double RSToUsd(int RS, int rate)
{
    return RS / (double)rate;
}