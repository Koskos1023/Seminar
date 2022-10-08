// Принимает А и выдает сумму чисел от 1 до А

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sumResult = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumResult}");
int SumNumbers (int num)
{
    int sum = default;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}