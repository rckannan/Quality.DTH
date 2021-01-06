
namespace Quality.DTH.Forms
{
    partial class Stock_Transactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Comments = new System.Windows.Forms.TextBox();
            this.lbl_RefNo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.but_Reset = new FontAwesome.Sharp.IconButton();
            this.but_Move = new FontAwesome.Sharp.IconButton();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this._sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._stock_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._qty_serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_Add = new FontAwesome.Sharp.IconButton();
            this.cmb_Q_S = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Stock = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_StockType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_ToDealer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_FromDealer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_TransType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.but_COMISP = new FontAwesome.Sharp.IconButton();
            this.but_ISPDEL = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.but_ISPDEL);
            this.panel1.Controls.Add(this.but_COMISP);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_Comments);
            this.panel1.Controls.Add(this.lbl_RefNo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.but_Reset);
            this.panel1.Controls.Add(this.but_Move);
            this.panel1.Controls.Add(this.dg1);
            this.panel1.Controls.Add(this.but_Add);
            this.panel1.Controls.Add(this.cmb_Q_S);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmb_Stock);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmb_StockType);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_ToDealer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_FromDealer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmb_TransType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtPicker);
            this.panel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(47, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 737);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(492, 501);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Comments :";
            // 
            // txt_Comments
            // 
            this.txt_Comments.Location = new System.Drawing.Point(592, 498);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(520, 65);
            this.txt_Comments.TabIndex = 21;
            // 
            // lbl_RefNo
            // 
            this.lbl_RefNo.AutoSize = true;
            this.lbl_RefNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_RefNo.Location = new System.Drawing.Point(163, 107);
            this.lbl_RefNo.Name = "lbl_RefNo";
            this.lbl_RefNo.Size = new System.Drawing.Size(45, 19);
            this.lbl_RefNo.TabIndex = 20;
            this.lbl_RefNo.Text = "1001";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(23, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ref. No :";
            // 
            // but_Reset
            // 
            this.but_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Reset.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_Reset.ForeColor = System.Drawing.Color.Gainsboro;
            this.but_Reset.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.but_Reset.IconColor = System.Drawing.Color.LightGray;
            this.but_Reset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.but_Reset.IconSize = 30;
            this.but_Reset.Location = new System.Drawing.Point(757, 582);
            this.but_Reset.Name = "but_Reset";
            this.but_Reset.Size = new System.Drawing.Size(167, 44);
            this.but_Reset.TabIndex = 18;
            this.but_Reset.Text = "Reset";
            this.but_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_Reset.UseVisualStyleBackColor = true;
            // 
            // but_Move
            // 
            this.but_Move.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Move.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_Move.ForeColor = System.Drawing.Color.Gainsboro;
            this.but_Move.IconChar = FontAwesome.Sharp.IconChar.TruckLoading;
            this.but_Move.IconColor = System.Drawing.Color.LightGray;
            this.but_Move.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.but_Move.IconSize = 30;
            this.but_Move.Location = new System.Drawing.Point(945, 582);
            this.but_Move.Name = "but_Move";
            this.but_Move.Size = new System.Drawing.Size(167, 44);
            this.but_Move.TabIndex = 17;
            this.but_Move.Text = "Move";
            this.but_Move.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Move.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_Move.UseVisualStyleBackColor = true;
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(129)))), ((int)(((byte)(139)))));
            this.dg1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._sno,
            this._item_name,
            this._stock_type,
            this._qty_serial});
            this.dg1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dg1.Location = new System.Drawing.Point(492, 107);
            this.dg1.MinimumSize = new System.Drawing.Size(620, 0);
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg1.RowTemplate.Height = 25;
            this.dg1.Size = new System.Drawing.Size(620, 381);
            this.dg1.TabIndex = 16;
            // 
            // _sno
            // 
            this._sno.HeaderText = "S.No";
            this._sno.MinimumWidth = 50;
            this._sno.Name = "_sno";
            this._sno.ReadOnly = true;
            // 
            // _item_name
            // 
            this._item_name.HeaderText = "Item Name";
            this._item_name.MinimumWidth = 150;
            this._item_name.Name = "_item_name";
            this._item_name.ReadOnly = true;
            // 
            // _stock_type
            // 
            this._stock_type.HeaderText = "Stock Type";
            this._stock_type.MinimumWidth = 100;
            this._stock_type.Name = "_stock_type";
            this._stock_type.ReadOnly = true;
            // 
            // _qty_serial
            // 
            this._qty_serial.HeaderText = "Quantity / Serial No";
            this._qty_serial.MinimumWidth = 200;
            this._qty_serial.Name = "_qty_serial";
            this._qty_serial.ReadOnly = true;
            // 
            // but_Add
            // 
            this.but_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Add.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_Add.ForeColor = System.Drawing.Color.Gainsboro;
            this.but_Add.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.but_Add.IconColor = System.Drawing.Color.LightGray;
            this.but_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.but_Add.IconSize = 30;
            this.but_Add.Location = new System.Drawing.Point(163, 513);
            this.but_Add.Name = "but_Add";
            this.but_Add.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.but_Add.Size = new System.Drawing.Size(285, 44);
            this.but_Add.TabIndex = 15;
            this.but_Add.Text = "Add";
            this.but_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_Add.UseVisualStyleBackColor = true;
            // 
            // cmb_Q_S
            // 
            this.cmb_Q_S.FormattingEnabled = true;
            this.cmb_Q_S.Location = new System.Drawing.Point(163, 461);
            this.cmb_Q_S.Name = "cmb_Q_S";
            this.cmb_Q_S.Size = new System.Drawing.Size(285, 27);
            this.cmb_Q_S.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(21, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Qty / Serial";
            // 
            // cmb_Stock
            // 
            this.cmb_Stock.FormattingEnabled = true;
            this.cmb_Stock.Location = new System.Drawing.Point(163, 411);
            this.cmb_Stock.Name = "cmb_Stock";
            this.cmb_Stock.Size = new System.Drawing.Size(285, 27);
            this.cmb_Stock.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(24, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Stock";
            // 
            // cmb_StockType
            // 
            this.cmb_StockType.FormattingEnabled = true;
            this.cmb_StockType.Location = new System.Drawing.Point(163, 359);
            this.cmb_StockType.Name = "cmb_StockType";
            this.cmb_StockType.Size = new System.Drawing.Size(285, 27);
            this.cmb_StockType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(24, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stock Type";
            // 
            // cmb_ToDealer
            // 
            this.cmb_ToDealer.FormattingEnabled = true;
            this.cmb_ToDealer.Location = new System.Drawing.Point(163, 307);
            this.cmb_ToDealer.Name = "cmb_ToDealer";
            this.cmb_ToDealer.Size = new System.Drawing.Size(285, 27);
            this.cmb_ToDealer.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(21, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stock To";
            // 
            // cmb_FromDealer
            // 
            this.cmb_FromDealer.FormattingEnabled = true;
            this.cmb_FromDealer.Location = new System.Drawing.Point(163, 255);
            this.cmb_FromDealer.Name = "cmb_FromDealer";
            this.cmb_FromDealer.Size = new System.Drawing.Size(285, 27);
            this.cmb_FromDealer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(21, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stock From";
            // 
            // cmb_TransType
            // 
            this.cmb_TransType.FormattingEnabled = true;
            this.cmb_TransType.Location = new System.Drawing.Point(163, 203);
            this.cmb_TransType.Name = "cmb_TransType";
            this.cmb_TransType.Size = new System.Drawing.Size(285, 27);
            this.cmb_TransType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(21, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transaction Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(163, 151);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(285, 27);
            this.dtPicker.TabIndex = 0;
            // 
            // but_COMISP
            // 
            this.but_COMISP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_COMISP.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_COMISP.ForeColor = System.Drawing.Color.Gainsboro;
            this.but_COMISP.IconChar = FontAwesome.Sharp.IconChar.ArrowsAltH;
            this.but_COMISP.IconColor = System.Drawing.Color.LightGray;
            this.but_COMISP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.but_COMISP.IconSize = 30;
            this.but_COMISP.Location = new System.Drawing.Point(24, 23);
            this.but_COMISP.Name = "but_COMISP";
            this.but_COMISP.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.but_COMISP.Size = new System.Drawing.Size(246, 44);
            this.but_COMISP.TabIndex = 23;
            this.but_COMISP.Text = "COMPANY <> ISP";
            this.but_COMISP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_COMISP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_COMISP.UseVisualStyleBackColor = true;
            // 
            // but_ISPDEL
            // 
            this.but_ISPDEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_ISPDEL.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_ISPDEL.ForeColor = System.Drawing.Color.Gainsboro;
            this.but_ISPDEL.IconChar = FontAwesome.Sharp.IconChar.ArrowsAltH;
            this.but_ISPDEL.IconColor = System.Drawing.Color.LightGray;
            this.but_ISPDEL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.but_ISPDEL.IconSize = 30;
            this.but_ISPDEL.Location = new System.Drawing.Point(285, 23);
            this.but_ISPDEL.Name = "but_ISPDEL";
            this.but_ISPDEL.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.but_ISPDEL.Size = new System.Drawing.Size(246, 44);
            this.but_ISPDEL.TabIndex = 24;
            this.but_ISPDEL.Text = "ISP <> DEALER";
            this.but_ISPDEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_ISPDEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_ISPDEL.UseVisualStyleBackColor = true;
            // 
            // Stock_Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1226, 813);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Stock_Transactions";
            this.Text = "Stock Transactions";
            this.Load += new System.EventHandler(this.Stock_Transactions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_ToDealer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_FromDealer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_TransType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.ComboBox cmb_Stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_StockType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Q_S;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn _item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _stock_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn _qty_serial;
        private FontAwesome.Sharp.IconButton but_Add;
        private FontAwesome.Sharp.IconButton but_Move;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Comments;
        private System.Windows.Forms.Label lbl_RefNo;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton but_Reset;
        private FontAwesome.Sharp.IconButton but_ISPDEL;
        private FontAwesome.Sharp.IconButton but_COMISP;
    }
}