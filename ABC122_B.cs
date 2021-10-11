using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        string inputS = Console.ReadLine();
        if (string.IsNullOrEmpty(inputS))
        {
            Console.WriteLine("Sが入力されていません");
            return;
        }
        var characters = "ACGT";
        var result = inputS.Aggregate (new
            {
                count = 0,ans = 0
            }, 
            (total, next) => new 
            {
                count = characters.Any(i => i == next) ? total.count + 1 : 0,   ans = (total.ans <= total.count) ? total.count : total.ans
            });
        Console.WriteLine($"{result.ans}");
    }
}