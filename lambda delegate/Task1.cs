using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Task1
{
    public static int[] GetEvenNumbers(int[] array)
    {
        return array.Where(x => x % 2 == 0).ToArray();
    }

    public static int[] GetOddNumbers(int[] array)
    {
        return array.Where(x => x % 2 != 0).ToArray();
    }

    public static int[] GetPrimeNumbers(int[] array)
    {
        return array.Where(IsPrime).ToArray();
    }

    private static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;
        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    public static int[] GetFibonacciNumbers(int[] array)
    {
        var fibonacciNumbers = new HashSet<int>();
        int a = 0, b = 1;
        while (a <= array.Max())
        {
            fibonacciNumbers.Add(a);
            int temp = a;
            a = b;
            b = temp + b;
        }
        return array.Where(x => fibonacciNumbers.Contains(x)).ToArray();
    }
}