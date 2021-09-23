using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        string DayInput = Console.ReadLine();
        if (string.IsNullOrEmpty(DayInput))
        {
            Console.WriteLine("日数が入力されていません");
            return;
        }
        
        int Day;
        if (!int.TryParse(DayInput, out Day))
        {
            Console.WriteLine("日数が整数で入力されていません");
            return;
        }
        string Forcast = Console.ReadLine();
        if (string.IsNullOrEmpty(Forcast))
        {
            Console.WriteLine("予報が入力されていません");
            return;
        }
        bool sFlg = true;
        foreach (var c in Forcast)
        {
            if (c.ToString() != "o" && c.ToString() != "x")
            {
                sFlg = false;
            }
        }
        if (!sFlg)
        {
            Console.WriteLine("予報の入力形式が不正です");
            return;
        }
        if (Forcast[Day-1].ToString() == "x")
        {
            Console.WriteLine("No");
            return;
        }
        Console.WriteLine("Yes");
    }
}