using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string string_1 = "Normal_string";
            string string_2 = "String with spaces";
            string string_3 = "\'String with unicode \u006E \u0069 \u0063 \u0065\'";
            string string_4 = @"String verbatim º*'34»«";
            Console.WriteLine(string_1);
            Console.WriteLine(string_2);
            Console.WriteLine(string_3);
            Console.WriteLine(string_4);
        }
    }
}
