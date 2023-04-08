using System;

namespace string_text_processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello world!";
            int length = str.Length;
            Console.WriteLine("The length of the string is: " + length);
            string str1 = "This is a sentence.";
            string[] words = str1.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}