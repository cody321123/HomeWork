int a, b;

Console.WriteLine("Введите 2 числа");

a = Convert.ToInt32(Console.ReadLine());

b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
          Console.WriteLine("Наибольшее число " + a);
}
else
{
          Console.WriteLine("наибольшее число " + b);
}