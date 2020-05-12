using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSloop
{
    class Program
    {
        static void Main(string[] args)
        {
            long start = DateTime.Now.Ticks;
            long count = 0;
            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;

            }
            Console.WriteLine(count + "만큼 반복");

            string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            foreach (string item in array)// => (var item in array)
            {
                Console.WriteLine(item);
            }

            int[] iarr = new int[10];
            foreach(var item in iarr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
