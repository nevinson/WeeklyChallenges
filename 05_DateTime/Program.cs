using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;

            Console.WriteLine(now.ToString("MM/dd/yyyy"));
            Console.WriteLine(now.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(now.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(now.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(now.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(now.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(now.ToString("MM/dd/yyyy HH:mm"));
            Console.WriteLine(now.ToString("MM/dd/yyyy hh:mm tt"));
            Console.WriteLine(now.ToString("MM/dd/yyyy H:mm"));
            Console.WriteLine(now.ToString("MM/dd/yyyy h:mm tt"));
            Console.WriteLine(now.ToString("MM/dd/yyyy HH:mm:ss"));
            Console.WriteLine(now.ToString("MMMM dd"));
            Console.WriteLine(now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK"));
            Console.WriteLine(now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));
            Console.WriteLine(now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss"));
            Console.WriteLine(now.ToString("HH:mm"));
            Console.WriteLine(now.ToString("hh:mm tt"));
            Console.WriteLine(now.ToString("H:mm"));
            Console.WriteLine(now.ToString("h:mm tt"));
            Console.WriteLine(now.ToString("HH:mm:ss"));
            Console.WriteLine(now.ToString("yyyy MMMM"));

            Console.ReadLine();
        }
    }
}
