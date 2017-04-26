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

namespace Lab14_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\anyap\Source\Repos\PT2017Q2\Lab14_1\Lab14_1\callbox.mdf';Integrated Security = True");
        SqlDataAdapter dataAdter;
        SqlCommandBuilder cmdb;
        DataTable dt;
        BindingSource bs; 

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "callboxDataSet.phonebox". При необходимости она может быть перемещена или удалена.
            this.phoneboxTableAdapter.Fill(this.callboxDataSet.phonebox);
            sqlcon.Open();
            string query = "Select * from phonebox";
            dataAdter = new SqlDataAdapter(query, sqlcon);
            cmdb = new SqlCommandBuilder(dataAdter);
            dataAdter.InsertCommand = cmdb.GetInsertCommand();
            dt = new DataTable();
            dataAdter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;

        }

        private void save_Click(object sender, EventArgs e)
        {
           
            string query = "Insert into phonebox(Name, TellNum, Date) Values('" + textBox1.Text + "'," + textBox2.Text + ",GetDate()); Select * from phonebox";
            dataAdter = new SqlDataAdapter(query, sqlcon);
            cmdb = new SqlCommandBuilder(dataAdter);
            dataAdter.InsertCommand = cmdb.GetInsertCommand();
            dt = new DataTable();
            dataAdter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
        }

        private void Find_Click(object sender, EventArgs e)
        {
            string query = "Select * FROM phonebox WHERE name like '"+ textBox3.Text + "%'";
            dataAdter = new SqlDataAdapter(query, sqlcon);
            cmdb = new SqlCommandBuilder(dataAdter);
            dataAdter.InsertCommand = cmdb.GetInsertCommand();
            dt = new DataTable();
            dataAdter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
        }

        bool SortName_click_was = true;
        private void SortName_Click(object sender, EventArgs e)
        {
                 
            
                        if (SortName_click_was)
                        {
                dt = dt.Select().OrderBy(row => row.Field<string>("Name")).CopyToDataTable();

                bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                SortName_click_was = false;
                        } else
                        {

            dt = dt.Select().OrderByDescending(row => row.Field<string>("Name")).CopyToDataTable();

                bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                SortName_click_was = true;
                /*
                        string query = "Select * FROM phonebox order by name DESC";
                        dataAdter = new SqlDataAdapter(query, sqlcon);
                        cmdb = new SqlCommandBuilder(dataAdter);
                        dataAdter.InsertCommand = cmdb.GetInsertCommand();
                        dt = new DataTable();
                        dataAdter.Fill(dt);
                        bs = new BindingSource();
                        bs.DataSource = dt;
                        dataGridView1.DataSource = bs;
                        SortName_click_was = true; */
            }
                        
        }

        bool SortDate_click_was = true;
        private void SortDate_Click(object sender, EventArgs e)
        {
            if (SortDate_click_was)
            {
                dt = dt.Select().OrderBy(row => row.Field<DateTime>("Date")).CopyToDataTable();

                bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                SortDate_click_was = false;
            }
            else
            {
                dt = dt.Select().OrderByDescending(row => row.Field<DateTime>("Date")).CopyToDataTable();

                bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                SortDate_click_was = true;
            }
        }

        int a = 5;
        int b = 0;
        private void Refresh_Click(object sender, EventArgs e)
        {
            string query = "Select * from phonebox";
            dataAdter = new SqlDataAdapter(query, sqlcon);
            cmdb = new SqlCommandBuilder(dataAdter);
            dataAdter.InsertCommand = cmdb.GetInsertCommand();
            dt = new DataTable();
            dataAdter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            a = 5;
            b = 0;
        }

        

        private void left_Click(object sender, EventArgs e)
        {
            if (a >= 5)
            {
                b = a;
                a -= 5;
            string query = "Select * from phonebox WHERE ID >"+a+" AND Id <= "+b+"";
                dataAdter = new SqlDataAdapter(query, sqlcon);
                cmdb = new SqlCommandBuilder(dataAdter);
                dataAdter.InsertCommand = cmdb.GetInsertCommand();
                dt = new DataTable();
                dataAdter.Fill(dt);
                bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
            }
        }

        private void right_Click(object sender, EventArgs e)
        {
                 b = a;
                a += 5;
            string query = "Select * from phonebox WHERE ID >" + b + " AND Id <= " + a + "";
            dataAdter = new SqlDataAdapter(query, sqlcon);
            cmdb = new SqlCommandBuilder(dataAdter);
            dataAdter.InsertCommand = cmdb.GetInsertCommand();
            dt = new DataTable();
            dataAdter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;

        }
    }
}
