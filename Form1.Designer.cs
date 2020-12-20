
namespace Quality.DTH
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdLoadData = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdLoadData
            // 
            this.cmdLoadData.Location = new System.Drawing.Point(91, 67);
            this.cmdLoadData.Name = "cmdLoadData";
            this.cmdLoadData.Size = new System.Drawing.Size(94, 29);
            this.cmdLoadData.TabIndex = 0;
            this.cmdLoadData.Text = "Load";
            this.cmdLoadData.UseVisualStyleBackColor = true;
            this.cmdLoadData.Click += new System.EventHandler(this.cmdLoadData_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(91, 124);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(497, 125);
            this.txtData.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.cmdLoadData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLoadData;
        private System.Windows.Forms.TextBox txtData;
    }
}

