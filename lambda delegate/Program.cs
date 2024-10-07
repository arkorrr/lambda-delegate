
class Program
{
    public static void Main(string[] args)
    {
        //Task1
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 13, 21, 34, 55, 89 };

        int[] evenNumbers = Task1.GetEvenNumbers(array);
        Console.WriteLine("Четные числа: " + string.Join(", ", evenNumbers));

        int[] oddNumbers = Task1.GetOddNumbers(array);
        Console.WriteLine("Нечетные числа: " + string.Join(", ", oddNumbers));

        int[] primeNumbers = Task1.GetPrimeNumbers(array);
        Console.WriteLine("Простые числа: " + string.Join(", ", primeNumbers));

        int[] fibonacciNumbers = Task1.GetFibonacciNumbers(array);
        Console.WriteLine("Числа Фибоначчи: " + string.Join(", ", fibonacciNumbers));
        //Task2
        Task2 task = new Task2();

        task.showCurrentTime();
        task.showCurrentDate();
        task.showCurrentDayOfWeek();

        Console.WriteLine("Triangle Area: " + task.calculateTriangleArea(5, 10));
        Console.WriteLine("Rectangle Area: " + task.calculateRectangleArea(4, 8));
        //Task3
        Task3456 task3456 = new Task3456();
        string[] arr = { "Hello World" };
        Console.WriteLine(task3456.ContainsWord("Hello World", "Hello"));
        //Task4
        Console.WriteLine(task3456.CountMultiplesOfSeven(array));
        //Task5
        Console.WriteLine(task3456.CountPositiveNumbers(array));
        //Task6
        Console.WriteLine(task3456.UniqueNegativeNumbers(array));
    }
}