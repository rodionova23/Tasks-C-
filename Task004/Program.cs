//  4. Найти максимальное из трех чисел

void Max3 (int a, int b, int c)
{
int [] array = {a,b,c};
int index = 0;
int max = array [index];
if(array[index+1]>max)
{
    max = array[index+1];
}
if(array[index+2]>max)
{
    max = array[index+2];
}
Console.WriteLine(max);
}

Max3(10, 50 , 60);
