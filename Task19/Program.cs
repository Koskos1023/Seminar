// является ли палиндромом 5 значное число

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int length = number.Length;

if (length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - > Да");
    }
    else
    {
        Console.WriteLine($"{number} - > Нет");
    }
}
else
{
    Console.WriteLine($" Введите пятизначное число");
}
