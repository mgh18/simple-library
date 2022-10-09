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
    public partial class Addmember : Form
    {
        public Addmember()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_addmember_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source=DESKTOP-PPIILUB;Initial Catalog=crudTest;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = con.CreateCommand();

            if (meme_id.Text == "" && meme_fam.Text == "")
            {
                MessageBox.Show("Please enter the book id and book title.");
            }
            else
            {
                cmd.Connection = con;
             
                cmd.CommandText = "insert into Member(membership_id,name,family,mobile,member_date,email)values" +
                    "(@meme_id,@name,@family,@mobile,@member_date,@email) ";
                cmd.Parameters.Clear();
                
                cmd.Parameters.AddWithValue("@meme_id", meme_id.Text);
                cmd.Parameters.AddWithValue("@name", meme_name.Text);
                cmd.Parameters.AddWithValue("@family", meme_fam.Text);
                cmd.Parameters.AddWithValue("@mobile", meme_phone.Text);
                cmd.Parameters.AddWithValue("@member_date",meme_date.Text);
                cmd.Parameters.AddWithValue("@email", meme_email.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("member added.");
            }


        }
    }

    }

