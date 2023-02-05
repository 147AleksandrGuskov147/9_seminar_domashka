// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

void PrintNumbers(int count)
{
    if (count > N)
    {
        return;
    }
    PrintNumbers(count + 1);  // метод обращается сам к себе
    Console.Write(count + " ");
}

PrintNumbers(count);