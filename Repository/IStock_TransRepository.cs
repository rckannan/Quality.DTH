using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Quality.DTH.Repository
{
    public interface IStock_TransRepository : IRepository<Stock_Transaction>
    {
        Stock_Transaction Add(Stock_Transaction item);
        Stock_Transaction Update(Stock_Transaction item);
        Task<Stock_Transaction> FindAsync(Int64 Id);
        Stock_Transaction Delete(Stock_Transaction item);
    }

    public class Stock_TransRepository
        : IStock_TransRepository
    {
        private readonly COREAPIContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public Stock_TransRepository(COREAPIContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Stock_Transaction Add(Stock_Transaction item)
        {
            var retobj = _context.Stock_Transactions.Add(item).Entity;
            this.UnitOfWork.SaveEntitiesAsync();
            return retobj;
        }

        public Stock_Transaction Update(Stock_Transaction item)
        {
            var retobj = _context.Stock_Transactions.Update(item).Entity;
            this.UnitOfWork.SaveEntitiesAsync();
            return retobj; 
        }

        public Stock_Transaction Delete(Stock_Transaction item)
        {
            var retobj = _context.Stock_Transactions.Remove(item).Entity;
            this.UnitOfWork.SaveEntitiesAsync();
            return retobj;
        }

        public async Task<Stock_Transaction> FindAsync(Int64 identity)
        {
            var buyer = await _context.Stock_Transactions
                .Include(b => b.trans_source_dealer)  
                .Where(b => b.Idbase == identity)
                .SingleOrDefaultAsync();

            return buyer;
        }
         
    }
}