using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        string dayInput = Console.ReadLine();
        if (string.IsNullOrEmpty(dayInput))
        {
            Console.WriteLine("日数が入力されていません");
            return;
        }
        
        int day;
        if (!int.TryParse(dayInput, out day))
        {
            Console.WriteLine("日数が整数で入力されていません");
            return;
        }

        if (day < 1 || day > 7)
        {
            Console.WriteLine("日数の値が範囲内にありません");
            return;
        }
        string forcast = Console.ReadLine();
        if (string.IsNullOrEmpty(forcast))
        {
            Console.WriteLine("予報が入力されていません");
            return;
        }

        if (forcast.Any(x => x != 'x' & x != 'o'))
        {
            Console.WriteLine("予報の入力形式が不正です");
            return;
        }

        if (forcast.Length != 7)
        {
            Console.WriteLine("予報の入力数が不正です");
            return;
        }
        
        if (forcast[day-1] == 'x')
        {
            Console.WriteLine("No");
            return;
        }
        
        Console.WriteLine("Yes");
    }
}