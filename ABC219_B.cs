using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var inputS = Enumerable.Range(0, 3).Select(item => Console.ReadLine()).ToList();
        
        if (inputS.Any(item => string.IsNullOrEmpty(item)))
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

        
        Console.Write(
            string.Join("",
                tInput.Select(x => {
                    var index = int.Parse(x.ToString()) -1;
                    return inputS.ElementAt(index);
                })
            ));       
    }
}