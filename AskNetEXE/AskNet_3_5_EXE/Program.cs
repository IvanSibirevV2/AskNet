using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AskNet_3_5_EXE
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Привет мир");
            System.Console.WriteLine(AskNet.AskNet.Ask());
            System.Console.ReadLine();
        }
    }
}
