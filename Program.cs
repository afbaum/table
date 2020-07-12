using System;
using System.Collections.Generic;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Settings settings = new Settings();
            foreach(string s in settings.formal())
            {
                Console.Write(" " + s + " ");
            }
        }
    }
}
