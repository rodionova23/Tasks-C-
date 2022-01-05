//Дано число. Проверить кратно ли оно 7 и 23

int a = 161;
bool del7 = a % 7 == 0;
bool del23 = a % 23 == 0;

if (del7 && del23)
{
    Console.WriteLine("Число кратно 7 и 23");
    
}
else
{
    Console.WriteLine("Число не кратно 7 и 23");
}