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
        string inputN = Console.ReadLine();

        if (!int.TryParse(inputN, out int jewelNum))
        {
            Console.WriteLine("Nが整数で入力されていません");
            return;
        }
        
        if (jewelNum < 0 || jewelNum > 20)
        {
            Console.WriteLine("Nの値が範囲外です");
            return;
        }

        var valueList = Console.ReadLine().Split(' ');
        if (valueList.Length != jewelNum)
        {
            Console.WriteLine("Vの要素数が不正です");
            return;
        }

        if (valueList.Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("Vが整数で入力されていません");
            return;
        }

        var costList = Console.ReadLine().Split(' ');
        if (costList.Length != jewelNum)
        {
            Console.WriteLine("Cの要素数が不正です");
            return;
        }

        if (costList.Any(item => !int.TryParse(item, out int i)))
        {
            Console.WriteLine("Cが整数で入力されていません");
            return;
        }

        Console.WriteLine($"{valueList.Zip(costList, (x, y) => int.Parse(x) - int.Parse(y)).ToList().Where(x => x > 0).Sum()}");
    }
}