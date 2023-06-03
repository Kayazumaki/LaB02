using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double poleKola;
        Console.WriteLine("Proszę wpisać Pole Koła");
        poleKola = inputValue();
        double r;
        
        r = Math.Pow(poleKola / Math.PI, (double) 1 / 2);
        double obwod;
        
        obwod = r * Math.PI * 2;
        Console.WriteLine("Obwód wynosi:");
        Console.WriteLine(obwod);
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}

