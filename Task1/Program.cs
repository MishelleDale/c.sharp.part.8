// 64. Find the sum of elements between M and N

Console.WriteLine("Введите первое число М");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число N");
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0; // Переменная для подсчета суммы

int Sum (int Start, int Finish)
{
    if (Start < Finish)
    {
        if (Start < Finish)
        {
            sum = sum + Start;
            Sum (Start+1, Finish);
            
        }
    }
        else
        {
            if (Start > Finish)
        {
            sum = sum + Finish;
            Sum (Start, Finish + 1);
        }
    }
    return sum;
    
}

Sum (M, N);
Console.WriteLine($"Сумма чисел от M до N равна {sum+N}"); // sum + N - итоговая сумма всех элементов, без + N, последнее число не считает
