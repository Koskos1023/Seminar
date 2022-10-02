// Напишите задачу, которая принимает на вход число и проверяет кратно ли оно 7 и 23 одновременно

Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number %23 == 0) Console.WriteLine ($"{number}, кратно");
else Console.WriteLine ($"{number}, не кратно");
