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
        var inputS = Enumerable.Range(0, 3).Select(item => Console.ReadLine()).ToList();
        
        if (inputS.Any(item => string.IsNullOrEmpty(item)))
        {
            Console.WriteLine("文字列Sが入力されていません");
            return;
        }
        
        if (inputS.Count != inputS.Distinct().Count())
        {
            Console.WriteLine("要素が重複しています");
            return;
        }

        var contestNameList = new List<string> {"ABC","ARC","AGC","AHC"};
        if (inputS.Any(x => !(contestNameList.Contains(x))))
        {
            Console.WriteLine("入力値が不正です");
            return;
        }

        Console.WriteLine(string.Join("",contestNameList.Except(inputS)));
    }
}