﻿using Autofac;
using EntityFramework.Exceptions.MySQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Quality.DTH
{
    public class COREAPIContext : DbContext, IUnitOfWork
    {
        private readonly ILoggerFactory _loggerFactory;
        public const string DEFAULT_SCHEMA = "DTH";
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<master_serialitem> Master_serialitem { get; set; } 
        public DbSet<Master_Stock> Master_Stocks { get; set; }

        public DbSet<Stock_Transaction> Stock_Transactions { get; set; }

        //private readonly IMediator _mediator;
        private IDbContextTransaction _currentTransaction;

        public COREAPIContext()
        {
            System.Diagnostics.Debug.WriteLine("COREAPIContext::ctor ->" + this.GetHashCode()); 
        }

        public COREAPIContext(DbContextOptions<COREAPIContext> options, ILoggerFactory loggerFactory = null) : base(options)
        {

            System.Diagnostics.Debug.WriteLine("COREAPIContext::ctor ->" + this.GetHashCode());
            //_loggerFactory = loggerFactory;
        }

        public IDbContextTransaction GetCurrentTransaction() => _currentTransaction;

        public bool HasActiveTransaction => _currentTransaction != null;

        //public COREAPIContext(DbContextOptions<COREAPIContext> options, , IMediator mediator) : base(options)
        //{
        //    //_mediator = mediator ?? throw new ArgumentNullException(nameof(mediator)); 

        //    System.Diagnostics.Debug.WriteLine("COREAPIContext::ctor ->" + this.GetHashCode());
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.ApplyConfiguration(new CustomerEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DealerEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new master_serialitemEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new Master_StockEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new Stock_TransactionEntityTypeConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conf = Program.GetConfiguration(); 
            optionsBuilder
                .UseMySQL(
                    conf["ConnectionString"]).UseLazyLoadingProxies() // <-- enable Lazy Loading
                                                                       .UseLoggerFactory(LoggerFactory.Create(b => b .AddFilter(level => level >= LogLevel.Information   )))
                 .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .EnableSensitiveDataLogging()
                .UseExceptionProcessor().EnableDetailedErrors();
             
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            // Dispatch Domain Events collection. 
            // Choices:
            // A) Right BEFORE committing data (EF SaveChanges) into the DB will make a single transaction including  
            // side effects from the domain event handlers which are using the same DbContext with "InstancePerLifetimeScope" or "scoped" lifetime
            // B) Right AFTER committing data (EF SaveChanges) into the DB will make multiple transactions. 
            // You will need to handle eventual consistency and compensatory actions in case of failures in any of the Handlers. 
            //await _mediator.DispatchDomainEventsAsync(this);

            // After executing this line all the changes (from the Command Handler and Domain Event Handlers) 
            // performed through the DbContext will be committed
            var result = await base.SaveChangesAsync(cancellationToken);

            return true;
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            if (_currentTransaction != null) return null;

            _currentTransaction = await Database.BeginTransactionAsync(IsolationLevel.ReadCommitted);

            return _currentTransaction;
        }

        public async Task CommitTransactionAsync(IDbContextTransaction transaction)
        {
            if (transaction == null) throw new ArgumentNullException(nameof(transaction));
            if (transaction != _currentTransaction) throw new InvalidOperationException($"Transaction {transaction.TransactionId} is not current");

            try
            {
                await SaveChangesAsync();
                transaction.Commit();
            }
            catch
            {
                RollbackTransaction();
                throw;
            }
            finally
            {
                if (_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }
        }

        public void RollbackTransaction()
        {
            try
            {
                _currentTransaction?.Rollback();
            }
            finally
            {
                if (_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }
        }
    }
}
