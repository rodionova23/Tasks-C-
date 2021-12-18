// // 14. Найти третью цифру числа или сообщить, что её нет

int numb = 179;
if (numb < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
string number = Convert.ToString(numb);
int index = 2;

Console.WriteLine(number[index]);
}