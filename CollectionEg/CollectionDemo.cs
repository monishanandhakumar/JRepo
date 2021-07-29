using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionEg
{
 
    class CollectionDemo
    {
      static  void ArrarEg()
        {
            ArrayList al = new ArrayList();


            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add(10);  //boxing
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add("Devi");
            al.Add(100.0f);
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add('a');
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add(20);
            Console.WriteLine("Capacity {0}", al.Capacity);
            foreach (var arraylist in al)
            {
                Console.WriteLine(arraylist);
            }
            Console.WriteLine("Count is {0}",al.Count);
            Console.WriteLine("indexof is {0}",al.IndexOf(20));
            Console.WriteLine("Capacity {0}",al.Capacity);
            al.Remove("Devi");
            al.Remove(20);

            //Unboxing
            foreach (var arraylist in al)
            {
                Console.WriteLine(arraylist);
            }

            Console.WriteLine("Capacity {0}", al.Capacity);
        }

        //combination of key and value 
        static void HashtableEg()
        {
            Hashtable ht = new Hashtable();
            ht.Add(4, "Networks");
            ht.Add(2, "Operating System");
            ht.Add(1, "Java");
           
            ht.Add("U", "Unix");

            Console.WriteLine(ht.Contains("O")); 
            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+ " : "+d.Value);
            }

           
        }

        static void SortedListEg()
        {
            SortedList sl = new SortedList();
            sl.Add("N", "Networks");
            sl.Add("O", "Operating System");
            sl.Add("j", "Java");

            sl.Add("U", "Unix");

            foreach (DictionaryEntry d in sl)
            {
                Console.WriteLine(d.Key + " : " + d.Value);
            }
        }
        static void Main()
        {
            ArrarEg();
            Console.WriteLine("HashTable");
            HashtableEg();
            Console.WriteLine("SortedList");
            SortedListEg();

        }
    }
}
