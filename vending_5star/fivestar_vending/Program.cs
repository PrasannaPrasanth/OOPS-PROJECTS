using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vending_5star;

namespace fivestar_vending
{
    class Program
    {
        static void Main(string[] args)
        {
            vending_machine v = new vending_machine();
            Console.WriteLine(v);
            v.fivestar();

            Console.WriteLine();

            v.setrupee(5);
            v.fivestar();

            v.setrupee(20);
            v.fivestar();

            v.setrupee(10);
            v.fivestar();


        }
    }
}
