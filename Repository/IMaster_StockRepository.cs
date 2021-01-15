using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Quality.DTH.Repository
{
    public interface IMaster_StockRepository : IRepository<Master_Stock>
    {
        Master_Stock Add(Master_Stock item);
        Master_Stock Update(Master_Stock item);
        Task<Master_Stock> FindAsync(Int64 Id);
        Master_Stock Delete(Master_Stock item);
    }

    public class Master_StockRepository
        : IMaster_StockRepository
    {
        private readonly COREAPIContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public Master_StockRepository(COREAPIContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Master_Stock Add(Master_Stock item)
        {
            var retobj = _context.Master_Stocks .Add(item).Entity;
            this.UnitOfWork.SaveEntitiesAsync();
            return retobj;
        }

        public Master_Stock Update(Master_Stock item)
        {
            var retobj = _context.Master_Stocks.Update(item).Entity;
            this.UnitOfWork.SaveEntitiesAsync();
            return retobj; 
        }

        public Master_Stock Delete(Master_Stock item)
        {
            var retobj = _context.Master_Stocks.Remove(item).Entity;
            this.UnitOfWork.SaveEntitiesAsync();
            return retobj;
        }

        public async Task<Master_Stock> FindAsync(Int64 identity)
        {
            var buyer = await _context.Master_Stocks
                .Where(b => b.Idbase == identity)
                .SingleOrDefaultAsync();

            return buyer;
        }
         
    }

    //class updateT<T>  where T : Entity
    //{
    //    private readonly COREAPIContext _context;
    //    public IUnitOfWork UnitOfWork
    //    {
    //        get
    //        {
    //            return _context;
    //        }
    //    }

    //    public updateT(COREAPIContext context)
    //    {
    //        _context = context ?? throw new ArgumentNullException(nameof(context));
    //    }
    //    public T Add(T item)
    //    {
    //        var retobj = _context.Add(item).Entity;
    //        this.UnitOfWork.SaveEntitiesAsync();
    //        return retobj;
    //    }

    //    public T Update(T item)
    //    {
    //        var retobj = _context.Update(item).Entity;
    //        this.UnitOfWork.SaveEntitiesAsync();
    //        return retobj;
    //    }

    //    public T Delete(T item)
    //    {
    //        var retobj = _context.Remove(item).Entity;
    //        this.UnitOfWork.SaveEntitiesAsync();
    //        return retobj;
    //    }
    //}
}