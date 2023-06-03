using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("sprawdź czy trójkąt może być równoboczny");
        Console.WriteLine("1 bok trójkąta");
        a = inputValue();
        Console.WriteLine("2 bok trójkąta");
        b = inputValue();
        Console.WriteLine("3 bok trójkąta");
        c = inputValue();
        if (a == b)
        {
            if (a == c)
            {
                Console.WriteLine("TAK! trójkąt może być równoboczny");
            }
            else
            {
                Console.WriteLine("NIE! trójkąt nie może być równoboczny");
            }
        }
        else
        {
            Console.WriteLine("NIE! trójkąt nie może być równoboczny");
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
