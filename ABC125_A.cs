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
        var inputList = Console.ReadLine().Split(' ');
        if (inputList.Length != 3)
        {
            Console.WriteLine("入力された要素数が正しくありません");
            return;
        }

        if (inputList.Any(item => string.IsNullOrEmpty(item)))
        {
            Console.WriteLine("入力形式が正しくありません");
            return;
        }

        if (inputList.Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("整数で入力されていません");
            return;
        }

        Console.WriteLine($"{(int.Parse(inputList[2]) / int.Parse(inputList[0])) * int.Parse(inputList[1])}");
    }
}