using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR12
{
    internal class ProgramConfig
    {
        private const int _version = 1;
        private const string _author = "Jone Doy";

        public static void ShowInfo()
        {
            Console.WriteLine($"Автор: {_author}\nВерсия: {_version}");

        }
    }
}
