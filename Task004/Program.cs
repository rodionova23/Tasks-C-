//  4. Найти максимальное из трех чисел

int [] array = {105,5,25};
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
