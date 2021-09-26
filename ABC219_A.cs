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
        

        int score;
        if (!int.TryParse(input, out score))
        {
            Console.WriteLine("整数が入力されていません");
            return;
        }

        if (score < 0 || score > 100)
        {
            Console.WriteLine("範囲外の値が入力されています");
            return;
        }

        if (0 <= score && score < 40)
        {
            Console.WriteLine($"{40-score}");
            return;
        }

        if (score < 70)
        {
            Console.WriteLine($"{70-score}");
            return;
        }
        if (score < 90)
        {
            Console.WriteLine($"{90-score}");
            return;
        }
    
        Console.WriteLine("expert");
        return;
    }
}