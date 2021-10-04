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

        int maxHeight = 0;
        int ans = 0;

        foreach (var item in heightList)
        {
            if (int.Parse(item) >= maxHeight)
            {
                ans += 1;
            }
            maxHeight = Math.Max(maxHeight,int.Parse(item));
        }
        Console.WriteLine($"{ans}");
    }
}