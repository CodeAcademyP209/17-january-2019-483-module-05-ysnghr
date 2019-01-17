using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public delegate bool Tester(int num);
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numlist = new List<int>()
            {
                1,2,56,3,67,45,789,12,34,87
            };
            Console.WriteLine(numlist.Maksimum(x => x > 0));
        }
    }
    static class ExtentionMethods
    {
        public static int  Maksimum(this List<int> list,Tester del)
        {
            var custom = new List<int>();
            int maksnumber = 0;
            foreach (var item in list)
            {
                if (del(item))
                {
                    if (item>maksnumber)
                    {
                        maksnumber = item;
                        
                    }
                }
            }
            return maksnumber;
        }
    }
}
