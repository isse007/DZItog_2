// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


int Accerman (int n)
{
    if (n==1)
    {
        return 1;
    }
    return n*Accerman(n-1); 
}

System.Console.WriteLine(Accerman(5));

