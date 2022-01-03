//  1. По двум заданным числам проверять является ли первое квадратом второго

void Square(double a, double b)
{
double z = a/b;
if (z == b)
{
    Console.WriteLine("Первое является квадратом второго");
}
else
{
    Console.WriteLine("Первое не является квадратом второго");
}
}

Square(15, 15);