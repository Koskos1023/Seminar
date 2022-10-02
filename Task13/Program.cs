// Программа принимает цифру обозгачающую день недели
// и проверяет, является ли этот день выходным

Console.Write("Введите цифру обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num < 6)
{
    Console.WriteLine($"{num} => нет");
}
else
{
    Console.WriteLine($"{num} => да");
}