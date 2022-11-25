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
namespace Lab_3K
{
    public partial class Admin : Form
    {
        bool flag = false;
        int r;
        public Admin()
        {
            InitializeComponent();
        }

 

        
        void select(String request, SqlConnection conn)
        {
            int line = 0;
            SqlDataReader rdr = null;
            SqlCommand cmdSelect = new SqlCommand(request, conn);

            rdr = cmdSelect.ExecuteReader();
            lb_zayvka.Items.Clear();
            string str = "";
            for (; rdr.Read(); line++)
            {
                if (line == 0)
                {
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        str+=$"{rdr.GetName(i)}" + " ";
                    }
                    lb_zayvka.Items.Add(str);
                }
                
                str = "";
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    str += $"{rdr[i]}" + " ";

                }
                lb_zayvka.Items.Add(str);
            }


         
            if (rdr != null)
            {
                rdr.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = library; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"
            };
            conn.Open();

            select($"select * from STO", conn);

            conn.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            d_origin.RowCount = 3;
            d_origin.ColumnCount = 2;
            d_origin.TopLeftHeaderCell.Value = "Storage";


            d_origin.Rows[0].HeaderCell.Value = "1";

            d_origin.Rows[1].HeaderCell.Value = "2";
            d_origin.Rows[2].HeaderCell.Value = "3";



            d_origin.Columns[0].HeaderCell.Value = "Name";
            d_origin.Columns[1].HeaderCell.Value = "Сount";




            d_origin.Rows[0].Cells[0].Value = "Еires";
            d_origin.Rows[0].Cells[1].Value = 0;
            d_origin.Rows[1].Cells[0].Value = "Suspension";
            d_origin.Rows[1].Cells[1].Value = 2;
            d_origin.Rows[2].Cells[0].Value = "Engine";
            d_origin.Rows[2].Cells[1].Value = 1;

            foreach (DataGridViewColumn column in d_origin.Columns)
            {
                column.Width = 150;
            }
        }

        private void BtnBuyDetail_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                int g = Convert.ToInt32(d_origin.Rows[r].Cells[1].Value.ToString()) + 1;
                d_origin.Rows[r].Cells[1].Value= g;
                flag =false;
            }
            
        }

        private void d_origin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rows = e.RowIndex;
            int columns = e.ColumnIndex;

            if (rows != -1 && columns != -1)
            {
                if(columns==0)
                    columns++;
                if (d_origin[columns, rows].Value.ToString() == "0")
                {

                    flag = true;
                    r = rows;
                }
                else
                    flag = false;
            }
        }
        

        bool flag2 = true;
        string[] arr;
        private void BtnPrice_Click(object sender, EventArgs e)
        {
            string selectedStr = lb_zayvka.SelectedItem.ToString();
            arr = selectedStr.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int id = 0; 
            var random = new Random();
            int price = random.Next(100, 3000);
            if (arr[0] == "id")
            {
                flag2 = false;
            }
            else
            {
                if (arr[arr.Length - 2] == "0")
                    flag2 = false;
                else
                {
                    flag2 = true;
                    id = Convert.ToInt32(arr[0]);

                }
            }

            if (flag2)
            {
               
                textBox1.Text += "\r\n" +"Time of job: " + arr[arr.Length - 2] + " days";
                textBox1.Text += "\r\n" +"Price: "+ price+" $";
            }


            SqlConnection conn = new SqlConnection
            {
                ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = library; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"
            };
            conn.Open();
            SqlCommand cmd;
            string insertString = $"update STO set price = {price} WHERE id = {id};\n";
            cmd = new SqlCommand(insertString, conn);
            cmd.ExecuteNonQuery();

            select($"select * from STO", conn);
            conn.Close();
        }
        string[] sss;
        void select1(String request, SqlConnection conn)
        {
            SqlDataReader rdr = null;
            SqlCommand cmdSelect = new SqlCommand(request, conn);

            rdr = cmdSelect.ExecuteReader();
            string str = "";
            for (; rdr.Read(); )
            {
                str = "";
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    str += $"{rdr[i]}" + " ";

                }
            }

            sss = str.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            if (rdr != null)
            {
                rdr.Close();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = library; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"
            };
            conn.Open();

            SqlCommand cmd;
            select1($"select problema from STO WHERE time = {arr[arr.Length - 2]} ", conn);
            conn.Close();
            string g;
            for (int i = 0; i != sss.Length; i++)
            {
                if (sss[i] == "1")
                {
                    if (Convert.ToInt32(d_origin.Rows[0].Cells[1].Value) == 0)
                    {
                        MessageBox.Show("Part not in storage", "Уведомление");
                        break;
                    }
                    else
                    {
                        g = (Convert.ToInt32(d_origin.Rows[0].Cells[1].Value) - 1).ToString();
                        d_origin.Rows[0].Cells[1].Value = g;
                        textBox1.Text = "- - - - - -  - - - - - - - - - - - Ticket- - - - - - - - - - - - - - -";
                    }
                }
                if (sss[i] == "2")
                {
                    if (Convert.ToInt32(d_origin.Rows[1].Cells[1].Value) == 0)
                    {
                        MessageBox.Show("Part not in storage", "Уведомление");
                        break;
                    }
                    else
                    {
                        g = (Convert.ToInt32(d_origin.Rows[1].Cells[1].Value) - 1).ToString();
                        d_origin.Rows[1].Cells[1].Value = g;
                        textBox1.Text = "- - - - - -  - - - - - - - - - - - Ticket- - - - - - - - - - - - - - -";
                    }
                }
                if (sss[i] == "3")
                {
                    if (Convert.ToInt32(d_origin.Rows[2].Cells[1].Value) == 0)
                    {
                        MessageBox.Show("Part not in storage", "Уведомление");
                        break;
                    }
                    else
                    {
                        g = (Convert.ToInt32(d_origin.Rows[2].Cells[1].Value) - 1).ToString();
                        d_origin.Rows[2].Cells[1].Value = g;
                        textBox1.Text = "- - - - - -  - - - - - - - - - - - Ticket- - - - - - - - - - - - - - -";
                    }
                }
            }
            
        }
    }
}
