using System;
using ManagementSystemAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystemAPI.DataAccess.Implementation
{
    public class StocksProvider : IStocksProvider
    {
        public PostgreSqlContext _context;

        public StocksProvider(PostgreSqlContext context)
        {
            _context = context;
        }

        public void AddStocksRecord(Stocks stocks)
        {
            _context.stocks.Add(stocks);
            _context.SaveChanges();
        }

        public void UpdateStocksRecord(Stocks stocks)
        {
            _context.stocks.Update(stocks);
            _context.SaveChanges();
        }

        public void DeleteStocksRecord(int id)
        {
            var entity = _context.stocks.FirstOrDefault(t => t.stocks_id == id);
            _context.stocks.Remove(entity);
            _context.SaveChanges();
        }

        public Stocks GetStocksSingleRecord(int id)
        {
            return _context.stocks.FirstOrDefault(t => t.stocks_id == id);
        }

        public List<Stocks> GetStocksRecords()
        {
            return _context.stocks.ToList();
        }
    }
}
