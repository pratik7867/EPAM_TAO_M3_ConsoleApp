using System;
using System.Text;
using System.Text.RegularExpressions;
using EPAM_TAO_M3_ConsoleApp.CustomException;

namespace EPAM_TAO_M3_ConsoleApp.StringOps
{
    class StringOPsClass
    {
        private static void ValidateString(string Str)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(Str))
                throw new InvalidStringExceptionClass(Str);
        }

        public void ConcatStrings(string Str1, string Str2)
        {
            Console.WriteLine(Str1 + Str2);
        }

        public void ExtractString(string Str, int IntStartPosition)
        {
            Console.WriteLine(Str.Substring(IntStartPosition));
        }

        public void ExtractString(string Str, int IntStartPosition, int IntLength)
        {
            Console.WriteLine(Str.Substring(IntStartPosition, IntLength));
        }

        public void CompareStrings(string Str1, string Str2)
        {
            ValidateString(Str1);
            ValidateString(Str2);

            if (Str1.CompareTo(Str2) < 0)
            {
                Console.WriteLine(Str1 + " precedes " + Str2);
            }
            else if(Str1.CompareTo(Str2) == 0)
            {
                Console.WriteLine(Str1 + " equals " + Str2);
            }
            else
            {
                Console.WriteLine(Str1 + " follows " + Str2);
            }
        }

        public void StringBuilderOps()
        {
            StringBuilder Sb1 = new StringBuilder("Hello");
            StringBuilder Sb2 = new StringBuilder("World");            

            Console.WriteLine("Length of String Builder 1, " + Sb1.Length);
            Console.WriteLine("Length of String Builder 2, " + Sb2.Length);
            Console.WriteLine(Sb1.Append(Sb2));
        }

    }
}
