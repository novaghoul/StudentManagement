namespace Project
{
    partial class fDebt
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPayResult = new System.Windows.Forms.Button();
            this.dtpkPayDateTwo = new System.Windows.Forms.DateTimePicker();
            this.dtpkPayDateOne = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvPay = new System.Windows.Forms.DataGridView();
            this.txbSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvDebt = new System.Windows.Forms.DataGridView();
            this.dtpkDebtDateOne = new System.Windows.Forms.DateTimePicker();
            this.dtpkDebtDateTwo = new System.Windows.Forms.DateTimePicker();
            this.btnDebtResult = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPay)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDebt)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 628);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(849, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thanh toán";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txbSum);
            this.panel3.Controls.Add(this.btnPayResult);
            this.panel3.Controls.Add(this.dtpkPayDateTwo);
            this.panel3.Controls.Add(this.dtpkPayDateOne);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(836, 576);
            this.panel3.TabIndex = 1;
            // 
            // btnPayResult
            // 
            this.btnPayResult.Location = new System.Drawing.Point(219, 3);
            this.btnPayResult.Name = "btnPayResult";
            this.btnPayResult.Size = new System.Drawing.Size(113, 31);
            this.btnPayResult.TabIndex = 2;
            this.btnPayResult.Text = "Kết quả";
            this.btnPayResult.UseVisualStyleBackColor = true;
            // 
            // dtpkPayDateTwo
            // 
            this.dtpkPayDateTwo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkPayDateTwo.Location = new System.Drawing.Point(338, 3);
            this.dtpkPayDateTwo.Name = "dtpkPayDateTwo";
            this.dtpkPayDateTwo.Size = new System.Drawing.Size(210, 32);
            this.dtpkPayDateTwo.TabIndex = 1;
            this.dtpkPayDateTwo.Value = new System.DateTime(2018, 1, 1, 21, 31, 0, 0);
            // 
            // dtpkPayDateOne
            // 
            this.dtpkPayDateOne.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkPayDateOne.Location = new System.Drawing.Point(3, 3);
            this.dtpkPayDateOne.Name = "dtpkPayDateOne";
            this.dtpkPayDateOne.Size = new System.Drawing.Size(210, 32);
            this.dtpkPayDateOne.TabIndex = 1;
            this.dtpkPayDateOne.Value = new System.DateTime(2016, 1, 1, 21, 31, 0, 0);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvPay);
            this.panel4.Location = new System.Drawing.Point(3, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(830, 532);
            this.panel4.TabIndex = 0;
            // 
            // dtgvPay
            // 
            this.dtgvPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPay.Location = new System.Drawing.Point(4, 4);
            this.dtgvPay.Name = "dtgvPay";
            this.dtgvPay.RowTemplate.Height = 24;
            this.dtgvPay.Size = new System.Drawing.Size(823, 525);
            this.dtgvPay.TabIndex = 0;
            // 
            // txbSum
            // 
            this.txbSum.Location = new System.Drawing.Point(624, 2);
            this.txbSum.Name = "txbSum";
            this.txbSum.ReadOnly = true;
            this.txbSum.Size = new System.Drawing.Size(206, 32);
            this.txbSum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(849, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Công nợ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvDebt);
            this.panel2.Location = new System.Drawing.Point(3, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 532);
            this.panel2.TabIndex = 0;
            // 
            // dtgvDebt
            // 
            this.dtgvDebt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDebt.Location = new System.Drawing.Point(4, 4);
            this.dtgvDebt.Name = "dtgvDebt";
            this.dtgvDebt.RowTemplate.Height = 24;
            this.dtgvDebt.Size = new System.Drawing.Size(823, 525);
            this.dtgvDebt.TabIndex = 0;
            // 
            // dtpkDebtDateOne
            // 
            this.dtpkDebtDateOne.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDebtDateOne.Location = new System.Drawing.Point(3, 3);
            this.dtpkDebtDateOne.Name = "dtpkDebtDateOne";
            this.dtpkDebtDateOne.Size = new System.Drawing.Size(263, 32);
            this.dtpkDebtDateOne.TabIndex = 1;
            this.dtpkDebtDateOne.Value = new System.DateTime(2016, 1, 1, 21, 31, 0, 0);
            // 
            // dtpkDebtDateTwo
            // 
            this.dtpkDebtDateTwo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDebtDateTwo.Location = new System.Drawing.Point(570, 3);
            this.dtpkDebtDateTwo.Name = "dtpkDebtDateTwo";
            this.dtpkDebtDateTwo.Size = new System.Drawing.Size(263, 32);
            this.dtpkDebtDateTwo.TabIndex = 1;
            this.dtpkDebtDateTwo.Value = new System.DateTime(2018, 1, 1, 21, 31, 0, 0);
            // 
            // btnDebtResult
            // 
            this.btnDebtResult.Location = new System.Drawing.Point(364, 6);
            this.btnDebtResult.Name = "btnDebtResult";
            this.btnDebtResult.Size = new System.Drawing.Size(113, 31);
            this.btnDebtResult.TabIndex = 2;
            this.btnDebtResult.Text = "Kết quả";
            this.btnDebtResult.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDebtResult);
            this.panel1.Controls.Add(this.dtpkDebtDateTwo);
            this.panel1.Controls.Add(this.dtpkDebtDateOne);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 576);
            this.panel1.TabIndex = 0;
            // 
            // fDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fDebt";
            this.Text = "fDebt";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPay)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDebt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPayResult;
        private System.Windows.Forms.DateTimePicker dtpkPayDateTwo;
        private System.Windows.Forms.DateTimePicker dtpkPayDateOne;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvPay;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDebtResult;
        private System.Windows.Forms.DateTimePicker dtpkDebtDateTwo;
        private System.Windows.Forms.DateTimePicker dtpkDebtDateOne;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvDebt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSum;
    }
}