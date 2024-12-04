using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Customer
    {
        private int _id = 0;
        private string _name = "";
        private string? _address;
        private string? _phone;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string? Address { get => _address; set => _address = value; }
        public string? Phone { get => _phone; set => _phone = value; }
        public Customer() { }
        public Customer(int id, string name, string? address, string? phone)
        {
            this._id = id;
            this._name = name;
            this._address = address;
            this._phone = phone;
        }
        public void toString()
        {
            Console.WriteLine($"Id: {_id},  Nmae: {_name}, Address: {_address}, Phone: {_phone}");
        }
    }
}
