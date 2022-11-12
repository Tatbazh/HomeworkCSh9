// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    
        return 1 + FunctionAkkerman(m - 1, n);
    
    // else if (m > 0 && n > 0)
    // {
    //     return ;
    // }
}

Console.Write("Введите целое неотрицательное число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите целое неотрицательное число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write($"Функция Аккермана для {m} и {n} = {FunctionAkkerman(m,n)}");