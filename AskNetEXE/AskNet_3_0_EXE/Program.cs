using System;
using System.Collections.Generic;
using System.Text;

namespace AskNet_3_0_EXE
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
