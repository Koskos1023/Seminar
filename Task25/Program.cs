//  цикл Принимает 2 числа А и В и возводит А в степень В

Console.WriteLine("введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int degree = A;

for (int i = 1; i < B; i++)
{
degree = degree * A;
}
Console.WriteLine($"{A} в степени {B} = {degree}" );
