using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration
            string name = "Dineo";
            int age = 25;
            bool isTall=true;
            double weight = 65.8;

            /* for th smallest least precise decimal use float,
             * for more precise use decimal e.g for money,
             * in most cases double will do just fine
             * */

            Console.WriteLine(name + "is" + age + "she weighs" + weight);
            Console.WriteLine( "it  is" + isTall + "that she is tall." );

            //freeze console
            Console.ReadLine();
        }
    }
}
