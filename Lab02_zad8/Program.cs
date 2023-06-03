using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, dod, odejm, mnoż, dziel, działanie;

        Console.WriteLine("wpisz 1 liczbę");
        a = inputValue();
        Console.WriteLine("wpisz 2 liczbę");
        b = inputValue();
        Console.WriteLine("dodawanie - 1 , odejmowanie - 2,mnożenie -3,dzielenie -4.");
        działanie = inputValue();
        if (działanie == 1)
        {
            dod = a + b;
            Console.WriteLine("suma wynosi " + dod);
        }
        else
        {
            if (działanie == 2)
            {
                odejm = a - b;
                Console.WriteLine("wynik to " + odejm);
            }
            else
            {
                if (działanie == 3)
                {
                    mnoż = a * b;
                    Console.WriteLine("wynik to " + mnoż);
                }
                else
                {
                    if (działanie == 4)
                    {
                        dziel = a / b;
                        Console.WriteLine("wynik to " + dziel);
                    }
                    else
                    {
                        Console.WriteLine("Proszę podać numer odpowiadający wybranemu działaniu");
                    }
                }
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


