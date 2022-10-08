// напишите программу, которая принимает N и выдает произведение от 1 до N


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int result = DigitMultiplication(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");

}
else Console.WriteLine("Введено некорректное значение");

int DigitMultiplication(int num)
{
    int multiplic = 1;
    for (int i = 1; i <= num ; i++)
    {
        multiplic = multiplic * i;
    }
    return multiplic;
}