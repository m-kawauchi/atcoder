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
        if (inputList.Length != 2)
        {
            Console.WriteLine("入力された要素数が不正です");
            return;
        }

        if (inputList.Any(item => string.IsNullOrEmpty(item)))
        {
            Console.WriteLine("入力されていない要素があります");
            return;
        }

        if (inputList.Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("値が整数で入力されていません");
            return;
        }

        var intList = inputList.Select(item => int.Parse(item));

        if (intList.Max() - intList.Min() > 1)
        {
            Console.WriteLine($"{intList.Max() * 2 - 1}");
            return;
        }

        Console.WriteLine($"{intList.Sum()}");
    }
}