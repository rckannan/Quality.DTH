using Microsoft.Extensions.Logging;
using Quality.DTH.Queries;
using Quality.DTH.Repository;
using System;
using System.Linq;
using Serilog;
using System.Windows.Forms;

namespace Quality.DTH.Forms
{
    public partial class Dealers : Form
    {
        private readonly IMaster_StockQueries _master_StockQueries;
        private readonly IMaster_StockRepository _StockRepository;
        public Dealers(IMaster_StockQueries master_StockQueries, IMaster_StockRepository stockRepository)
        {
            InitializeComponent();
            _master_StockQueries = master_StockQueries;
            _StockRepository = stockRepository;
        }

    }
}
