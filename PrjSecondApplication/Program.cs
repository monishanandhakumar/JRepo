using System;

namespace PrjSecondApplication
{
    class Program
    {
        int id=90;
      internal  static string regno = "65q657";

        static void Display()
        {
            int cal;
            Program p=new Program();
           p.id = 90;
          //  cal = id + id;
            Console.WriteLine(regno);

        }

        class Sample
        {
            void Get()
            {
                Console.WriteLine(Program.regno);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
