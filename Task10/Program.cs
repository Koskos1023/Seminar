// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int SecondDigit(int num)
{
    int result = ((num / 10) % 10);
    return result;
}
int result = SecondDigit(num);
Console.WriteLine($"Вторая цифра трехзначного числа {num} => {result}");
