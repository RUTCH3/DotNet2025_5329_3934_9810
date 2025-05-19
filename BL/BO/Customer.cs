using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BO
{
    public class Customer(int _id, string _name, string? _address, string? _phone)
    {
        public int Id { get; init; } = _id;
        public string Name { get; set; } = _name;
        public string? Address { get; set; } = _address;
        public string? Phone { get; set; } = _phone;

        public override string ToString() => this.ToStringProperty().ToString();
    }
}
