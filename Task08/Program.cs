// Напишите программу, которая принимает число N , а на выходе выдаёт все четные чмсла от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int counter = 1;
int n = number;

while (counter <= n)
{
    if (counter % 2 == 0)
    {
        Console.Write($"{counter}");
    }
    counter++;
}

