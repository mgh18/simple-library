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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            AddBook_Load(sender, e);
        }

        private void add_genre_Click(object sender, EventArgs e)
        {
            Add_genre ad = new Add_genre();
            ad.Show();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void btn_addbook_Click(object sender, EventArgs e)
        {

            string conStr = "Data Source=DESKTOP-PPIILUB;Initial Catalog=crudTest;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = con.CreateCommand();
            //SqlDataAdapter da = new SqlDataAdapter();
            //DataTable dt = new DataTable();
            if (book_id.Text == "" && book_name.Text == "")
            {
                MessageBox.Show("Please enter the book id and book title.");
            }
            else
            {

                cmd.Connection = con;
               // da.SelectCommand = new SqlCommand();
                //da.SelectCommand.Connection = con;
               // da.SelectCommand.CommandText = "select bookId from book where bookId=@bookid";
                //da.SelectCommand.Parameters.AddWithValue("@bookid", book_id.Text);
                //da.Fill(dt);
                //dgv.DataSource = dt;

               // if (dgv.Rows[0].Cells[0].Value != null)
               // {
               //     MessageBox.Show("Book id is not uniqe.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
               // }
              //  else { 

                    cmd.CommandText = "insert into book(bookId,title,author,publisher,release,genre,borrowed)values" +
                        "(@id,@title,@author,@publisher,@release,@genre,@borrowed) ";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id", book_id.Text);
                cmd.Parameters.AddWithValue("@title", book_name.Text);
                cmd.Parameters.AddWithValue("@author", book_author.Text);
                cmd.Parameters.AddWithValue("@publisher", book_pub.Text);
                cmd.Parameters.AddWithValue("@release", book_re.Text);
                cmd.Parameters.AddWithValue("@genre", comboBox1.Text);
                cmd.Parameters.AddWithValue("@borrowed", "Available");

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The book added.");
            }

        
           
            
        }
        

        private void meme_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void meme_fam_TextChanged(object sender, EventArgs e)
        {

        }

        private void meme_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void meme_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void meme_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void code_member_Click(object sender, EventArgs e)
        {

        }

        private void meme_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBook_Load(object sender, EventArgs e)
        {

            try
            {
                comboBox1.Items.Clear();
                string conStr = "Data Source=DESKTOP-PPIILUB;Initial Catalog=crudTest;Integrated Security=True";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = con.CreateCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                cmd.Connection = con;

                cmd.Parameters.Clear();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandText= "select * from genre";
                da.Fill(ds, "t2");
                dgv1.DataSource = ds;
                dgv1.DataMember = "t2";
                for (int i = 0; i < dgv1.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dgv1.Rows[i].Cells[0].Value.ToString());
                }
            }
            catch
            {

            }


        }



            
    }
}
