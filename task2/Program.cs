Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 3: ");
int c = int.Parse(Console.ReadLine()!);


if (a>b)
{  
    if (a>c)
    {
    Console.WriteLine(a);
    }   
    else
{
    Console.WriteLine(c); 
}
}
    else
{
if (b>c)
    {
    Console.WriteLine(b);    
    }
else
{
    Console.WriteLine(c);
}
}
     



