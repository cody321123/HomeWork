Console.Write("Введите число:");
int endNum = Convert.ToInt32(Console.ReadLine());
int num = 1;

while (num < endNum)
{
    num++;
    if (num % 2 == 0) Console.Write(num + " ");
}