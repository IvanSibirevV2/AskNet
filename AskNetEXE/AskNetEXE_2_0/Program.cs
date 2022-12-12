using System;
using System.Collections.Generic;
using System.Text;

namespace AskNetEXE_2_0
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
