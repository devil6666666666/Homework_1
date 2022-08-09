//Нахождение большего числа из двух

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
}
else if (a == b)
{
    Console.WriteLine("Числа равны");
}
else if (b > a)
{
    Console.Write("max = ");
    Console.WriteLine(b);
}
