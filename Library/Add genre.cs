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
    public partial class Add_genre : Form
    {
        public Add_genre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source=DESKTOP-PPIILUB;Initial Catalog=crudTest;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into genre(genre) values (@g)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@g", textBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("genre added!");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source=DESKTOP-PPIILUB;Initial Catalog=crudTest;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;

            cmd.CommandText = "delete from genre where genre=@g";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@g", textBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("genre deleted!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = 0; i < dgv3.Rows.Count; i++)
            {
                if (dgv3.Rows[i].Cells[0].Value.ToString() != new_genre.Text)
                {
                    c++;
                }
            }
            
                string conStr = "Data Source=DESKTOP-PPIILUB;Initial Catalog=crudTest;Integrated Security=True";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "update genre set genre=@genre where genre=@old_genre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@genre", new_genre.Text);
                cmd.Parameters.AddWithValue("@old_genre", old_genre.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                cmd.Dispose();
            con.ConnectionString = con.ConnectionString = "Data Source=DESKTOP-PPIILUB;Initial Catalog=crudTest;Integrated Security=True";

            cmd.Connection = con;
                cmd.CommandText = "update book set genre=@genre where genre=@old_genre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@genre", new_genre.Text);
                cmd.Parameters.AddWithValue("@old_genre", old_genre.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                cmd.Dispose();
                MessageBox.Show("the genre changed.");
           
        }

        private void Add_genre_Load(object sender, EventArgs e)
        {
            string conStr = "Data Source=DESKTOP-PPIILUB;Initial Catalog=crudTest;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = con.CreateCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            cmd.Connection = con;

            cmd.Parameters.Clear();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = con;
            da.SelectCommand.CommandText = "select * from genre";
            da.Fill(ds, "t3");
            dgv3.DataSource = ds;
            dgv3.DataMember = "t3";
        }
    }
}
