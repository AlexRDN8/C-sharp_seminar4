// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5

Console.WriteLine("Введите число");
bool isParsedNum = int.TryParse(Console.ReadLine(), out int Num);
if (!isParsedNum)
{
    Console.WriteLine("Incorrect value");
}

int GetAccountOfFigures (int Num)
{
    int accountOfFigures = (int)Math.Floor(Math.Log10(Num)+1);
    return accountOfFigures;
}

Console.WriteLine(GetAccountOfFigures (Num));