//задача 66. программа, которая находит сумму натуральных элементов в промежутке от M до N.
//задача 68. программа вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите номер задачи: ");
int task = Convert.ToInt32(Console.ReadLine());

switch(task)
{
    case 1:
        task1();
        break;
    
    case 2:
        task2();
        break;
        
    default:
        break;
}


void task1()
{ 
    Console.WriteLine("Введите два числа: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    
    int RecSumma(int m, int n)
    {
        if (m == n)
        {
            return m;
        }
        else 
        return m + RecSumma(m + 1, n);
    }
    Console.WriteLine(RecSumma(m, n));
}

void task2()
{    
    Console.WriteLine("Введите два неотрицательных числа: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());

    int aker(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return aker(m - 1, 1);
        else return aker(m - 1, aker(m, n - 1));
    }

    Console.WriteLine(aker(m, n));
}