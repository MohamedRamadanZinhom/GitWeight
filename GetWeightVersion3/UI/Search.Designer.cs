namespace GetWeightVersion3.UI
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button12 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtid = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtemp = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtfs = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtchar = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtcs = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txtss = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcarchar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcarno = new System.Windows.Forms.TextBox();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.button12.Location = new System.Drawing.Point(850, 7);
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dataGridView1.Location = new System.Drawing.Point(341, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(526, 351);
            this.dataGridView1.TabIndex = 93;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Employee";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Car ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Car Char";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "First Scale";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Seconde Scale";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 110;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "cleare Scale";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.Location = new System.Drawing.Point(139, 199);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(163, 26);
            this.txtid.TabIndex = 97;
            this.txtid.Text = "0";
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BackColor = System.Drawing.Color.Indigo;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(16, 199);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(117, 26);
            this.textBox4.TabIndex = 96;
            this.textBox4.Text = "Car ID";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtemp
            // 
            this.txtemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtemp.BackColor = System.Drawing.Color.White;
            this.txtemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemp.ForeColor = System.Drawing.Color.Black;
            this.txtemp.Location = new System.Drawing.Point(139, 148);
            this.txtemp.Name = "txtemp";
            this.txtemp.ReadOnly = true;
            this.txtemp.Size = new System.Drawing.Size(163, 26);
            this.txtemp.TabIndex = 95;
            this.txtemp.Text = "0";
            this.txtemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.Indigo;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(16, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(117, 26);
            this.textBox1.TabIndex = 94;
            this.textBox1.Text = "Employee";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtfs
            // 
            this.txtfs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfs.BackColor = System.Drawing.Color.White;
            this.txtfs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfs.ForeColor = System.Drawing.Color.Black;
            this.txtfs.Location = new System.Drawing.Point(139, 306);
            this.txtfs.Name = "txtfs";
            this.txtfs.ReadOnly = true;
            this.txtfs.Size = new System.Drawing.Size(163, 26);
            this.txtfs.TabIndex = 101;
            this.txtfs.Text = "0";
            this.txtfs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.BackColor = System.Drawing.Color.Indigo;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(16, 306);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(117, 26);
            this.textBox6.TabIndex = 100;
            this.textBox6.Text = "First Scale";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtchar
            // 
            this.txtchar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtchar.BackColor = System.Drawing.Color.White;
            this.txtchar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtchar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchar.ForeColor = System.Drawing.Color.Black;
            this.txtchar.Location = new System.Drawing.Point(139, 255);
            this.txtchar.Name = "txtchar";
            this.txtchar.ReadOnly = true;
            this.txtchar.Size = new System.Drawing.Size(163, 26);
            this.txtchar.TabIndex = 99;
            this.txtchar.Text = "0";
            this.txtchar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox8.BackColor = System.Drawing.Color.Indigo;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(16, 255);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(117, 26);
            this.textBox8.TabIndex = 98;
            this.textBox8.Text = "Car Char";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcs
            // 
            this.txtcs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcs.BackColor = System.Drawing.Color.White;
            this.txtcs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcs.ForeColor = System.Drawing.Color.Black;
            this.txtcs.Location = new System.Drawing.Point(139, 417);
            this.txtcs.Name = "txtcs";
            this.txtcs.ReadOnly = true;
            this.txtcs.Size = new System.Drawing.Size(163, 26);
            this.txtcs.TabIndex = 105;
            this.txtcs.Text = "0";
            this.txtcs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox10.BackColor = System.Drawing.Color.Indigo;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.White;
            this.textBox10.Location = new System.Drawing.Point(16, 417);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(117, 26);
            this.textBox10.TabIndex = 104;
            this.textBox10.Text = "Clear Scale";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtss
            // 
            this.txtss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtss.BackColor = System.Drawing.Color.White;
            this.txtss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtss.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtss.ForeColor = System.Drawing.Color.Black;
            this.txtss.Location = new System.Drawing.Point(139, 361);
            this.txtss.Name = "txtss";
            this.txtss.ReadOnly = true;
            this.txtss.Size = new System.Drawing.Size(163, 26);
            this.txtss.TabIndex = 103;
            this.txtss.Text = "0";
            this.txtss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox12.BackColor = System.Drawing.Color.Indigo;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.White;
            this.textBox12.Location = new System.Drawing.Point(16, 361);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(117, 26);
            this.textBox12.TabIndex = 102;
            this.textBox12.Text = "Seconde Scale";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtprice
            // 
            this.txtprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtprice.BackColor = System.Drawing.Color.White;
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.ForeColor = System.Drawing.Color.Black;
            this.txtprice.Location = new System.Drawing.Point(139, 473);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(163, 26);
            this.txtprice.TabIndex = 107;
            this.txtprice.Text = "0";
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            this.textBox16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox16.BackColor = System.Drawing.Color.Indigo;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.ForeColor = System.Drawing.Color.White;
            this.textBox16.Location = new System.Drawing.Point(16, 473);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(117, 26);
            this.textBox16.TabIndex = 106;
            this.textBox16.Text = "Price";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 111;
            this.label2.Text = "Car character";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcarchar
            // 
            this.txtcarchar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcarchar.BackColor = System.Drawing.Color.White;
            this.txtcarchar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcarchar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcarchar.ForeColor = System.Drawing.Color.Black;
            this.txtcarchar.Location = new System.Drawing.Point(118, 60);
            this.txtcarchar.Name = "txtcarchar";
            this.txtcarchar.Size = new System.Drawing.Size(176, 26);
            this.txtcarchar.TabIndex = 110;
            this.txtcarchar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 109;
            this.label1.Text = "Car Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcarno
            // 
            this.txtcarno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcarno.BackColor = System.Drawing.Color.White;
            this.txtcarno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcarno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcarno.ForeColor = System.Drawing.Color.Black;
            this.txtcarno.Location = new System.Drawing.Point(118, 17);
            this.txtcarno.Name = "txtcarno";
            this.txtcarno.Size = new System.Drawing.Size(176, 26);
            this.txtcarno.TabIndex = 108;
            this.txtcarno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(363, 60);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 26);
            this.date2.TabIndex = 112;
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(363, 17);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 26);
            this.date1.TabIndex = 113;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(303, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 114;
            this.label3.Text = "From";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(303, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 115;
            this.label4.Text = "To";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(569, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 69);
            this.button1.TabIndex = 116;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(879, 522);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcarchar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcarno);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.txtcs);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.txtss);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.txtfs);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtchar);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtemp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Search_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Search_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Search_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Search_MouseUp);
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
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox txtemp;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txtfs;
        public System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox txtchar;
        public System.Windows.Forms.TextBox textBox8;
        public System.Windows.Forms.TextBox txtcs;
        public System.Windows.Forms.TextBox textBox10;
        public System.Windows.Forms.TextBox txtss;
        public System.Windows.Forms.TextBox textBox12;
        public System.Windows.Forms.TextBox txtprice;
        public System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtcarchar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtcarno;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}