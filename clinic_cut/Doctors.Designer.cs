
namespace clinic_cut
{
    partial class Doctors
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.DocSpecCb = new System.Windows.Forms.ComboBox();
            this.DocAddTb = new System.Windows.Forms.TextBox();
            this.DocExpTb = new System.Windows.Forms.TextBox();
            this.DocPhoneTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DocDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DNameTb = new System.Windows.Forms.TextBox();
            this.DocGenCb = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.DocPassWordTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DoctorsDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.EditBtn.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(699, 389);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(128, 35);
            this.EditBtn.TabIndex = 57;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.AddBtn.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(374, 389);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(128, 35);
            this.AddBtn.TabIndex = 56;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.DelBtn.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.Location = new System.Drawing.Point(535, 389);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(128, 35);
            this.DelBtn.TabIndex = 55;
            this.DelBtn.Text = "DELETE";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // DocSpecCb
            // 
            this.DocSpecCb.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.DocSpecCb.FormattingEnabled = true;
            this.DocSpecCb.Items.AddRange(new object[] {
            "Generalist ",
            "Surgeon ",
            "Urology"});
            this.DocSpecCb.Location = new System.Drawing.Point(458, 311);
            this.DocSpecCb.Name = "DocSpecCb";
            this.DocSpecCb.Size = new System.Drawing.Size(161, 28);
            this.DocSpecCb.TabIndex = 54;
            this.DocSpecCb.Text = "SPECIALIZATION";
            // 
            // DocAddTb
            // 
            this.DocAddTb.Location = new System.Drawing.Point(895, 246);
            this.DocAddTb.Multiline = true;
            this.DocAddTb.Name = "DocAddTb";
            this.DocAddTb.Size = new System.Drawing.Size(225, 91);
            this.DocAddTb.TabIndex = 53;
            // 
            // DocExpTb
            // 
            this.DocExpTb.Location = new System.Drawing.Point(699, 246);
            this.DocExpTb.Multiline = true;
            this.DocExpTb.Name = "DocExpTb";
            this.DocExpTb.Size = new System.Drawing.Size(180, 26);
            this.DocExpTb.TabIndex = 52;
            // 
            // DocPhoneTb
            // 
            this.DocPhoneTb.Location = new System.Drawing.Point(213, 314);
            this.DocPhoneTb.Name = "DocPhoneTb";
            this.DocPhoneTb.Size = new System.Drawing.Size(171, 22);
            this.DocPhoneTb.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(209, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "PHONE NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(695, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "EXPERIENCE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(938, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "HOME ADDRESS ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(531, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "D.O.B";
            // 
            // DocDOB
            // 
            this.DocDOB.Location = new System.Drawing.Point(470, 246);
            this.DocDOB.Name = "DocDOB";
            this.DocDOB.Size = new System.Drawing.Size(223, 22);
            this.DocDOB.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(389, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "GENDER";
            // 
            // DNameTb
            // 
            this.DNameTb.Location = new System.Drawing.Point(213, 246);
            this.DNameTb.Name = "DNameTb";
            this.DNameTb.Size = new System.Drawing.Size(171, 22);
            this.DNameTb.TabIndex = 44;
            // 
            // DocGenCb
            // 
            this.DocGenCb.FormattingEnabled = true;
            this.DocGenCb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.DocGenCb.Location = new System.Drawing.Point(390, 246);
            this.DocGenCb.Name = "DocGenCb";
            this.DocGenCb.Size = new System.Drawing.Size(71, 24);
            this.DocGenCb.TabIndex = 43;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label.Location = new System.Drawing.Point(209, 220);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(137, 20);
            this.label.TabIndex = 42;
            this.label.Text = "DOCTORS NAME";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pictureBox12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 702);
            this.panel1.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(60, 504);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 34);
            this.label13.TabIndex = 19;
            this.label13.Text = "Medicines";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::clinic_cut.Properties.Resources.lab;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 44);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(63, 656);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 34);
            this.label11.TabIndex = 17;
            this.label11.Text = "Logout";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = global::clinic_cut.Properties.Resources.log_out;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(6, 645);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(51, 45);
            this.pictureBox12.TabIndex = 16;
            this.pictureBox12.TabStop = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(60, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 34);
            this.label10.TabIndex = 15;
            this.label10.Text = "Patients";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 36);
            this.label9.TabIndex = 14;
            this.label9.Text = "Receptionist";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 34);
            this.label8.TabIndex = 13;
            this.label8.Text = "Home";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::clinic_cut.Properties.Resources.patient;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(9, 420);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(51, 44);
            this.pictureBox11.TabIndex = 12;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::clinic_cut.Properties.Resources.reception;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(9, 356);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(51, 45);
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::clinic_cut.Properties.Resources.doc;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(9, 288);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(51, 49);
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Welcome";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::clinic_cut.Properties.Resources.logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 141);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(420, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 94);
            this.label3.TabIndex = 40;
            this.label3.Text = "DOCTORS";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::clinic_cut.Properties.Resources.close__1_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(1098, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 38);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // DocPassWordTb
            // 
            this.DocPassWordTb.Location = new System.Drawing.Point(699, 314);
            this.DocPassWordTb.Multiline = true;
            this.DocPassWordTb.Name = "DocPassWordTb";
            this.DocPassWordTb.Size = new System.Drawing.Size(180, 24);
            this.DocPassWordTb.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(695, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 20);
            this.label12.TabIndex = 59;
            this.label12.Text = "PASSWORD";
            // 
            // DoctorsDGV
            // 
            this.DoctorsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoctorsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DoctorsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorsDGV.Location = new System.Drawing.Point(176, 461);
            this.DoctorsDGV.Name = "DoctorsDGV";
            this.DoctorsDGV.RowHeadersWidth = 51;
            this.DoctorsDGV.RowTemplate.Height = 24;
            this.DoctorsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoctorsDGV.Size = new System.Drawing.Size(949, 229);
            this.DoctorsDGV.TabIndex = 87;
            this.DoctorsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorsDGV_CellContentClick);
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 702);
            this.Controls.Add(this.DoctorsDGV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DocPassWordTb);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.DocSpecCb);
            this.Controls.Add(this.DocAddTb);
            this.Controls.Add(this.DocExpTb);
            this.Controls.Add(this.DocPhoneTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DocDOB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DNameTb);
            this.Controls.Add(this.DocGenCb);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctors";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.ComboBox DocSpecCb;
        private System.Windows.Forms.TextBox DocAddTb;
        private System.Windows.Forms.TextBox DocExpTb;
        private System.Windows.Forms.TextBox DocPhoneTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DocDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DNameTb;
        private System.Windows.Forms.ComboBox DocGenCb;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox DocPassWordTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DoctorsDGV;
    }
}