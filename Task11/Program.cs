// Напишите программу, которая выдает рандомное 3 значное число и удаляет 2 цифру 

int number = new Random().Next(100, 1000);
int RemoveSecondDigit (int num)
{
    int ThirdDigit = num % 10;
    int firstDigit = num / 100;
    return firstDigit * 10 + ThirdDigit;
}
int result = RemoveSecondDigit(number);
Console.WriteLine($"Итоговое число от {number} => {result}");