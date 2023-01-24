
namespace WeddingHall
{
    partial class Staff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StaffNameTb = new System.Windows.Forms.TextBox();
            this.StaffGenderCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StaffPhoneTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StaffPassTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StaffDGV = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1613, 56);
            this.panel1.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Indigo;
            this.label17.Location = new System.Drawing.Point(1565, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 32);
            this.label17.TabIndex = 5;
            this.label17.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F);
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(28, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "Staff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F);
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StaffNameTb
            // 
            this.StaffNameTb.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F);
            this.StaffNameTb.Location = new System.Drawing.Point(119, 114);
            this.StaffNameTb.Name = "StaffNameTb";
            this.StaffNameTb.Size = new System.Drawing.Size(300, 44);
            this.StaffNameTb.TabIndex = 4;
            this.StaffNameTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StaffGenderCb
            // 
            this.StaffGenderCb.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F);
            this.StaffGenderCb.FormattingEnabled = true;
            this.StaffGenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.StaffGenderCb.Location = new System.Drawing.Point(961, 117);
            this.StaffGenderCb.Name = "StaffGenderCb";
            this.StaffGenderCb.Size = new System.Drawing.Size(209, 44);
            this.StaffGenderCb.TabIndex = 9;
            this.StaffGenderCb.SelectedIndexChanged += new System.EventHandler(this.StaffGenderCb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(838, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F);
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(444, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // StaffPhoneTb
            // 
            this.StaffPhoneTb.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F);
            this.StaffPhoneTb.Location = new System.Drawing.Point(556, 114);
            this.StaffPhoneTb.Name = "StaffPhoneTb";
            this.StaffPhoneTb.Size = new System.Drawing.Size(260, 44);
            this.StaffPhoneTb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F);
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(1198, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "Passord";
            // 
            // StaffPassTb
            // 
            this.StaffPassTb.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F);
            this.StaffPassTb.Location = new System.Drawing.Point(1336, 114);
            this.StaffPassTb.Name = "StaffPassTb";
            this.StaffPassTb.Size = new System.Drawing.Size(260, 44);
            this.StaffPassTb.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F);
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(714, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 36);
            this.label5.TabIndex = 19;
            this.label5.Text = "Bookins List";
            // 
            // StaffDGV
            // 
            this.StaffDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffDGV.Location = new System.Drawing.Point(286, 226);
            this.StaffDGV.Name = "StaffDGV";
            this.StaffDGV.RowHeadersWidth = 51;
            this.StaffDGV.RowTemplate.Height = 24;
            this.StaffDGV.Size = new System.Drawing.Size(1179, 519);
            this.StaffDGV.TabIndex = 18;
            this.StaffDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffDGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LavenderBlush;
            this.button4.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F);
            this.button4.ForeColor = System.Drawing.Color.Indigo;
            this.button4.Location = new System.Drawing.Point(34, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 51);
            this.button4.TabIndex = 21;
            this.button4.Text = "Add Staff";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LavenderBlush;
            this.button3.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F);
            this.button3.ForeColor = System.Drawing.Color.Indigo;
            this.button3.Location = new System.Drawing.Point(34, 631);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 51);
            this.button3.TabIndex = 20;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F);
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(34, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 51);
            this.button1.TabIndex = 22;
            this.button1.Text = "Edit Staff";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F);
            this.button2.ForeColor = System.Drawing.Color.Indigo;
            this.button2.Location = new System.Drawing.Point(34, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 51);
            this.button2.TabIndex = 23;
            this.button2.Text = "Delete Staff";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LavenderBlush;
            this.button5.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F);
            this.button5.ForeColor = System.Drawing.Color.Indigo;
            this.button5.Location = new System.Drawing.Point(745, 755);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(214, 51);
            this.button5.TabIndex = 24;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 826);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StaffDGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StaffPassTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StaffPhoneTb);
            this.Controls.Add(this.StaffGenderCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StaffNameTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StaffNameTb;
        private System.Windows.Forms.ComboBox StaffGenderCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StaffPhoneTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StaffPassTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView StaffDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}