
namespace Quality.DTH.Forms
{
    partial class Stock_Master
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_stockGrid = new System.Windows.Forms.DataGridView();
            this.stock_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_stockType = new System.Windows.Forms.ComboBox();
            this.txt_stockName = new System.Windows.Forms.TextBox();
            this.but_add = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_unit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_details = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_stockGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_stockGrid
            // 
            this.dg_stockGrid.AllowUserToAddRows = false;
            this.dg_stockGrid.AllowUserToDeleteRows = false;
            this.dg_stockGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_stockGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_stockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_stockGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stock_name,
            this.stock_type,
            this.stock_unit,
            this.stock_cost,
            this.stock_detail});
            this.dg_stockGrid.Location = new System.Drawing.Point(42, 196);
            this.dg_stockGrid.Margin = new System.Windows.Forms.Padding(2);
            this.dg_stockGrid.Name = "dg_stockGrid";
            this.dg_stockGrid.ReadOnly = true;
            this.dg_stockGrid.RowTemplate.Height = 25;
            this.dg_stockGrid.Size = new System.Drawing.Size(546, 165);
            this.dg_stockGrid.TabIndex = 0;
            // 
            // stock_name
            // 
            this.stock_name.DataPropertyName = "stock_name";
            this.stock_name.HeaderText = "Stock Name";
            this.stock_name.MinimumWidth = 150;
            this.stock_name.Name = "stock_name";
            this.stock_name.ReadOnly = true;
            // 
            // stock_type
            // 
            this.stock_type.DataPropertyName = "stock_type";
            this.stock_type.HeaderText = "Type";
            this.stock_type.MinimumWidth = 80;
            this.stock_type.Name = "stock_type";
            this.stock_type.ReadOnly = true;
            // 
            // stock_unit
            // 
            this.stock_unit.DataPropertyName = "stock_unit";
            this.stock_unit.HeaderText = "Unit";
            this.stock_unit.MinimumWidth = 40;
            this.stock_unit.Name = "stock_unit";
            this.stock_unit.ReadOnly = true;
            // 
            // stock_cost
            // 
            this.stock_cost.DataPropertyName = "stock_cost";
            this.stock_cost.HeaderText = "Cost";
            this.stock_cost.MinimumWidth = 40;
            this.stock_cost.Name = "stock_cost";
            this.stock_cost.ReadOnly = true;
            // 
            // stock_detail
            // 
            this.stock_detail.DataPropertyName = "stock_detail";
            this.stock_detail.HeaderText = "Details";
            this.stock_detail.MinimumWidth = 150;
            this.stock_detail.Name = "stock_detail";
            this.stock_detail.ReadOnly = true;
            // 
            // cmb_stockType
            // 
            this.cmb_stockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_stockType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_stockType.FormattingEnabled = true;
            this.cmb_stockType.Location = new System.Drawing.Point(42, 50);
            this.cmb_stockType.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_stockType.Name = "cmb_stockType";
            this.cmb_stockType.Size = new System.Drawing.Size(200, 23);
            this.cmb_stockType.TabIndex = 1;
            // 
            // txt_stockName
            // 
            this.txt_stockName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_stockName.Location = new System.Drawing.Point(257, 51);
            this.txt_stockName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_stockName.Name = "txt_stockName";
            this.txt_stockName.Size = new System.Drawing.Size(196, 23);
            this.txt_stockName.TabIndex = 2;
            // 
            // but_add
            // 
            this.but_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_add.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_add.ForeColor = System.Drawing.Color.Gainsboro;
            this.but_add.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.but_add.IconColor = System.Drawing.Color.LightGray;
            this.but_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.but_add.IconSize = 20;
            this.but_add.Location = new System.Drawing.Point(472, 148);
            this.but_add.Margin = new System.Windows.Forms.Padding(2);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(116, 40);
            this.but_add.TabIndex = 18;
            this.but_add.Text = "Add";
            this.but_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Stock Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(257, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Stock Name";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_cost);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_details);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_unit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.but_add);
            this.panel1.Controls.Add(this.txt_stockName);
            this.panel1.Controls.Add(this.cmb_stockType);
            this.panel1.Controls.Add(this.dg_stockGrid);
            this.panel1.Location = new System.Drawing.Point(133, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 393);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(472, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Unit";
            // 
            // txt_unit
            // 
            this.txt_unit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_unit.Location = new System.Drawing.Point(472, 51);
            this.txt_unit.Margin = new System.Windows.Forms.Padding(2);
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.Size = new System.Drawing.Size(116, 23);
            this.txt_unit.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(162, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Details";
            // 
            // txt_details
            // 
            this.txt_details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_details.Location = new System.Drawing.Point(162, 115);
            this.txt_details.Margin = new System.Windows.Forms.Padding(2);
            this.txt_details.Name = "txt_details";
            this.txt_details.Size = new System.Drawing.Size(426, 23);
            this.txt_details.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(42, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cost";
            // 
            // txt_cost
            // 
            this.txt_cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cost.Location = new System.Drawing.Point(42, 115);
            this.txt_cost.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(103, 23);
            this.txt_cost.TabIndex = 25;
            // 
            // Stock_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(923, 586);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Stock_Master";
            this.Text = "Stock_Master";
            this.Load += new System.EventHandler(this.Stock_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_stockGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_stockGrid;
        private System.Windows.Forms.ComboBox cmb_stockType;
        private System.Windows.Forms.TextBox txt_stockName;
        private FontAwesome.Sharp.IconButton but_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_detail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_details;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_unit;
    }
}