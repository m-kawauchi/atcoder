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
        var pList = Console.ReadLine().Split(' ');

        if (pList.Length != 26)
        {
            Console.WriteLine("数列の要素数が正しくありません");
            return;
        }
        if (pList.Any(x => !int.TryParse(x, out int i)))
        {
            Console.WriteLine("数列に整数以外の入力が含まれています");
            return;
        }
        
        if (pList.Any(x => int.Parse(x) > 26 | int.Parse(x) < 1))
        {
            Console.WriteLine("数列に範囲外の値が含まれています");
            return;
        }
        
        var ansList = pList.Select(x => (char)('a' + int.Parse(x) -1));
        Console.WriteLine(string.Join("",ansList));

    }
}