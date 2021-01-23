using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Esat");
            myDictionary.Add(2, "Heysem");
            myDictionary.Add(3, "Asude");
        }
    }
}
