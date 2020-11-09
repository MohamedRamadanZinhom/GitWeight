namespace GetWeightVersion3.UI
{
    partial class EmployeeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtemp = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtemp
            // 
            this.txtemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtemp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemp.ForeColor = System.Drawing.Color.White;
            this.txtemp.Location = new System.Drawing.Point(267, 9);
            this.txtemp.Name = "txtemp";
            this.txtemp.ReadOnly = true;
            this.txtemp.Size = new System.Drawing.Size(212, 26);
            this.txtemp.TabIndex = 88;
            this.txtemp.Text = "Hello Employee";
            this.txtemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtemp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtemp_MouseDown);
            this.txtemp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtemp_MouseMove);
            this.txtemp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtemp_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(708, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 89;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.Column4,
            this.Column5});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(713, 377);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtemp_MouseDown);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtemp_MouseMove);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtemp_MouseUp);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Start Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Power";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Salary";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(135, 499);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(122, 26);
            this.textBox3.TabIndex = 97;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BackColor = System.Drawing.Color.Indigo;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(12, 499);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(117, 26);
            this.textBox4.TabIndex = 96;
            this.textBox4.Text = "Total Cost";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(135, 467);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(122, 26);
            this.textBox2.TabIndex = 95;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.Indigo;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 467);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(117, 26);
            this.textBox1.TabIndex = 94;
            this.textBox1.Text = "No.Employee";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 98;
            this.label1.Text = "Employee Data";
            // 
            // EmployeeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(737, 540);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmployeeReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EmployeeReport_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtemp_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtemp_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtemp_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtemp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}