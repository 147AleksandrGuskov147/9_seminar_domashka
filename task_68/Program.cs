// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
FuncAkker(M,N);

int Akker(int M, int N)
{
    if (M == 0) 
    {
        return N + 1;
    }

    else if (M > 0 && N == 0)
    {
        return Akker(M - 1, 1);
    }
    
    else // (M > 0 && N > 0) - не понял как ограничить значения с "-" ???
    {
        return Akker(M - 1, Akker(M, N - 1));
    }
}
void FuncAkker(int M, int N)
{
    Console.Write($"Значение функции Аккермана для {M} и {N} = {Akker(M, N)}"); 
}