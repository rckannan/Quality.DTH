using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quality.DTH.Forms
{
    public partial class Stock_Transactions : Form
    {
       
        public Stock_Transactions()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {
            cmb_TransType.DataSource = Enum.GetValues(typeof(enumBase.Transtype));
            cmb_StockType.DataSource = Enum.GetValues(typeof(enumBase.StockType));
        }

        private void Stock_Transactions_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
