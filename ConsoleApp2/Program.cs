using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        /// <summary>
        /// This is the main method.
        /// </summary>
        static void Main()
        {
            var word = "hallo";
            var test = word.LastIndexOf('.');
            var result = test.CompareTo(2);
        }
    }
}
