using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEncapsulation
{


    /// <summary>
    /// Abstraction - what is needed = user only need custcode and cust name 
    /// Encapsulation - made all other code private - achive through access modifiers =validate is private since customer not needed this
    /// </summary>
    internal class Program
    {
        class Customer
        {
            public string custCode { get; set; }    
            public string custName { get; set; }

            public void Add()
            {
                Validate();
            }
            private void Validate()
            {

            }
        }
        static void Main(string[] args)
        {
            Customer obj = new Customer();
            obj.custCode = "000";

            obj.custName = "Neha";
            obj.Add();

        }
    }
}
