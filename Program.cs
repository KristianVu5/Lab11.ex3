using System;
using System.IO;
namespace file
{
    class Program
    {
        static void Main()
        {
            string test = "Irena Todorova Ivanova, Tzar Osvoboditel, 21, Varna";

            StringReader r = new StringReader(test);

            string cc = r.ReadToEnd();

            if (cc.Length != 0)
                Console.WriteLine(cc);
            else
                Console.WriteLine("Test string is empty");
            Console.ReadKey();

        }
    }
}