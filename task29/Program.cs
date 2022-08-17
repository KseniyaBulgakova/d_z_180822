Console.Clear();
Console.WriteLine("Введите число");
int[] array = new int[8];
int i=0;
while (i<8)
{
    array[i]= new Random().Next(0,8);
    Console.Write($"{array[i]}, ");
    i++;
}