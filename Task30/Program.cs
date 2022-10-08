// Выводит массив из 8 элементов заполненных 0 и 1 в рандоме

int[] array = new int[8];
GetArray(array);
PrintArray(array);

void GetArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(0, 2);    
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}