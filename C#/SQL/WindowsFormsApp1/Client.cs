using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Lab_3K
{
    
    public partial class Client : Form
    {
        Encoding Encoding1=Encoding.UTF8;
        Encoding Encoding2 = Encoding.Default;

        static bool flag = true;
        public Client()
        {
            InitializeComponent();
            tm = new Timer();
            tm.Tick += new EventHandler(tm_Tick);
            tm.Interval = 10000;
        }
        Timer tm = null;
        int startValue = 999999;
        void select(String request, SqlConnection conn)
        {
            SqlDataReader rdr = null;
            SqlCommand cmdSelect = new SqlCommand(request, conn);

            rdr = cmdSelect.ExecuteReader();

            for (; rdr.Read();)
            {
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    if ($"{rdr[i]}" != "0")
                    {
                        ResultClient.Text = "Price:" + $"{rdr[i]}" + " $";
                        button1.Visible = true;
                    }

                }
            }



            if (rdr != null)
            {
                rdr.Close();
            }
        }
        void tm_Tick(object sender, EventArgs e)
        {
            if (startValue != 0 && OtchestvoClient.Text.Length!=0)
            {
                SqlConnection conn = new SqlConnection
                {
                    ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = library; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"
                };
                conn.Open();
                SqlCommand cmd;

                select($"select price from STO WHERE Phone = {OtchestvoClient.Text}", conn);
                conn.Close();
                startValue--;
            }
        }
        private void Client_Load(object sender, EventArgs e)
        {

        }

        
        private void BtnCreateRequest_Click(object sender, EventArgs e)
        {
            
            string name = NameClient.Text;
            string surname = SurnameClient.Text;
            string otchestvo=OtchestvoClient.Text;
            string marka=MarkaClient.Text;
            string Vin = VIN.Text;
            string Problem = "";

            if ((name != "" && name.Length < 21) && (surname != "" && surname.Length < 21) && (otchestvo != "" && otchestvo.Length ==9) && (marka != "" && marka.Length < 16) && (Vin != "" && Vin.Length < 21))
            {
                if (checkBox9.Checked)
                    Problem += "0;";
                if (checkBox1.Checked)
                    Problem += "1;";
                if (checkBox5.Checked)
                    Problem += "2;";
                if (checkBox11.Checked)
                    Problem += "3;";

                string insertString = "";
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection
                {
                    ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = library; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"
                };
                conn.Open();
                if (flag)
                {
                    string createString = @"CREATE TABLE STO
                             ( 
                               id INT NOT NULL IDENTITY(1, 1),
                               FName VARCHAR(20) NOT NULL,
                               Lname VARCHAR(20) NOT NULL,
                               Phone INT NOT NULL,
                               Marka VARCHAR(15) NOT NULL,
                               VIN VARCHAR(17) NOT NULL,                                                                                 
                               problema VARCHAR(20) NOT NULL,
                               time INT,
                               price INT
                             )";
                    cmd = new SqlCommand(createString, conn);
                    cmd.ExecuteNonQuery();
                    flag = false;
                }

             
                insertString = $"insert into STO(FName,Lname,Phone,Marka,VIN,problema,time,price) values('{name}','{surname}','{otchestvo}','{marka}','{Vin}','{Problem + " "}','{0}','{0}');\n";
                cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(name + ", your request is accepted", "Уведомление");

                conn.Close();
                tm.Start();
            }
            else
            {
                MessageBox.Show("Fill in all fields correctly!", "Уведомление");
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NameClient.Clear();
            SurnameClient.Clear();
            OtchestvoClient.Clear();
            MarkaClient.Clear();
            VIN.Clear();
            checkBox1.Checked = false;           
            checkBox9.Checked = true;  
            checkBox11.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Paid successfully", "Уведомление");

            SqlCommand cmd;
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = library; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"
            };
            conn.Open();
            string insertString = $"DELETE FROM STO WHERE Phone = {OtchestvoClient.Text};\n";
            cmd = new SqlCommand(insertString, conn);
            cmd.ExecuteNonQuery();
            
            conn.Close();
            tm.Stop();
        }

        private void SurnameClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void NameClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void MarkaClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void OtchestvoClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            char namber = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && namber != 8)
            {
                e.Handled = true;
            }
        }
    }
}
