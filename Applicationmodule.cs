using Autofac;
using Quality.DTH.Queries;
using Quality.DTH.Repository;
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

            var types = builder.RegisterAssemblyTypes(typeof(Program).Assembly);
             

        }
    }
}
