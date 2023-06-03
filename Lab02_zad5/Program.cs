using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y;

        Console.WriteLine("wpisz 2 liczby rzeczywiste");
        Console.WriteLine("wpisz 1 liczbę");
        x = inputValue();
        Console.WriteLine("wpisz 2 liczbę");
        y = inputValue();
        Console.WriteLine("liczba większa to:");
        if (x > y)
        {
            Console.WriteLine(x);
        }
        else
        {
            if (y > x)
            {
                Console.WriteLine(y);
            }
        }
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
