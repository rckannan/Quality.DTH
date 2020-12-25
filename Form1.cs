using Microsoft.Extensions.Logging;
using Quality.DTH.Queries;
using Quality.DTH.Repository;
using System;
using System.Linq;
using Serilog;
using System.Windows.Forms;

namespace Quality.DTH
{
    public partial class Form1 : Form
    {
        private readonly ICustomerRepository _customerRepository; 
        private readonly ICustomerQueries _customerQueries;
        private readonly IDealerRepository _dealerRepository;
        private readonly IDealerQueries _dealerQueries;
        private readonly IMaster_StockQueries _master_SerialItemQueries;
        private readonly IMaster_serialitemRepository _master_SerialitemRepository;

        private readonly IMaster_StockQueries _master_StockQueries;
        private readonly IMaster_StockRepository _master_StockRepository;
          
        private readonly IStock_TransRepository _stock_TransRepository;
        private readonly IStock_TransQueries stock_TransQueries;

        public Form1(ICustomerRepository customerRepository, ICustomerQueries customerQueries, IDealerRepository dealerRepository,
            IDealerQueries dealerQueries, IMaster_StockQueries master_SerialItemQueries,
            IMaster_serialitemRepository master_SerialitemRepository, IMaster_StockQueries master_StockQueries = null,
            IMaster_StockRepository master_StockRepository = null, IStock_TransRepository stock_TransRepository = null, IStock_TransQueries stock_TransQueries = null)
        {
            InitializeComponent();
            this._customerRepository = customerRepository;
            _customerQueries = customerQueries;
            this._dealerRepository = dealerRepository;
            _dealerQueries = dealerQueries;
            _master_SerialItemQueries = master_SerialItemQueries;
            _master_SerialitemRepository = master_SerialitemRepository;
            _master_StockQueries = master_StockQueries;
            _master_StockRepository = master_StockRepository;
            _stock_TransRepository = stock_TransRepository;
            this.stock_TransQueries = stock_TransQueries;
        }

        private void cmdLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                //add dealer
                //var dealer = new Dealer(0, DateTime.Now, DateTime.Now, 1, "Dealer A", "new", "address", 1, 1);
                //var outdeal = _dealerRepository.Add(dealer);

                //var dealer2 = new Dealer(0, DateTime.Now, DateTime.Now, 1, "Dealer B", "new", "address", 1, 1);
                //var outdeal2 = _dealerRepository.Add(dealer2);

                //var St_ser = new master_serialitem(0, "Stock Ser A", "Stock Ser A");
                //var outdeal3 = _master_SerialitemRepository.Add(St_ser);

                //var St_ser2 = new master_serialitem(0, "Stock Ser B", "Stock Ser B");
                //var outdeal4 = _master_SerialitemRepository.Add(St_ser2);

                //var mast_stk = new Master_Stock(0, "Stock A", "newA", "stock detao", 0, 100);
                //var outdeal5 = _master_StockRepository.Add(mast_stk);

                //var mast_stkB = new Master_Stock(0, "Stock B", "newA", "stock detao", 0, 100);
                //var outdeal6 = _master_StockRepository.Add(mast_stkB);

                var Dealer_list = _dealerQueries.GetDealers().Result;
                var serial_list = _master_SerialItemQueries.GetMaster_StockItems().Result;
                var stock_list = _master_StockQueries.GetMaster_StockItems().Result;


                var trans_stock = new Stock_Transaction(0, DateTime.Now, DateTime.Now, 100, DateTime.Now,   9, 10,0, 0, 2, 1,2, "notes");

                var outdeal = _stock_TransRepository.Add(trans_stock);
                 var outdeal2 = _stock_TransRepository.FindAsync(19).Result;
                 var repo = stock_TransQueries.GetStock_Tran_list().Result;
                //txtData.Text = $" {repo.FirstOrDefault().stock_name}    :    {repo.FirstOrDefault().stock_detail} ";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
