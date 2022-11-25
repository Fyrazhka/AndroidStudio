using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3K
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnMechanic_Click(object sender, EventArgs e)
        {
            Mechanic newForm = new Mechanic();
            newForm.Show();
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            Client newForm = new Client();
            newForm.Show();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Admin newForm = new Admin();
            newForm.Show();
        }
    }
}
