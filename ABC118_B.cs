using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ABC
{
    class Research
    {
        public List<int> foodNames {get;}
        public bool containsError {get;}
        public Research(List<int> foodNames)
        {
            this.foodNames = foodNames;
        }
        public Research(bool containsError)
        {
            this.containsError = containsError;
        }    
    }
    class Program
    {
        static void Main()
        {
            var inputList = Console.ReadLine().Split(' ');
            if (inputList.Length != 2)
            {
                Console.WriteLine("N,Mの入力数が不正です");
                return;
            }
            List <int> intList1;
            try
            {
                intList1 = inputList.Select(item => int.Parse(item)).ToList();
            }
            catch (FormatException)
            {
                Console.WriteLine("N,Mが整数で入力されていません");
                return;
            }

            if (intList1.ToList().Any(item => item < 1 || item > 30))
            {
                Console.WriteLine("N,Mの値の範囲が不正です");
                return;
            }

            var inputList2 = Enumerable.Range(0, intList1.ElementAt(0)).Select(item => Console.ReadLine().Split(' ')); 
            List <List<int>> intList2;
            try
            {
                intList2 = inputList2.Select(item => item.Select(x => int.Parse(x)).ToList()).ToList();
            }
            catch (FormatException)
            {
                Console.WriteLine("K,Aが整数で入力されていません");
                return;
            }
            var researchs = intList2.Select(
                item => {
                    
                    var favoritFoods = item.Skip(1);

                    if (favoritFoods.Count() != item.ElementAt(0) || favoritFoods.Any(x => x < 1 || x > intList1.ElementAt(1)))
                    {
                        return new Research(true);
                    }

                    return new Research(favoritFoods.ToList());
                }
            ).ToList();

            if (researchs.Any(item => item.containsError))
            {
                Console.WriteLine("K,Aの入力形式が不正です");
                return;
            }
            Console.WriteLine($"{researchs.Aggregate(researchs.ElementAt(0).foodNames.ToList(), (ans, next) => ans = ans.ToList().FindAll(next.foodNames.ToList().Contains)).Count()}");
        }
    }
}