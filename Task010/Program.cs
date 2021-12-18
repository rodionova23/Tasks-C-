// 10. Показать вторую цифру трёхзначного числа

int n = 864;
Console.WriteLine(Num2(n));
int Num2(int n)
{
  int a = n / 100;
  int s = n - a * 100;
  int b = s / 10;
  return b;
}