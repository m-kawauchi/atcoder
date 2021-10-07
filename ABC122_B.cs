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
        /*
        int ans = 0;
        int count = 0;
        foreach (char s in inputS)
        {
            if (s == 'A' || s == 'C' || s == 'G' || s == 'T')
            {
                count += 1;
                ans = Math.Max(ans,count);
            }
            else
            {
                count = 0;
            }
        }
        */
        var result = inputS.Aggregate (new
            {
                count = 0,ans = 0
            }, 
            (total, next) => new 
            {
                count = (next == 'A' || next == 'C' || next == 'G' || next == 'T') ? total.count + 1 : 0,   ans = (total.ans <= total.count) ? total.count : total.ans
            });
        Console.WriteLine($"{result.ans}");
    }
}