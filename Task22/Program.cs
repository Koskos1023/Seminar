// принимает N и выдает таблицу квадратов от 1 до N

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void SquareTable(int number)
{
    int counter = 1;
    while (counter <= number)
    {
        Console.WriteLine($"{counter} {counter * counter}");
        counter++;
    }
}
if (num > 0) SquareTable(num);
else Console.WriteLine("Введено некорректное значение ");
