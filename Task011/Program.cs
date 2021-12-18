// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int n = new Random().Next(10,100);
Console.WriteLine(n);
string num = Convert.ToString(n);
int index = 0;
if(num[index] > num [index++])
{
    Console.WriteLine(num[index]);

}
else
{
    Console.WriteLine(num[index++]);
}