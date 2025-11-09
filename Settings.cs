using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR12
{
    internal class Settings
    {
        private static readonly string _link;

        static Settings()
        {
            _link = "D:/RefFaf/aaa/llla/Text.txt";
        }

        public static void ShowLink()
        {
            Console.WriteLine($"Путь: {_link}");
        }
    }
}
