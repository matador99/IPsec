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
using System.Data.SqlTypes;

namespace IPsec
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          SqlConnection con2 = new SqlConnection(@"Data Source=91.219.252.85,1433;Network Library=dbmssocn;Initial Catalog=IPsec;User ID=IPUser;Password=matador99");
          con2.Open();
          string history="EXECUTE [dbo].[ShowHistory]";
          SqlDataAdapter da = new SqlDataAdapter(history, con2);
          SqlCommandBuilder cb = new SqlCommandBuilder(da);
          DataSet ds = new DataSet();
          da.Fill(ds);
          dataGridView1.DataSource = ds.Tables[0];
          con2.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=91.219.252.85,1433;Network Library=dbmssocn;Initial Catalog=IPsec;User ID=IPUser;Password=matador99");
            con2.Open();
            string history = "EXECUTE [dbo].[ShowHistory]";
            SqlDataAdapter da = new SqlDataAdapter(history, con2);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con2.Close();
        }

       
    }
}
