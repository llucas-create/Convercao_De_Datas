using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string datastring = "2021-16-26 14:19";

            DateTime.TryParseExact(datastring, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
