using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, "Five");

            foreach (object i in ht.Keys)
            Console.WriteLine(i);

            foreach (object j in ht.Values)
            Console.WriteLine(j);

            foreach (DictionaryEntry di in ht)
            Console.WriteLine("key={0} values={1}", di.Key, di.Value);
            Console.ReadKey();
    }
  }
}
