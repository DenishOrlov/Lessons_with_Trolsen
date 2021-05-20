using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectins_and_generic
{
    class Person
    {
        static int i = 0;
        public Person()
        {
            i++;
        }
        
        public void Print()
        {
            Console.WriteLine("Exemle: "+i);
        }
    }

}
