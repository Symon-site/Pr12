using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR12
{
    internal class ObjectCounter
    {
        private static int counter;

        public ObjectCounter()
        {
            counter++;
        }

        public static void ShowCount()
        {
            Console.WriteLine($"Кол-во объектов: {counter}");
        }
    }
}
