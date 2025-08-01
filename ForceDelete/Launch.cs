using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForceDelete
{
    internal class Launch
    {

        public static void launch()
        {
            string operatingSys;
            operatingSys = Environment.OSVersion.ToString();
            Console.WriteLine("ForceDelete 1.0.0\n-----------");
            Console.WriteLine(operatingSys);
            Console.WriteLine("Loaded");
        }

    }
}
