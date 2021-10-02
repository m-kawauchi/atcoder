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
            Console.WriteLine("要素数が正しくありません");
            return;
        }
        if (inputList[0] == inputList[1])
        {
            Console.WriteLine("同じ要素が入力されています");
            return;
        }
        if (string.Compare(inputList[0], inputList[1]) < 0)
        {
            Console.WriteLine("Yes");
            return;
        } 
        Console.WriteLine("No");
    }
}