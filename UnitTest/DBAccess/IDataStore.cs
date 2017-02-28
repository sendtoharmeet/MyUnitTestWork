using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess
{
    interface IDataStore
    {
        int SaveCustomerOrder(Customer c, Order o);
    }
}
