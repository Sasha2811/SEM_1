using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB_6
{
        public class Reverse
        {
            public void NumRevers()
            {
                int num = 1234;
                Console.WriteLine(num.ToString().Reverse().ToArray());
            }
            public void NumRevers(int num)
            {
                Console.WriteLine(num.ToString().Reverse().ToArray());
            }

            public string ReverseString(string word)
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        public void ReverseStr()
        {
            string[] word = {"АБВГ"};
                Array.Reverse(word);
                Console.WriteLine(word);
            }
            public double ReverseNumber(double number)
            {
                return double.Parse(ReverseString(number.ToString()));
            }
            public void ReverseNumber()
            {
                double number = 123.456;
                Console.WriteLine(double.Parse(ReverseString(number.ToString())));
            }
            public void ReverseWord()
            {
                string startWord = "АБВГ,ДЕЖЗ";
                Console.WriteLine(startWord);
                string secondWord = "АБВГ,ДЕЖЗ";
                
                char[] sReverse = secondWord.ToCharArray();
                Array.Reverse(sReverse);
                secondWord = new string(sReverse);
                Console.WriteLine(secondWord);
            }
            public void ReverseWord(string secondWord)
            {
                string startWord = "АБВГ,ДЕЖЗ";
                Console.WriteLine(startWord);
                
                char[] sReverse = secondWord.ToCharArray();
                Array.Reverse(sReverse);
                secondWord = new string(sReverse);
                Console.WriteLine(secondWord);
            }
            public void DontReverse()
            {
                string text = "Hello, my name is Sasha";
                char[] cArray = text.ToCharArray();
                string reverse = String.Empty;
                for (int i = cArray.Length - 1; i > -1; i--)
                {
                    reverse += cArray[i];
                }
                Console.WriteLine(reverse);
            }
            public string DontReverse(string text)
            {
                char[] cArray = text.ToCharArray();
                string reverse = String.Empty;
                for (int i = cArray.Length - 1; i > -1; i--)
                {
                    reverse += cArray[i];
                }
                return reverse;
            }
            public void DontReverse(ref string text)
            {
                char[] cArray = text.ToCharArray();
                string reverse = String.Empty;
                for (int i = cArray.Length - 1; i > -1; i--)
                {
                    reverse += cArray[i];
                }
                Console.WriteLine(reverse);
            }
            public void DontReverse(string test, out string texts)
            {
                texts = "Sasha";
                char[] cArray = texts.ToCharArray(); 
                string reverse = String.Empty;
                for (int i = cArray.Length - 1; i > -1; i--)
                {
                    reverse += cArray[i];
                }
                Console.WriteLine(reverse);
            }
        }
    }

