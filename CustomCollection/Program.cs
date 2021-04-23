using System;

namespace CustomCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomCollectionS<int> cc = new CustomCollectionS<int>();
            cc.Add(1);
            cc.Add(2);
            cc.Add(5);
            cc.Add(8);
            cc.Add(2);
            Console.WriteLine(cc.Remove(1));
            cc.Add(3);
            cc.Insert(0, 205);
            cc.RemoveAt(3);
            foreach(var c in cc)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("index 2 = "+ cc[2]);
        }
    }
}
