using System;

namespace TranslatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TurkishNumberTranslator.Translator.GetTurkishNumber(1).ToString());
            Console.ReadKey();
        }
    }
}
