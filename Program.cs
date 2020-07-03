using System;

namespace mors
{
    // 12 kasım 2018
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                //string input = "MERHABA";
                string ret = Alphabet.getCodeOfLetters(input);
                Console.WriteLine(ret);

            }
        }
    }
}
