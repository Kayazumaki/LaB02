using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("wpisz cztery liczby całkowite-Algorytm: x/y=a/b+c/d");
        int a, b, c, d;

        Console.WriteLine("Liczba a");
        a = (int)inputValue();
        Console.WriteLine("Liczba b");
        b = (int)inputValue();
        Console.WriteLine("Liczba c");
        c = (int)inputValue();
        Console.WriteLine("Liczba d");
        d = (int)inputValue();
        if (b > 0)
        {
            if (d > 0)
            {
            }
            else
            {
                Console.WriteLine("brak rozwiązania");
            }
        }
        else
        {
            Console.WriteLine("brak rozwiązania");
        }
        double wynik;

        wynik = (double)a / b + (double)c / d;
        Console.WriteLine("wynik algorytmu");
        Console.WriteLine(wynik);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
