namespace GetWeightVersion3.UI
{
    partial class Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button12 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtaverage = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtmedian = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtsd = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(930, 8);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(20, 20);
            this.button12.TabIndex = 71;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column4});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(934, 347);
            this.dataGridView1.TabIndex = 93;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Statistics_MouseDown);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Statistics_MouseMove);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Statistics_MouseUp);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Employee";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Car ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Car Char";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "First Scale";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Seconde Scale";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "cleare Scale";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txtcost
            // 
            this.txtcost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcost.BackColor = System.Drawing.Color.White;
            this.txtcost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcost.ForeColor = System.Drawing.Color.Black;
            this.txtcost.Location = new System.Drawing.Point(152, 489);
            this.txtcost.Name = "txtcost";
            this.txtcost.ReadOnly = true;
            this.txtcost.Size = new System.Drawing.Size(122, 26);
            this.txtcost.TabIndex = 97;
            this.txtcost.Text = "0";
            this.txtcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(29, 489);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(117, 26);
            this.textBox4.TabIndex = 96;
            this.textBox4.Text = "Total Earn";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcount
            // 
            this.txtcount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcount.BackColor = System.Drawing.Color.White;
            this.txtcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcount.ForeColor = System.Drawing.Color.Black;
            this.txtcount.Location = new System.Drawing.Point(152, 457);
            this.txtcount.Name = "txtcount";
            this.txtcount.ReadOnly = true;
            this.txtcount.Size = new System.Drawing.Size(122, 26);
            this.txtcount.TabIndex = 95;
            this.txtcount.Text = "0";
            this.txtcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(29, 457);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(117, 26);
            this.textBox1.TabIndex = 94;
            this.textBox1.Text = "No.Car";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtaverage
            // 
            this.txtaverage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtaverage.BackColor = System.Drawing.Color.White;
            this.txtaverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaverage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaverage.ForeColor = System.Drawing.Color.Black;
            this.txtaverage.Location = new System.Drawing.Point(469, 489);
            this.txtaverage.Name = "txtaverage";
            this.txtaverage.ReadOnly = true;
            this.txtaverage.Size = new System.Drawing.Size(122, 26);
            this.txtaverage.TabIndex = 101;
            this.txtaverage.Text = "0";
            this.txtaverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(346, 489);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(117, 26);
            this.textBox6.TabIndex = 100;
            this.textBox6.Text = "Average";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmedian
            // 
            this.txtmedian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmedian.BackColor = System.Drawing.Color.White;
            this.txtmedian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmedian.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedian.ForeColor = System.Drawing.Color.Black;
            this.txtmedian.Location = new System.Drawing.Point(469, 457);
            this.txtmedian.Name = "txtmedian";
            this.txtmedian.ReadOnly = true;
            this.txtmedian.Size = new System.Drawing.Size(122, 26);
            this.txtmedian.TabIndex = 99;
            this.txtmedian.Text = "0";
            this.txtmedian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox8.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(346, 457);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(117, 26);
            this.textBox8.TabIndex = 98;
            this.textBox8.Text = "Median";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsd
            // 
            this.txtsd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsd.BackColor = System.Drawing.Color.White;
            this.txtsd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsd.ForeColor = System.Drawing.Color.Black;
            this.txtsd.Location = new System.Drawing.Point(734, 457);
            this.txtsd.Name = "txtsd";
            this.txtsd.ReadOnly = true;
            this.txtsd.Size = new System.Drawing.Size(122, 26);
            this.txtsd.TabIndex = 103;
            this.txtsd.Text = "0";
            this.txtsd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox12.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.White;
            this.textBox12.Location = new System.Drawing.Point(611, 457);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(117, 26);
            this.textBox12.TabIndex = 102;
            this.textBox12.Text = "SD";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(288, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 119;
            this.label4.Text = "To";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 118;
            this.label3.Text = "From";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(74, 35);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 26);
            this.date1.TabIndex = 117;
            // 
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(348, 35);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 26);
            this.date2.TabIndex = 116;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(564, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 26);
            this.button1.TabIndex = 120;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(958, 532);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.txtsd);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.txtaverage);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtmedian);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Statistics_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Statistics_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Statistics_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.TextBox txtcost;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox txtcount;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txtaverage;
        public System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox txtmedian;
        public System.Windows.Forms.TextBox textBox8;
        public System.Windows.Forms.TextBox txtsd;
        public System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Button button1;
    }
}