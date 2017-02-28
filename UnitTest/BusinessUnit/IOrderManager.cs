using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessUnit
{
    interface IOrderManager
    {
        int SaveMyOrder(OrderDetail order);
    }
}
