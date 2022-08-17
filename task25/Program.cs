Console.Clear();
Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int B = Convert.ToInt32(Console.ReadLine());
int S =1;
for (int i=1; i<= B; i++)
{
    S = S*A;
}
Console.WriteLine($"А в степени В равно: {S}");