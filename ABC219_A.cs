using System;

class Program
{
    static void Main()
    {
        var Score = int.Parse(Console.ReadLine());
        var Ans = string.Empty;

        if (0 <= Score && Score < 40)
        {
            Ans = (40-Score).ToString();
        }
        else if (Score < 70)
        {
            Ans = (70-Score).ToString();
        }
        else if (Score < 90)
        {
            Ans = (90-Score).ToString();
        }
        else
        {
            Ans = "expert";
        }
        Console.WriteLine(Ans);
    }
}