// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4->24 5->120

Console.WriteLine("Введите число: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int N);
int multiplicationOfNumber = getMultiplicationOfNumber(N);
Console.WriteLine(multiplicationOfNumber);


if (!isParsedN || N < 1)
{
    Console.WriteLine("incorrect value");
    return;
}

int getMultiplicationOfNumber(int N)
{
    int result = 1;
    for (int i = 1; i <= N; i++)
    {
        result = result * i;
    }
    return result;
}
