﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Models;

namespace Tarea1.Back_End
{
    class OrderSC : BaseSC, IRead, IWrite
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

        public void UpdateShipNameOrderById(int id, String shipName)
        {
            var currentOrder = new OrderSC().GetOrderById(id);
            currentOrder.ShipName = shipName;
            dataContext.Orders.Update(currentOrder);
            dataContext.SaveChanges();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Create(int id)
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
