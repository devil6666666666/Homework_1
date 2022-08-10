// Все чётные числа от 1 до N

Console.WriteLine("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
if(N>0)
{
    while(a<=N)
{
    if(a%2==0)
    {
        Console.Write(a);
        Console.Write(", ");
    }
    a=a+1;
}
}
if(N<0)
{
    while(a>=N)
{
    if(a%2==0)
    {
        Console.Write(a);
        Console.Write(", ");
    }
    a=a-1;
}
}
if(N==0)
{
    Console.Write(N);
}