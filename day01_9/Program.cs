using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01_9
{
    class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                Console.WriteLine("我是真的");
               
            }else
            {
                 Console.WriteLine("我是假的");
            }

            int switchKey = 100;
            switch (switchKey)
            {
                case 10:
                    Console.WriteLine("switchkey is 10");
                    break;
                case 100:
                    Console.WriteLine("switchkey is 100");
                    break;
                default:
                    Console.WriteLine("i don't know switchkey");
                    break;
            }
            Console.ReadLine();
        }
    }
}
