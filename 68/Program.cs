int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    else return Ackerman(m - 1, Ackerman(m, n - 1));
}

Console.WriteLine("Введите значение m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение n");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0) Console.WriteLine("Значения должны быть положительными");
else Console.WriteLine(Ackerman(m, n));