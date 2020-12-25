using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Quality.DTH.Repository
{
    public interface IDealerRepository : IRepository<Dealer>
    {
        Dealer Add(Dealer buyer);
        Dealer Update(Dealer buyer);
        Task<Dealer> FindAsync(Int64 Id);
    }

    public class DealerRepository
        : IDealerRepository
    {
        private readonly COREAPIContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public DealerRepository(COREAPIContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Dealer Add(Dealer dealer)
        {
            var retobj = _context.Dealers .Add(dealer).Entity;
            this.UnitOfWork.SaveEntitiesAsync();
            return retobj;
        }

        public Dealer Update(Dealer dealer)
        {
            var retobj = _context.Dealers.Update(dealer).Entity;
            this.UnitOfWork.SaveEntitiesAsync();
            return retobj; 
        }

        public Dealer Delete(Dealer item)
        {
            var retobj = _context.Dealers.Remove(item).Entity;
             
            this.UnitOfWork.SaveEntitiesAsync();
            return retobj;
        }

        public async Task<Dealer> FindAsync(Int64 identity)
        {
            var buyer = await _context.Dealers
                .Where(b => b.Idbase == identity)
                .SingleOrDefaultAsync();

            return buyer;
        }

    }
}