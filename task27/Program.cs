Console.Clear();
Console.WriteLine("Введите число");
int N =Convert.ToInt32(Console.ReadLine());
int sum =0;
while (N>0)
{
    int P = N % 10;
    N = N/10;
    sum = sum + P;

}
Console.WriteLine($"Сумма цифр в числе: {sum} ");