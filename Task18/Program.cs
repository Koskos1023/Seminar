// Напишите программу которая по заданному номеру четверти показывает диапазон координат

Console.WriteLine("Введите четверть: ");
int quater = Convert.ToInt32(Console.ReadLine());
string result = Quarter(quater);
System.Console.WriteLine(result);

string Quarter (int quart)
{
    if (quart == 1) return "x > 0  y > 0";
    if (quart == 2) return "x < 0  y > 0";
    if (quart == 3) return "x < 0 y  < 0";
    if (quart == 4) return "x > 0  y < 0";
    return "Введите корректное число";
}