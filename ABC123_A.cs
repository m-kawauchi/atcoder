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
        var inputList = Enumerable.Range(0, 5).Select(item => Console.ReadLine()).ToList();

        if (inputList.Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("整数で入力されていません");
            return;
        }
        if (inputList.Any(item => string.IsNullOrEmpty(item)))
        {
            Console.WriteLine("入力されていない要素があります");
            return;
        }
        str kInput = Console.ReadLine();
        if (string.IsNullOrEmpty(kInput))
        {
            Console.WriteLine("kが入力されていません");
            return;
        }
        if (!int.TryParse(kInput, out int distance))
        {
            Console.WriteLine("kが整数で入力されていません");
            return;
        }
        
        if (inputList.Select(item => int.Parse(item)).Max() - inputList.Select(item => int.Parse(item)).Min() < distance)
        {
            Console.WriteLine("Yay!");
            return;
        }

        Console.WriteLine(":(");
    }
}