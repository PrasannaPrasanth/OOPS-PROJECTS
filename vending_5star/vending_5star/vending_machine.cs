using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_5star
{
    public class vending_machine
    {
        money _rupee;

        public money Rupee
        {
            get { return _rupee; }
            set { _rupee = value; }
        }

        public override string ToString()
        {
            return string.Format("Rupees: {0}",this._rupee);
        }
        public vending_machine()
        {
            Rupee = money.zero;
        }

        
        public void fivestar()
        {
            if (Rupee == money.five)
            {
                Console.WriteLine("Take a 5 rupee 5-STAR");
            }
            else if (Rupee == money.ten)
            {
                Console.WriteLine("Take a 10 rupee 5-STAR");
            }
            else if (Rupee == money.twenty)
            {
                Console.WriteLine("Take a 20 rupee 5-STAR");
            }
            else if (Rupee == money.zero)
            {
                Console.WriteLine("please give a amount");
            }
        }

        public void setrupee(int s)
        {
            if (s == 5)
            {
                Rupee = money.five;
            }
            if (s == 10)
            {
                Rupee = money.ten;
            }
            if (s == 20)
            {
                Rupee = money.twenty;
            }
        }
        


    }
}
