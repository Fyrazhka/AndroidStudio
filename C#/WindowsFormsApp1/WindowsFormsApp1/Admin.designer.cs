namespace Lab_3K
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuyDetail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPrice = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_zayvka = new System.Windows.Forms.ListBox();
            this.d_origin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.d_origin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Applications";
            // 
            // BtnBuyDetail
            // 
            this.BtnBuyDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBuyDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuyDetail.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.BtnBuyDetail.Location = new System.Drawing.Point(10, 652);
            this.BtnBuyDetail.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuyDetail.Name = "BtnBuyDetail";
            this.BtnBuyDetail.Size = new System.Drawing.Size(518, 36);
            this.BtnBuyDetail.TabIndex = 5;
            this.BtnBuyDetail.Text = "Buy";
            this.BtnBuyDetail.UseVisualStyleBackColor = false;
            this.BtnBuyDetail.Click += new System.EventHandler(this.BtnBuyDetail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 325);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Storage:";
            // 
            // BtnPrice
            // 
            this.BtnPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrice.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.BtnPrice.Location = new System.Drawing.Point(576, 355);
            this.BtnPrice.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPrice.Name = "BtnPrice";
            this.BtnPrice.Size = new System.Drawing.Size(415, 36);
            this.BtnPrice.TabIndex = 6;
            this.BtnPrice.Text = "Get price";
            this.BtnPrice.UseVisualStyleBackColor = false;
            this.BtnPrice.Click += new System.EventHandler(this.BtnPrice_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnCheck.Location = new System.Drawing.Point(576, 652);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(415, 36);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Print";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(576, 396);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 232);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "- - - - - -  - - - - - - - - - - - Ticket- - - - - - - - - - - - - - -\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_zayvka
            // 
            this.lb_zayvka.FormattingEnabled = true;
            this.lb_zayvka.ItemHeight = 21;
            this.lb_zayvka.Items.AddRange(new object[] {
            " "});
            this.lb_zayvka.Location = new System.Drawing.Point(3, 36);
            this.lb_zayvka.Name = "lb_zayvka";
            this.lb_zayvka.Size = new System.Drawing.Size(1022, 277);
            this.lb_zayvka.TabIndex = 11;
            // 
            // d_origin
            // 
            this.d_origin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d_origin.Location = new System.Drawing.Point(12, 363);
            this.d_origin.MultiSelect = false;
            this.d_origin.Name = "d_origin";
            this.d_origin.RowHeadersWidth = 100;
            this.d_origin.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.d_origin.Size = new System.Drawing.Size(515, 265);
            this.d_origin.TabIndex = 12;
            this.d_origin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.d_origin_CellClick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1037, 695);
            this.Controls.Add(this.d_origin);
            this.Controls.Add(this.lb_zayvka);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.BtnPrice);
            this.Controls.Add(this.BtnBuyDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Admin";
            this.Text = "STO (Admin)";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.d_origin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuyDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPrice;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lb_zayvka;
        private System.Windows.Forms.DataGridView d_origin;
    }
}