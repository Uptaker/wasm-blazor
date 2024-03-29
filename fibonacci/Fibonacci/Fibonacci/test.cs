using System;
using System.Diagnostics;

class TestClass
{
    static void Main(string[] args)
    {
    var stopwatch = new Stopwatch();
    stopwatch.Start();
    ulong result = Fibonacci(1000000);
    stopwatch.Stop();
    Console.WriteLine(result);
    Console.WriteLine("C# ended in " + stopwatch.ElapsedMilliseconds + " ms");
    }

    public static ulong Fibonacci(int n)
    {
        if (n <= 0)
        return 0u;

        if (n == 1)
        return 1u;

        ulong prev1 = 1u;
        ulong prev2 = 0u;
        ulong result = 0u;

        for (int i = 2; i <= n; i++)
        {
        result = prev1 + prev2;
        prev2 = prev1;
        prev1 = result;
        }

        return result;
    }
}