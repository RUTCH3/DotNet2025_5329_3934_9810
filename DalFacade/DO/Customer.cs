using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Customer(int _id, string _name, string _address, string _phone)
    {
        public Customer() : this(0, "", "", "")
        {

        }
    
        public void toString()
        {
            Console.WriteLine($"Id: {_id},  Nmae: {_name}, Address: {_address}, Phone: {_phone}");
        }
    }
}
