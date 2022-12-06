// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
Random random = new Random();
Console.WriteLine("Введите число элементов массива ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int N);

if (!isParsedN)
{
    Console.WriteLine("Должно быть введено число");
    return;
}

int [] newArray = FillArray(N);
PrintArray(newArray);

int[] FillArray (int N)
{
    int[] array = new int[N];
    int index = 0;
    while (index < N)
    {
        array[index] = random.Next (0,2);
        index ++; 
    }
    return array;
}

void PrintArray (int [] array)
{
    for (int index = 0; index < array.Length; index ++)
    {
        Console.Write($"{array[index]} ");
    }
}