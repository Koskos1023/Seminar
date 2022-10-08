// принимает на вход число и выдаёт количество цифр в числе
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int QuantityNumbers(int num)
{
    int counter = 0;
    while (num > 0)
    {
        num = num / 10;
        counter++;
    }
    return counter;

}
int res = QuantityNumbers(Math.Abs(number));
Console.WriteLine(res);
