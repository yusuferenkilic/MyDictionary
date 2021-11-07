using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();
            isimler.Add("Yusuf");
            isimler.Print();
            Console.WriteLine(isimler.Count);

            isimler.Add("İbrahim");
            isimler.Add("Hasan");
            isimler.Print();
            Console.WriteLine(isimler.Count);

        }
    }
}
