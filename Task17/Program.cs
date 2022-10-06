// напишите программу на вход координаты и выдает номер четверти плоскости


Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xC = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yC = Convert.ToInt32(Console.ReadLine());
int quarter = Quarter(xC, yC);
Console.Write(quarter == 0 ? "ВВедены некорректные координаты" : quarter);


int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 1;
    if (x < 0 && y < 0) return 1;
    if (x > 0 && y < 0) return 1;
    return 0;
}
