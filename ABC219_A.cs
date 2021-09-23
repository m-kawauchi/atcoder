using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("値が入力されていません");
            return;
        }
        

        int Score;
        if (!int.TryParse(input, out Score))
        {
            Console.WriteLine("整数が入力されていません");
            return;
        }
        
        if (Score < 0 || Score > 100)
        {
            Console.WriteLine("範囲外の値が入力されています");
            return;
        }

        if (0 <= Score && Score < 40)
        {
            Console.WriteLine($"{40-Score}");
            return;
        }

        if (Score < 70)
        {
            Console.WriteLine($"{70-Score}");
            return;
        }
        if (Score < 90)
        {
            Console.WriteLine($"{90-Score}");
            return;
        }
    
        Console.WriteLine("expert");
        return;
    }
}