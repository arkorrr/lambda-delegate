using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Task3456
{
    //Task3
    public bool ContainsWord(string text, string word)
    {
        return text.Contains(word);
    }
    //Task4
    public int CountMultiplesOfSeven(int[] numbers)
    {
        return numbers.Count(n => n % 7 == 0);
    }
    //Task5
    public int CountPositiveNumbers(int[] numbers)
    {
        return numbers.Count(n => n > 0);
    }
    //Task6
    public int[] UniqueNegativeNumbers(int[] numbers)
    {
        return numbers.Where(n => n < 0).Distinct().ToArray();
    }
}