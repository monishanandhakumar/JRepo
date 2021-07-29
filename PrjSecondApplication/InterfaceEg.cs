using System;
using System.Collections.Generic;
using System.Text;

namespace PrjSecondApplication
{
    interface INormalCal
    {
        //events,properties,methods
        //Public and Abstract
        int Add(int x, int y);
        int Sub(int x, int y);
        
    }

    class Calculator: INormalCal,ISciCal
    {
        int INormalCal.Add(int x,int y)
        {
            
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

         int ISciCal.Add(int x, int y)
        {
            return x + y;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }


    }
    class InterfaceEg
    {
        static void Main()
        {
            INormalCal ncal = new Calculator();
            Console.WriteLine("Addition of Normal Calculator:{0}", ncal.Add(5, 7));
            Console.WriteLine("Subtraction of Normal Calculator:{0}", ncal.Sub(90, 7));
            ISciCal scical = new Calculator();
            Console.WriteLine("Addition of Scientific Calculator:{0}", scical.Add(5, 7));
            Console.WriteLine("Multiple of Scientific Calculator:{0}", scical.Mul(90, 7));
        }

    }
}
