using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>()
            {
                "Fifa 22",
                "Call of Duty",
                "GTA 5"
            };

            var ordered = videoGames.OrderBy(name => name.Length).ToList();
        }
    }
}

