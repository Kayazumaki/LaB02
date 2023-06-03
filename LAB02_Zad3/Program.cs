using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double waga, wzrost;

        Console.WriteLine("Wpisz masę ciała");
        waga = inputValue();
        Console.WriteLine("Wpisz wzrost w metrach");
        wzrost = inputValue();
        double bMI;

        bMI = waga / Math.Pow(wzrost, 2);
        Console.WriteLine("Twoje BMI wynosi");
        Console.WriteLine(bMI);
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
