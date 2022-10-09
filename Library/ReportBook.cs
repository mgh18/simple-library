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
namespace Library
{
    public partial class ReportBook : Form
    {
        public ReportBook()
        {
            InitializeComponent();
        }

        private void ReportBook_Load(object sender, EventArgs e)
        {
            string con_string = "Data Source=DESKTOP-PPIILUB;Initial Catalog=crudTest;Integrated Security=True";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = con_string;
            cmd.Connection = con;
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = con;
            da.SelectCommand.CommandText = "select * from book";
            da.Fill(ds, "t1");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "t1";

        }
    }
}
