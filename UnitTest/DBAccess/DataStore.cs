using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DBAccess
{
    public class DataStore : IDataStore
    {
        public int SaveCustomerOrder(Customer c, Order o)
        {
            try
            {
                using (var context = new DbEntityContext())
                {
                    context.Customers.Add(c);
                    o.CustomerId = c.CustomerId;

                    context.Orders.Add(o);
                    context.SaveChanges();
                }
                return o.OrderStatus;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }
    }
}
