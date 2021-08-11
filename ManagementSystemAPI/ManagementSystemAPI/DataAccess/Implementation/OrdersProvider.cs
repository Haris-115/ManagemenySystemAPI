using ManagementSystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystemAPI.DataAccess.Implementation
{
    public class OrdersProvider : IOrdersProvider
    {
        public PostgreSqlContext _context;

        public OrdersProvider(PostgreSqlContext context)
        {
            _context = context;
        }

        public void AddOrdersRecord(Orders orders)
        {
            _context.orders.Add(orders);
            _context.SaveChanges();
        }

        public void UpdateOrdersRecord(Orders orders)
        {
            _context.orders.Update(orders);
            _context.SaveChanges();
        }

        public void DeleteOrdersRecord(int id)
        {
            var entity = _context.orders.FirstOrDefault(t => t.orders_id == id);
            _context.orders.Remove(entity);
            _context.SaveChanges();
        }

        public Orders GetOrdersSingleRecord(int id)
        {
            return _context.orders.FirstOrDefault(t => t.orders_id == id);
        }

        public List<Orders> GetOrdersRecords()
        {
            return _context.orders.ToList();
        }
    }
}
