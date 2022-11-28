int NaturalNumbers(int begin, int end)
{
    if (end == begin) return begin;
    return end + NaturalNumbers(begin, end - 1);
}


Console.WriteLine("Введите стартовое значение:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение:");
int n = Convert.ToInt32(Console.ReadLine());

if (m >= n) Console.Write("Конченое значение должно быть больше стартового");
else Console.WriteLine(NaturalNumbers(m, n));