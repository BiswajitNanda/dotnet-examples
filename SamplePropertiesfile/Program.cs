using System;
using System.Configuration;

namespace SamplePropertiesfile
{
    class Program
    {
        static void Main(string[] args)
        {
            String companyName = ConfigurationManager.AppSettings["company"];
            String userName = ConfigurationManager.AppSettings["username"];

            //Console.WriteLine("hello");
            Console.WriteLine(companyName);
            //Console.WriteLine(userName);

        }
    }
}
