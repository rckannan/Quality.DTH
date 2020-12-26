using Microsoft.Extensions.Logging;
using Quality.DTH.Queries;
using Quality.DTH.Repository;
using System;
using System.Linq;
using Serilog;
using System.Windows.Forms;

namespace Quality.DTH.Forms
{
    public partial class test : Form
    {
        private readonly IMaster_StockQueries _master_StockQueries;
        private readonly IMaster_StockRepository _StockRepository;
        public test(IMaster_StockQueries master_StockQueries, IMaster_StockRepository stockRepository)
        {
            InitializeComponent();
            _master_StockQueries = master_StockQueries;
            _StockRepository = stockRepository;
        }

        private void test_Load(object sender, EventArgs e)
        {
            var stock = new Master_Stock(0, "new stock", "No", "wire", 1002, 100);
            _StockRepository.Add(stock);

            var stock_list = _master_StockQueries.GetMaster_StockItems().Result;
            dataGridView1.DataSource = stock_list;
        }
    }
}
