using System.Windows.Forms;
using Quality.DTH.Queries;
using Quality.DTH.Repository;
using System;
using System.Linq;
using Quality.DTH.Infra;

namespace Quality.DTH.Forms
{
    public partial class Stock_Master : BaseForm
    {
        private readonly IMaster_StockQueries _master_StockQueries;
        private readonly IMaster_StockRepository _master_StockRepository;
        private BindingSource dataSource;

        private Master_StockDTO selected_master; 
        public Master_StockDTO _selected_master { get => selected_master;
            set => SetField(ref selected_master, value); }

        int id = 0;

        public Stock_Master(IMaster_StockQueries master_StockQueries, IMaster_StockRepository master_StockRepository)
        {
            InitializeComponent();
            _master_StockQueries = master_StockQueries;
            _master_StockRepository = master_StockRepository;
        }
        
        private void Load_Data()
        {
            
        }
        private void Load_Grid()
        {
            cmb_stockType.DataSource = System.Enum.GetValues(typeof(enumBase.StockType));
            

            var stock_list = _master_StockQueries.GetMaster_StockItems().Result;  
            dg_stockGrid.DataSource = stock_list;
            dg_stockGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _selected_master = stock_list.FirstOrDefault();
        }

        private void BindCtrl()
        {
            dataSource = new BindingSource { DataSource = typeof(Master_StockDTO) };
            //ds_cmb_stockType = new BindingSource { DataSource = typeof(enumBase.StockTypes) };

            //cmb_stockType.DataSource = new enumBase.StockTypes();
            //cmb_stockType.DisplayMember = "stock_type";
            //cmb_stockType.ValueMember = "stock_typeid";

            txtid.DataBindings.Add("Text",
                               dataSource,
                               "Idbase",
                               false,
                               DataSourceUpdateMode.OnPropertyChanged);

            txt_stockName.DataBindings.Add("Text",
                                dataSource,
                                "stock_name",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);
            txt_unit.DataBindings.Add("Text",
                                dataSource,
                                "stock_unit",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);
            txt_cost.DataBindings.Add("Text",
                                dataSource,
                                "stock_cost",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);
            txt_details.DataBindings.Add("Text",
                                dataSource,
                                "stock_detail",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            //cmb_stockType.DataBindings.Add("SelectedValue",
            //                    dataSource,
            //                    "stock_type",
            //                    false,
            //                    DataSourceUpdateMode.OnPropertyChanged);
        }
        private void Stock_Master_Load(object sender, System.EventArgs e)
        {
            BindCtrl();
            Load_Data();
            Load_Grid();
            
        }

        private void But_add_Click(object sender, System.EventArgs e)
        {
            try
            {
                short stockType = (short)Enum.Parse(typeof(enumBase.StockType), cmb_stockType.Text);
                if (!decimal.TryParse(this.txt_cost.Text, out decimal _cos))
                {
                    _cos = 0;
                }
                var stock = new Master_Stock(id, txt_stockName.Text, txt_unit.Text, txt_details.Text, stockType, _cos); // Add Stock Type
                if (id == 0)
                    _master_StockRepository.Add(stock);
                else
                    _master_StockRepository.Update(stock);
                Load_Grid();
                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }

        private void ResetFields()
        {
            txt_stockName.Text = "";
            txt_unit.Text = "";
            txt_cost.Text = "";
            txt_details.Text = "";
            id = 0;
        }

        private void But_Cancel_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void dg_stockGrid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                //_selected_master = (Master_StockDTO) dg_stockGrid.CurrentRow.DataBoundItem;
                dataSource.DataSource = (Master_StockDTO)dg_stockGrid.CurrentRow.DataBoundItem;
                if (dg_stockGrid.SelectedRows.Count != 0)
                {
                    cmb_stockType.SelectedIndex = cmb_stockType.FindString(

                        dg_stockGrid.CurrentRow.Cells["stock_type"].FormattedValue.ToString());



                    //txt_stockName.Text = dg_stockGrid.CurrentRow.Cells["stock_name"].FormattedValue.ToString();
                    //txt_unit.Text = dg_stockGrid.CurrentRow.Cells["stock_unit"].FormattedValue.ToString();
                    //txt_cost.Text = dg_stockGrid.CurrentRow.Cells["stock_cost"].FormattedValue.ToString();
                    //txt_details.Text = dg_stockGrid.CurrentRow.Cells["stock_detail"].FormattedValue.ToString();
                    id =Convert.ToInt32( dg_stockGrid.CurrentRow.Cells["Idbase"].FormattedValue);
                }
            }
            if (e.Shift && e.KeyCode == Keys.Delete)
            {
                if (dg_stockGrid.SelectedRows.Count != 0)
                {
                    //Delete Record
                }
            }
        }

        private void dg_stockGrid_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
