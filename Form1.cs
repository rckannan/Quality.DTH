using Microsoft.Extensions.Logging;
using Quality.DTH.Queries;
using Quality.DTH.Repository;
using System;
using Autofac;
using Serilog;
using System.Windows.Forms;

namespace Quality.DTH
{
    public partial class Form1 : Form
    {
        private readonly ICustomerRepository _customerRepository; 
        private readonly ICustomerQueries _customerQueries;

        public Form1(ICustomerRepository customerRepository, ICustomerQueries customerQueries)
        {
            InitializeComponent();
            this._customerRepository = customerRepository  ; 
            _customerQueries = customerQueries;
        }

        public Form1()
        {
            InitializeComponent();
            this._customerRepository = ContainerProvider.Container.Resolve<ICustomerRepository>(); 
            _customerQueries = ContainerProvider.Container.Resolve<ICustomerQueries>();
        }

        private void cmdLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                var repo = _customerQueries.GetCustomersAsync().Result;
                Log.Information("Logger form test");
                txtData.Text =  $" {repo.FullName}    :    {repo.DOB} "  ;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
