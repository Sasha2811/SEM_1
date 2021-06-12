using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB_6
{
    class Programs
    {
        static void Main(string[] args)
        {
            Reverse reverse = new Reverse();
            reverse.NumRevers();
            reverse.NumRevers(1234);
            Console.WriteLine(ReverseString());
            reverse.ReverseStr();
            Console.WriteLine(reverse.ReverseNumber(123.456));
            reverse.ReverseNumber();
            reverse.ReverseWord();
            reverse.ReverseWord("АБВГ,ДЕЖЗ");
            Console.WriteLine(reverse.DontReverse("Sasha Moskalets"));
            reverse.DontReverse();
            string text = "Hello, my name is Sasha";
            reverse.DontReverse(ref text);
            string test = "Text";
            reverse.DontReverse(test, out string texts);

        }
        static string ReverseString()
        {
            string word = "АБВГ";
            char[] array = word.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

    }
}
