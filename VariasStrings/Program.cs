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
            string string_5 = "One" + 2 + string_4;
            string string_6 = $"{string_1}" + "is not a normal string";
            string string_7 = $@"let's try {string_3}";
            string string_8 = String.Format("While do {0}", string_1);
            string string_9 = String.Format("The ultimate string is {1} and {0}", string_8, string_7);
            double testing_1 = 0.12345;
            int testing_2 = 18;

            Console.WriteLine(string_1);
            Console.WriteLine(string_2);
            Console.WriteLine(string_3);
            Console.WriteLine(string_4);
            Console.WriteLine(string_5);
            Console.WriteLine(string_6);
            Console.WriteLine(string_7);
            Console.WriteLine(string_8);
            Console.WriteLine(string_9);
            Console.WriteLine(@"olgnrso is god if {0}", string_9);
            Console.WriteLine($"number_1 = {testing_1:f2}");
            Console.WriteLine($"stats_1 = {testing_1:p1}");
            Console.WriteLine("number_2 = {0:x}", testing_2);
            Console.WriteLine("number_3 = {0:c}", testing_2);
        }
    }
}
