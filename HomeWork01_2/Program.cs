Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
 
if (a == b & a ==c)
{
        Console.WriteLine("Числа равны"); 
}
else

if (a >= b & a >= c)
{
          Console.WriteLine("Максимальное число " + a);
}
else

          if (b >= a & b >= c)
          {
                    Console.WriteLine("Максимальное число " + b);
          }
    
else
          Console.WriteLine("Максимальное чиcло " + c);
