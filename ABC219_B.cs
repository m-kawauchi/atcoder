using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string s1, s2, s3;
        s1 = Console.ReadLine();
        s2 = Console.ReadLine();
        s3 = Console.ReadLine();
        if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2) || string.IsNullOrEmpty(s3))
        {
            Console.WriteLine("文字列Sが入力されていません");
            return;
        }

        string tInput = Console.ReadLine();

        if (string.IsNullOrEmpty(tInput))
        {
            Console.WriteLine("文字列Tが入力されていません");
            return;
        }

        if(tInput.Any(x => x != '1' & x != '2' & x != '3'))
        {
            Console.WriteLine("Tに不正な入力が含まれています");
            return;
        }

        var sList = new List<string> {s1,s2,s3};
        var ansList = tInput.Select(x => sList[int.Parse(x.ToString())-1]).ToList();
        Console.Write(string.Join("",ansList));
        
    }
}