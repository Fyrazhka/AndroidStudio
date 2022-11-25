using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Lab_3K
{
    public partial class Mechanic : Form
    {
        public Mechanic()
        {
            InitializeComponent();
        }


        private void fun(object sender, EventArgs e)
        {
       
            int id = 1;
            string selectedStr = listBox1.SelectedItem.ToString();
            string[] arr = selectedStr.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
           


            id = Convert.ToInt32(arr[0]);


            SqlConnection conn = new SqlConnection
            {
                ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = library; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"
            };
            conn.Open();

            SqlCommand cmd;
            string insertString = $"update STO set time = {Convert.ToInt32(textBox1.Text.ToString())} WHERE id = {id};\n";
            cmd = new SqlCommand(insertString, conn);
            cmd.ExecuteNonQuery();

            select($"select * from STO", conn);

            conn.Close();
        }

        void select(String request, SqlConnection conn)
        {
            int line = 0;
            SqlDataReader rdr = null;
            SqlCommand cmdSelect = new SqlCommand(request, conn);

            rdr = cmdSelect.ExecuteReader();
            listBox1.Items.Clear();
            string str = "";
            for (; rdr.Read(); line++)
            {
                if (line == 0)
                {
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        str += $"{rdr.GetName(i)}" + " ";
                    }
                    listBox1.Items.Add(str);
                }

                str = "";
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    str += $"{rdr[i]}" + " ";

                }
                listBox1.Items.Add(str);
            }



            if (rdr != null)
            {
                rdr.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = library; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"
            };
            conn.Open();

            select($"select * from STO", conn);

            conn.Close();
        }
        bool flag = true;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStr = listBox1.SelectedItem.ToString();
            string[] arr = selectedStr.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (arr[0] == "id")
            {
                flag = false;
            }
            else
                flag = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (flag)
                fun(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char namber = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && namber != 8)
            {
                e.Handled = true;
            }
        }
    }
}
