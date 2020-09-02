using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace TurkishNumberTranslator
{
    public class Translator
    {       
        public static string GetTurkishNumber(int num)
        {
            SortedDictionary<int, string> turkishNumbers = GenerateTurkishNumbers();
            string translatedNumber = "";

            if (num == 0)
                return "sıfır";

            while (num > 0)
            {
                foreach (var x in turkishNumbers.OrderByDescending(x => x.Key))
                {
                    var sum = num - x.Key;
                    if (sum >= 0)
                    {                        
                        if (!String.IsNullOrWhiteSpace(translatedNumber))
                            translatedNumber += " ";
                        translatedNumber += x.Value;
                        num = sum;                        
                    }
                }
            }

            return translatedNumber;
        }

        private static SortedDictionary<int, string> GenerateTurkishNumbers()
        {
            return new SortedDictionary<int, string>()
            {
                { 1 , "bir" },
                {2 , "iki" },
                {3 , "üç"},
                {4 , "dört"},
                {5 , "beş"},
                {6 , "altı"},
                {7 , "yedi"},
                {8 , "sekiz"},
                {9 , "dokuz"},
                {10 , "on"},
                {20 , "yirmi"},
                {30 , "otuz"},
                {40 , "kırk"},
                {50 , "elli"},
                {60 , "altmış"},
                {70 , "yetmiş"},
                {80 , "seksen"},
                {90 , "doksan"},
            };
        }
    }
}
