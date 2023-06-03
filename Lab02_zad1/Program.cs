using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        a = inputValue();
        b = inputValue();
        c = inputValue();
        double sredniaArytmetyczna;

        sredniaArytmetyczna = (a + b + c) / 3;
        Console.WriteLine("średnia arytmetyczna wychodzi");
        Console.WriteLine(sredniaArytmetyczna);
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


