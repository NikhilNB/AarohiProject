using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            addition();

        }

        public static void addition()
        {
            int x = 10, y = 20, z;
            z = x + y;
            Console.WriteLine("Addition is :"+z);
        }
    }
}
