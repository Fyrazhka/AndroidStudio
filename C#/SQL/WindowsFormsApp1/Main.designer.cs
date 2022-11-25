namespace Lab_3K
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.BtnClient = new System.Windows.Forms.Button();
            this.BtnMechanic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BackColor = System.Drawing.Color.Silver;
            this.BtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdmin.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.BtnAdmin.Location = new System.Drawing.Point(66, 229);
            this.BtnAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(280, 35);
            this.BtnAdmin.TabIndex = 0;
            this.BtnAdmin.Text = "Admin";
            this.BtnAdmin.UseVisualStyleBackColor = false;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // BtnClient
            // 
            this.BtnClient.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClient.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.BtnClient.Location = new System.Drawing.Point(66, 187);
            this.BtnClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Size = new System.Drawing.Size(280, 35);
            this.BtnClient.TabIndex = 1;
            this.BtnClient.Text = "Client";
            this.BtnClient.UseVisualStyleBackColor = false;
            this.BtnClient.Click += new System.EventHandler(this.BtnClient_Click);
            // 
            // BtnMechanic
            // 
            this.BtnMechanic.BackColor = System.Drawing.Color.DarkGray;
            this.BtnMechanic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMechanic.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.BtnMechanic.Location = new System.Drawing.Point(66, 271);
            this.BtnMechanic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnMechanic.Name = "BtnMechanic";
            this.BtnMechanic.Size = new System.Drawing.Size(280, 36);
            this.BtnMechanic.TabIndex = 2;
            this.BtnMechanic.Text = "Mechanic";
            this.BtnMechanic.UseVisualStyleBackColor = false;
            this.BtnMechanic.Click += new System.EventHandler(this.BtnMechanic_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(886, 500);
            this.Controls.Add(this.BtnMechanic);
            this.Controls.Add(this.BtnClient);
            this.Controls.Add(this.BtnAdmin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "STO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Button BtnClient;
        private System.Windows.Forms.Button BtnMechanic;
    }
}