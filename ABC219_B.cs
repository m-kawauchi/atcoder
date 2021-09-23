using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string S1, S2, S3;
        S1 = Console.ReadLine();
        S2 = Console.ReadLine();
        S3 = Console.ReadLine();
        if (string.IsNullOrEmpty(S1) || string.IsNullOrEmpty(S2) || string.IsNullOrEmpty(S3))
        {
            Console.WriteLine("文字列Sが入力されていません");
            return;
        }

        string TInput = Console.ReadLine();

        if (string.IsNullOrEmpty(TInput))
        {
            Console.WriteLine("文字列Tが入力されていません");
            return;
        }

        bool tFlg = true;
        foreach (var c in TInput)
        {
            if (c != '1' && c != '2' && c != '3')
            {
                tFlg = false;
            }
        }
        if (!tFlg)
        {
            Console.WriteLine("Tに不正な入力が含まれています");
            return;
        }

        var SList = new List<string> {S1,S2,S3};
        
        for (int i = 0; i <= TInput.Length - 1; i++)
        {
            char _tmp = TInput[i];
            int number = int.Parse(_tmp.ToString());
            Console.Write(SList[number-1]);
        }
    }
}