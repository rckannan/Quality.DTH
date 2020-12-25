using Autofac;
using Quality.DTH.Queries;
using Quality.DTH.Repository;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quality.DTH
{

    public class ApplicationModule
       : Autofac.Module
    {

        public string QueriesConnectionString { get; }

        public ApplicationModule(string qconstr)
        {
            QueriesConnectionString = qconstr;

        }

        protected override void Load(ContainerBuilder builder)
        {

            
            builder.Register(c => new DataQuery(QueriesConnectionString))
                .As<ICustomerQueries>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CustomerRepository>()
                .As<ICustomerRepository>()
                .InstancePerLifetimeScope();

            builder.Register(c => new DealerQueries(QueriesConnectionString))
                .As<IDealerQueries>()
                .InstancePerLifetimeScope();

            builder.RegisterType<DealerRepository>()
                .As<IDealerRepository>()
                .InstancePerLifetimeScope();

            builder.Register(c => new Master_SerialItemQueries(QueriesConnectionString))
                .As<IMaster_SerialItemQueries>()
                .InstancePerLifetimeScope();

            builder.RegisterType<Master_serialitemRepository>()
                .As<IMaster_serialitemRepository>()
                .InstancePerLifetimeScope();

            builder.Register(c => new Master_StockQueries(QueriesConnectionString))
              .As<IMaster_StockQueries>()
              .InstancePerLifetimeScope();

            builder.RegisterType<Master_StockRepository>()
                .As<IMaster_StockRepository>()
                .InstancePerLifetimeScope();

            builder.Register(c => new Stock_TransQueries(QueriesConnectionString))
             .As<IStock_TransQueries>()
             .InstancePerLifetimeScope();

            builder.RegisterType<Stock_TransRepository>()
                .As<IStock_TransRepository>()
                .InstancePerLifetimeScope();

            var types = builder.RegisterAssemblyTypes(typeof(Program).Assembly); 

        }
    }
}
