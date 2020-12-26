using System.Windows.Forms;
using Quality.DTH.Queries;
using Quality.DTH.Repository;
using System;

namespace Quality.DTH.Forms
{
    public partial class Stock_Master : Form
    {
        private readonly IMaster_StockQueries _master_StockQueries;
        private readonly IMaster_StockRepository _master_StockRepository;

        public Stock_Master(IMaster_StockQueries master_StockQueries, IMaster_StockRepository master_StockRepository)
        {
            InitializeComponent();
            _master_StockQueries = master_StockQueries;
            _master_StockRepository = master_StockRepository;
        }
        
        private void Load_Data()
        {
            cmb_stockType.DataSource = System.Enum.GetValues(typeof(enumBase.StockType));
        }
        private void Load_Grid()
        {
            var stock_list = _master_StockQueries.GetMaster_StockItems().Result;
            dg_stockGrid.DataSource = stock_list;
        }
        private void Stock_Master_Load(object sender, System.EventArgs e)
        {
            Load_Data();
            Load_Grid();
        }

        private void but_add_Click(object sender, System.EventArgs e)
        {
            var stock = new Master_Stock(0, txt_stockName.Text, txt_unit.Text, txt_details.Text, 1001) ; // Add Stock Type
            _master_StockRepository.Add(stock);
            Load_Grid();
        }
    }
}
