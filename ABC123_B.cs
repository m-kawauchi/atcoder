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

        if (inputList.Any(item => string.IsNullOrEmpty(item)))
        {
            Console.WriteLine("入力されていない要素があります");
            return;
        }
        if (inputList.Count() != 5)
        {
            Console.WriteLine("要素数が不正です");
            return;
        }
        if (inputList.Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("整数で入力されていない要素があります");
            return;
        }
        var lossList = inputList.Select(item => (10 - (int.Parse(item) % 10)) % 10);

        Console.WriteLine($"{inputList.Select(item => int.Parse(item)).Sum() + lossList.Sum() - lossList.Max()}");
    }
}