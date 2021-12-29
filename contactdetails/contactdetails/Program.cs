using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactdetails
{
    class Program
    {
        static void Main(string[] args)
        {
            contacts contacts = new contacts();
            contacts.GetContactDetails();
            Console.ReadKey();
        }
    }
}
