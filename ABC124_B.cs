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
        string inputN = Console.ReadLine();
        if (string.IsNullOrEmpty(inputN))
        {
            Console.WriteLine("Nが入力されていません");
            return;
        }
        if (!int.TryParse(inputN, out int hotelNum))
        {
            Console.WriteLine("Nが整数で入力されていません");
            return;
        }

        var heightList = Console.ReadLine().Split(' ');
        if (heightList.Length != hotelNum)
        {
            Console.WriteLine("Hの入力数が不正です");
            return;
        }
        if (heightList.Any(item => string.IsNullOrEmpty(item)))
        {
            Console.WriteLine("入力されていないHがあります");
            return;
        }
        if (heightList.Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("Hが整数で入力されていません");
            return;
        }

        var result = heightList.Select(item => int.Parse(item)).Aggregate (new
            {
                ans = 0,maxHeight = 0
            }, 
            (total, next) => new 
            {
                ans = (total.maxHeight <= next) ? total.ans + 1 : total.ans,   maxHeight = (total.maxHeight <= next) ? next : total.maxHeight
            });

        Console.WriteLine($"{result.ans}");
    }
}