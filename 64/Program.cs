void NaturalNumbers(int num)
{
    if (num == 0) return;
    if (num == 1) Console.Write($"{num}");
    else Console.Write($"{num}, ");
    NaturalNumbers(num - 1);
}


Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0) Console.Write("Число должно быть больше 0");
else NaturalNumbers(number);