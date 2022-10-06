// Принимает N и выдает таблицу кубов от 1 до N

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void CubeTable(int number)
{
    int counter = 1;
    while (counter <= number)
    {
        Console.WriteLine($"{counter} {counter * counter * counter}");
        counter++;
    }
}
if (num > 0) CubeTable(num);
else Console.WriteLine("Введено некорректное значение ");
