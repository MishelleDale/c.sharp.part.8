// Функция Аккермана с помощью рекурсии

Console.WriteLine("Введите первое неотрицательное число М");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число N");
int N = Convert.ToInt32(Console.ReadLine());

int result = Akkerman (N, M);

int Akkerman (int n, int m)
{
    if (n == 0)
    {
        return m+1;
    }
    
    if (m == 0 && n > 0 )
    {
        return Akkerman (n - 1, 1);
    }
    return Akkerman (n - 1, Akkerman (n, m -1));
}

Console.WriteLine(result);