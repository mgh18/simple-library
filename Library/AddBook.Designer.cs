namespace Library
{
    partial class AddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.btn_addbook = new System.Windows.Forms.Button();
            this.book_author = new System.Windows.Forms.TextBox();
            this.book_pub = new System.Windows.Forms.TextBox();
            this.book_re = new System.Windows.Forms.TextBox();
            this.code_member = new System.Windows.Forms.Label();
            this.book_id = new System.Windows.Forms.TextBox();
            this.add_genre = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.book_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "Release:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "Publisher:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Genre:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(143, 59);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 15);
            this.name.TabIndex = 28;
            this.name.Text = "Tiltle:";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // btn_addbook
            // 
            this.btn_addbook.Location = new System.Drawing.Point(143, 267);
            this.btn_addbook.Name = "btn_addbook";
            this.btn_addbook.Size = new System.Drawing.Size(102, 23);
            this.btn_addbook.TabIndex = 27;
            this.btn_addbook.Text = "Submit";
            this.btn_addbook.UseVisualStyleBackColor = true;
            this.btn_addbook.Click += new System.EventHandler(this.btn_addbook_Click);
            // 
            // book_author
            // 
            this.book_author.Location = new System.Drawing.Point(243, 98);
            this.book_author.Name = "book_author";
            this.book_author.Size = new System.Drawing.Size(100, 23);
            this.book_author.TabIndex = 26;
            this.book_author.TextChanged += new System.EventHandler(this.meme_name_TextChanged);
            // 
            // book_pub
            // 
            this.book_pub.Location = new System.Drawing.Point(243, 138);
            this.book_pub.Name = "book_pub";
            this.book_pub.Size = new System.Drawing.Size(100, 23);
            this.book_pub.TabIndex = 25;
            this.book_pub.TextChanged += new System.EventHandler(this.meme_fam_TextChanged);
            // 
            // book_re
            // 
            this.book_re.Location = new System.Drawing.Point(243, 177);
            this.book_re.Name = "book_re";
            this.book_re.Size = new System.Drawing.Size(100, 23);
            this.book_re.TabIndex = 24;
            this.book_re.TextChanged += new System.EventHandler(this.meme_phone_TextChanged);
            // 
            // code_member
            // 
            this.code_member.AutoSize = true;
            this.code_member.Location = new System.Drawing.Point(143, 20);
            this.code_member.Name = "code_member";
            this.code_member.Size = new System.Drawing.Size(51, 15);
            this.code_member.TabIndex = 21;
            this.code_member.Text = "Book ID:";
            this.code_member.Click += new System.EventHandler(this.code_member_Click);
            // 
            // book_id
            // 
            this.book_id.Location = new System.Drawing.Point(243, 20);
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(100, 23);
            this.book_id.TabIndex = 20;
            this.book_id.TextChanged += new System.EventHandler(this.meme_id_TextChanged);
            // 
            // add_genre
            // 
            this.add_genre.Location = new System.Drawing.Point(264, 266);
            this.add_genre.Name = "add_genre";
            this.add_genre.Size = new System.Drawing.Size(100, 23);
            this.add_genre.TabIndex = 33;
            this.add_genre.Text = "Add Genre";
            this.add_genre.UseVisualStyleBackColor = true;
            this.add_genre.Click += new System.EventHandler(this.add_genre_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh.BackgroundImage")));
            this.Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Refresh.Location = new System.Drawing.Point(319, 228);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(28, 23);
            this.Refresh.TabIndex = 34;
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // book_name
            // 
            this.book_name.Location = new System.Drawing.Point(243, 62);
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(100, 23);
            this.book_name.TabIndex = 23;
            this.book_name.TextChanged += new System.EventHandler(this.meme_email_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "Author:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(5, 146);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(24, 24);
            this.dgv.TabIndex = 36;
            this.dgv.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(243, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 23);
            this.comboBox1.TabIndex = 37;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(26, 182);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.Size = new System.Drawing.Size(24, 24);
            this.dgv1.TabIndex = 38;
            this.dgv1.Visible = false;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(376, 308);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.add_genre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btn_addbook);
            this.Controls.Add(this.book_author);
            this.Controls.Add(this.book_pub);
            this.Controls.Add(this.book_re);
            this.Controls.Add(this.book_name);
            this.Controls.Add(this.code_member);
            this.Controls.Add(this.book_id);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.AddBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label9;
        private Label label8;
        private Label label7;
        private Label name;
        private Button btn_addbook;
        private TextBox book_author;
        private TextBox book_pub;
        private TextBox book_re;
        private Label code_member;
        private TextBox book_id;
        private Button add_genre;
        private Button Refresh;
        private PictureBox pictureBox1;
        private TextBox book_name;
        private Label label10;
        private DataGridView dgv;
        private ComboBox comboBox1;
        private DataGridView dgv1;
    }
}