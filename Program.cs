using System;

namespace search
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1;
            string s2;
            Console.WriteLine("enter first string");
            s1 =Console.ReadLine();
            Console.WriteLine("enter second string");
            s2 =Console.ReadLine();
            Console.WriteLine();
            foreach (var item in s1)
            {
                foreach (var item2 in s2)
                {
                    if (item2==item)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
