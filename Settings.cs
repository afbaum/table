using System;
using System.Collections.Generic;

namespace Table
{
    class Settings
    {              
        public List<string> formal()
        {
            Spoons spoons = new Spoons();

            List<string> setting = new List<string>()
            {
                spoons.tableSpoon,
                spoons.teaSpoon,
                spoons.dessertSpoon,
                spoons.soupSpoon,
            };
            return setting;
        } 
    }
}