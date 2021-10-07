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
        string inputB = Console.ReadLine();

        if (string.IsNullOrEmpty(inputB))
        {
            Console.WriteLine("bが入力されていません");
            return;
        }
        if (inputB != "A" && inputB != "C" && inputB != "G" && inputB != "T")
        {
            Console.WriteLine("入力値が不正です");
            return;
        }
        switch(inputB)
        {
            case "A":
                Console.WriteLine("T");
                break;
            case "T":
                Console.WriteLine("A");
                break;
            case "C":
                Console.WriteLine("G");
                break;
            case "G":
                Console.WriteLine("C");
                break;
        }
    }
}