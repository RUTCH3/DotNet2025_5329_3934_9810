using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DalApi
{
    public interface IDAL
    {
        public ICustomer Customer { get; }
        public IProduct Product { get; }
        public ISale Sale { get; }
    }
}
