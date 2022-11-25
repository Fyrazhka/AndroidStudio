
namespace Lab_3K
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCreateRequest = new System.Windows.Forms.Button();
            this.SurnameClient = new System.Windows.Forms.TextBox();
            this.NameClient = new System.Windows.Forms.TextBox();
            this.OtchestvoClient = new System.Windows.Forms.TextBox();
            this.MarkaClient = new System.Windows.Forms.TextBox();
            this.DateClient = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.ResultClient = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.VIN = new System.Windows.Forms.TextBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(66, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lastname";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(66, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firstname";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(66, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(521, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(496, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select the required services:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(71, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 37);
            this.label6.TabIndex = 3;
            this.label6.Text = "Car brand";
            // 
            // BtnCreateRequest
            // 
            this.BtnCreateRequest.BackColor = System.Drawing.Color.White;
            this.BtnCreateRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateRequest.Location = new System.Drawing.Point(67, 328);
            this.BtnCreateRequest.Name = "BtnCreateRequest";
            this.BtnCreateRequest.Size = new System.Drawing.Size(402, 48);
            this.BtnCreateRequest.TabIndex = 5;
            this.BtnCreateRequest.Text = "Make a request";
            this.BtnCreateRequest.UseVisualStyleBackColor = false;
            this.BtnCreateRequest.Click += new System.EventHandler(this.BtnCreateRequest_Click);
            // 
            // SurnameClient
            // 
            this.SurnameClient.BackColor = System.Drawing.Color.White;
            this.SurnameClient.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.SurnameClient.Location = new System.Drawing.Point(231, 105);
            this.SurnameClient.Name = "SurnameClient";
            this.SurnameClient.Size = new System.Drawing.Size(237, 30);
            this.SurnameClient.TabIndex = 6;
            this.SurnameClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameClient_KeyPress);
            // 
            // NameClient
            // 
            this.NameClient.BackColor = System.Drawing.Color.White;
            this.NameClient.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.NameClient.Location = new System.Drawing.Point(231, 148);
            this.NameClient.Name = "NameClient";
            this.NameClient.Size = new System.Drawing.Size(237, 30);
            this.NameClient.TabIndex = 7;
            this.NameClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameClient_KeyPress);
            // 
            // OtchestvoClient
            // 
            this.OtchestvoClient.BackColor = System.Drawing.Color.White;
            this.OtchestvoClient.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.OtchestvoClient.Location = new System.Drawing.Point(231, 191);
            this.OtchestvoClient.Name = "OtchestvoClient";
            this.OtchestvoClient.Size = new System.Drawing.Size(237, 30);
            this.OtchestvoClient.TabIndex = 8;
            this.OtchestvoClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OtchestvoClient_KeyPress);
            // 
            // MarkaClient
            // 
            this.MarkaClient.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.MarkaClient.Location = new System.Drawing.Point(273, 235);
            this.MarkaClient.Name = "MarkaClient";
            this.MarkaClient.Size = new System.Drawing.Size(196, 30);
            this.MarkaClient.TabIndex = 9;
            this.MarkaClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MarkaClient_KeyPress);
            // 
            // DateClient
            // 
            this.DateClient.CustomFormat = "dd /mm/yyyy hh:mm";
            this.DateClient.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.DateClient.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateClient.Location = new System.Drawing.Point(66, 43);
            this.DateClient.Name = "DateClient";
            this.DateClient.Size = new System.Drawing.Size(402, 30);
            this.DateClient.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.checkBox1.Location = new System.Drawing.Point(536, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 26);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Tire fitting";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.White;
            this.checkBox5.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.checkBox5.Location = new System.Drawing.Point(536, 143);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(252, 26);
            this.checkBox5.TabIndex = 19;
            this.checkBox5.Text = "Suspension replacement";
            this.checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.BackColor = System.Drawing.Color.White;
            this.checkBox11.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.checkBox11.Location = new System.Drawing.Point(536, 175);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(296, 26);
            this.checkBox11.TabIndex = 20;
            this.checkBox11.Text = "Engine repair or replacement";
            this.checkBox11.UseVisualStyleBackColor = false;
            // 
            // ResultClient
            // 
            this.ResultClient.AutoSize = true;
            this.ResultClient.BackColor = System.Drawing.Color.White;
            this.ResultClient.Location = new System.Drawing.Point(66, 485);
            this.ResultClient.Name = "ResultClient";
            this.ResultClient.Size = new System.Drawing.Size(86, 30);
            this.ResultClient.TabIndex = 22;
            this.ResultClient.Text = "Price: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(66, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(402, 48);
            this.button1.TabIndex = 23;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "VIN number";
            // 
            // VIN
            // 
            this.VIN.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.VIN.Location = new System.Drawing.Point(273, 280);
            this.VIN.Name = "VIN";
            this.VIN.Size = new System.Drawing.Size(196, 30);
            this.VIN.TabIndex = 25;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.BackColor = System.Drawing.Color.White;
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.checkBox9.Location = new System.Drawing.Point(536, 79);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(144, 26);
            this.checkBox9.TabIndex = 26;
            this.checkBox9.Text = "Consultation";
            this.checkBox9.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(66, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(402, 48);
            this.button2.TabIndex = 27;
            this.button2.Text = "Clear fields";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1037, 770);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VIN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultClient);
            this.Controls.Add(this.DateClient);
            this.Controls.Add(this.NameClient);
            this.Controls.Add(this.OtchestvoClient);
            this.Controls.Add(this.BtnCreateRequest);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SurnameClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MarkaClient);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Client";
            this.Text = "STO (Client)";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCreateRequest;
        private System.Windows.Forms.TextBox SurnameClient;
        private System.Windows.Forms.TextBox NameClient;
        private System.Windows.Forms.TextBox OtchestvoClient;
        private System.Windows.Forms.TextBox MarkaClient;
        private System.Windows.Forms.DateTimePicker DateClient;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.Label ResultClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VIN;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Button button2;
    }
}