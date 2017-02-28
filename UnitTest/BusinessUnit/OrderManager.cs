using DataModel;
using DBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessUnit
{
    public class OrderManager : IOrderManager
    {
        public int SaveMyOrder(OrderDetail order)
        {
            var status = ValidateInput(order);

            var o = new Order();
            var c = new Customer();

            o.Price = order.ProductPrice;
            o.ProductId = order.ProductId;
            o.OrderStatus = GetOrderStatus(order);

            c.Address = order.Address;
            c.CardExpiryMonth = order.CardExpiryMonth;
            c.CardExpiryYear = order.CardExpiryYear;
            c.CardNumber = order.CardNumber;
            c.CardSecurityCode = order.CardSecurityCode;
            c.City = order.City;
            c.Email = order.Email;
            c.FirstName = order.FirstName;
            c.LastName = order.LastName;
            c.Phone = order.Phone;
            c.State = order.State;
            c.Zip = order.Zip;

            DataStore ds = new DataStore();
            return ds.SaveCustomerOrder(c, o);
        }

        private Int16 GetOrderStatus(OrderDetail order)
        {
            DateTime today = new DateTime();
            var cardDate = new DateTime(order.CardExpiryYear, order.CardExpiryMonth, DateTime.Now.Day);

            if (today > cardDate)
                return 2;
            else
                return 1;

        }

        private bool ValidateInput(OrderDetail order)
        {

            return true;
        }
    }
}
