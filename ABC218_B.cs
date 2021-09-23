using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        var PList = Console.ReadLine().Split(' ');
        bool pFlg = false;
        foreach (var c in PList)
        {
            int _tmp;
            if (!int.TryParse(c, out _tmp))
            {
                Console.WriteLine("Pに整数以外が入力されています");
                return;
            }
            if (_tmp >26 || _tmp < 0)
            {
                Console.WriteLine("Pの値が不正です");
                return;
            }
        }
        for (int i = 0; i < 26; i++)
        {
            Console.Write((char)('a' + int.Parse(PList[i]) - 1));
        }

    }
}