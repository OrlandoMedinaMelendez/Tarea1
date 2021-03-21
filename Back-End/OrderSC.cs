using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Models;

namespace Tarea1.Back_End
{
    class OrderSC : BaseSC, IUpdate
    {

        public IQueryable<Order> GetOrders()
        {
            return dataContext.Orders.AsQueryable();
        }

        public Order GetOrderById(int id)
        {
            return GetOrders().Where(x => x.OrderId == id).First();
        }

        public void AddOrder(Order newOrder)
        {

            var newOrderReg = new Order();
            newOrderReg.ShipName = newOrder.ShipName;
            newOrderReg.ShipCity = newOrder.ShipCountry;

            dataContext.Orders.Add(newOrderReg);
            dataContext.SaveChanges();
        }

        public void UpdateNameById(int id, string name)
        {
            var currentOrder = new OrderSC().GetOrderById(id);
            currentOrder.ShipName = name;
            dataContext.Orders.Update(currentOrder);
            dataContext.SaveChanges();
        }
    }
}