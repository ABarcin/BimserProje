
namespace BimserProje
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnCurrencyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cForexBuying = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cForexSelling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBanknoteBuying = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBanknoteSelling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cCurrencyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCurrencysd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.todayMaxBuying = new System.Windows.Forms.Label();
            this.todayMinBuying = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbCurrencyName = new System.Windows.Forms.TextBox();
            this.tbQuentity = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuentity = new System.Windows.Forms.Label();
            this.lblMaxName = new System.Windows.Forms.Label();
            this.lblMinName = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(668, 385);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCurrencyCode,
            this.cCurrency,
            this.cForexBuying,
            this.cForexSelling,
            this.cBanknoteBuying,
            this.cBanknoteSelling});
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(650, 289);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // columnCurrencyCode
            // 
            this.columnCurrencyCode.HeaderText = "CurrencyCode";
            this.columnCurrencyCode.Name = "columnCurrencyCode";
            // 
            // cCurrency
            // 
            this.cCurrency.HeaderText = "Currency";
            this.cCurrency.Name = "cCurrency";
            // 
            // cForexBuying
            // 
            this.cForexBuying.HeaderText = "ForexBuying";
            this.cForexBuying.Name = "cForexBuying";
            // 
            // cForexSelling
            // 
            this.cForexSelling.HeaderText = "ForexSelling";
            this.cForexSelling.Name = "cForexSelling";
            // 
            // cBanknoteBuying
            // 
            this.cBanknoteBuying.HeaderText = "BanknoteBuying";
            this.cBanknoteBuying.Name = "cBanknoteBuying";
            // 
            // cBanknoteSelling
            // 
            this.cBanknoteSelling.HeaderText = "BanknoteSelling";
            this.cBanknoteSelling.Name = "cBanknoteSelling";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCurrencyCode,
            this.cCurrencysd,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.Location = new System.Drawing.Point(12, 385);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(650, 289);
            this.dataGridView2.TabIndex = 5;
            // 
            // cCurrencyCode
            // 
            this.cCurrencyCode.HeaderText = "CurrencyCode";
            this.cCurrencyCode.Name = "cCurrencyCode";
            // 
            // cCurrencysd
            // 
            this.cCurrencysd.HeaderText = "Currency";
            this.cCurrencysd.Name = "cCurrencysd";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ForexBuying";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ForexSelling";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "BanknoteBuying";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "BanknoteSelling";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(290, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Today";
            // 
            // todayMaxBuying
            // 
            this.todayMaxBuying.AutoSize = true;
            this.todayMaxBuying.Location = new System.Drawing.Point(683, 107);
            this.todayMaxBuying.Name = "todayMaxBuying";
            this.todayMaxBuying.Size = new System.Drawing.Size(106, 15);
            this.todayMaxBuying.TabIndex = 14;
            this.todayMaxBuying.Text = "MaxCurrencyValue";
            // 
            // todayMinBuying
            // 
            this.todayMinBuying.AutoSize = true;
            this.todayMinBuying.Location = new System.Drawing.Point(837, 107);
            this.todayMinBuying.Name = "todayMinBuying";
            this.todayMinBuying.Size = new System.Drawing.Size(104, 15);
            this.todayMinBuying.TabIndex = 17;
            this.todayMinBuying.Text = "MinCurrencyValue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Max Currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(837, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Min Currency";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(837, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbCurrencyName
            // 
            this.tbCurrencyName.Location = new System.Drawing.Point(689, 176);
            this.tbCurrencyName.Name = "tbCurrencyName";
            this.tbCurrencyName.Size = new System.Drawing.Size(100, 23);
            this.tbCurrencyName.TabIndex = 22;
            // 
            // tbQuentity
            // 
            this.tbQuentity.Location = new System.Drawing.Point(689, 205);
            this.tbQuentity.Name = "tbQuentity";
            this.tbQuentity.Size = new System.Drawing.Size(100, 23);
            this.tbQuentity.TabIndex = 23;
            this.tbQuentity.TextChanged += new System.EventHandler(this.tbQuentity_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(809, 179);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 24;
            this.lblPrice.Text = "Price";
            // 
            // lblQuentity
            // 
            this.lblQuentity.AutoSize = true;
            this.lblQuentity.Location = new System.Drawing.Point(809, 212);
            this.lblQuentity.Name = "lblQuentity";
            this.lblQuentity.Size = new System.Drawing.Size(53, 15);
            this.lblQuentity.TabIndex = 25;
            this.lblQuentity.Text = "Quantity";
            // 
            // lblMaxName
            // 
            this.lblMaxName.AutoSize = true;
            this.lblMaxName.Location = new System.Drawing.Point(683, 73);
            this.lblMaxName.Name = "lblMaxName";
            this.lblMaxName.Size = new System.Drawing.Size(110, 15);
            this.lblMaxName.TabIndex = 26;
            this.lblMaxName.Text = "MaxCurrencyName";
            // 
            // lblMinName
            // 
            this.lblMinName.AutoSize = true;
            this.lblMinName.Location = new System.Drawing.Point(837, 73);
            this.lblMinName.Name = "lblMinName";
            this.lblMinName.Size = new System.Drawing.Size(108, 15);
            this.lblMinName.TabIndex = 27;
            this.lblMinName.Text = "MinCurrencyName";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(689, 251);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(874, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "UnitPrice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(290, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "History";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 791);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblMinName);
            this.Controls.Add(this.lblMaxName);
            this.Controls.Add(this.lblQuentity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbQuentity);
            this.Controls.Add(this.tbCurrencyName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.todayMinBuying);
            this.Controls.Add(this.todayMaxBuying);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCurrencyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cForexBuying;
        private System.Windows.Forms.DataGridViewTextBoxColumn cForexSelling;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBanknoteBuying;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBanknoteSelling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCurrencyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCurrencysd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label todayMaxBuying;
        private System.Windows.Forms.Label todayMinBuying;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbCurrencyName;
        private System.Windows.Forms.TextBox tbQuentity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuentity;
        private System.Windows.Forms.Label lblMaxName;
        private System.Windows.Forms.Label lblMinName;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

