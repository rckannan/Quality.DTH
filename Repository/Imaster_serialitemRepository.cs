using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Quality.DTH.Repository
{
    public interface IMaster_serialitemRepository : IRepository<master_serialitem>
    {
        master_serialitem Add(master_serialitem item);
        master_serialitem Update(master_serialitem item);
        Task<Dealer> FindAsync(Int64 Id);
    }

    public class Master_serialitemRepository
        : IMaster_serialitemRepository
    {
        private readonly COREAPIContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public Master_serialitemRepository(COREAPIContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public master_serialitem Add(master_serialitem item)
        {
            var retobj = _context.Master_serialitem .Add(item).Entity;
            this.UnitOfWork.SaveEntitiesAsync();
            return retobj;
        }

        public master_serialitem Update(master_serialitem item)
        {
            var retobj = _context.Master_serialitem.Update(item).Entity;
            this.UnitOfWork.SaveEntitiesAsync();
            return retobj; 
        }

        public master_serialitem Delete(master_serialitem item)
        {
            var retobj = _context.Master_serialitem.Remove(item).Entity;
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