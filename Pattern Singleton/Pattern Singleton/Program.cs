using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Клиентский код.
            Singleton s1 = Singleton.GetInstance();
            
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            Singleton.someBusinessLogic();

            Console.ReadKey();
        }
    }
}
