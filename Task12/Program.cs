// Напишите программу, которая
// принимает 2 числа и выдает является ли второе кратное первому

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool IsAliqot(int arg1, int arg2)
{
    return arg1 % arg2 == 0;
}
if (IsAliqot(num1,num2)) Console.WriteLine ($"{num1} кратно {num2}");
else Console.WriteLine ($"{num1} не кратно {num2} Остаток {num1 % num2}");