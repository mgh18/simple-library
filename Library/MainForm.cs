using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addmember member = new Addmember();
            member.Show();
            
        }

        private void newBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook book = new AddBook();
            book.Show();
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingform set = new settingform();
            set.Show();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchBook sb = new searchBook();
            sb.Show();

        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchMember sm = new searchMember();
            sm.Show();
        }

        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportBook repbook = new ReportBook();
            repbook.Show();
        }

        private void memberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Report_Member repme = new Report_Member();
            repme.Show();
        }

        private void newBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Borrow_New_Book bnb = new Borrow_New_Book();
            bnb.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return_Book rb = new Return_Book();
            rb.Show();
        }

        private void borrowListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow_List bl = new Borrow_List();
            bl.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
