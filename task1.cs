using System;

class Program
{
    static void Main()
    {
        int M = 1;
        int N = 5;
        PrintNumbers(M, N);
    }

    static void PrintNumbers(int M, int N)
    {
        if (M > N)
        {
            return;
        }
        Console.WriteLine(M);
        PrintNumbers(M + 1, N);
    }
}