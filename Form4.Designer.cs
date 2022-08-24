
namespace Recruitment
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDVACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBSEEKERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vACANCYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSet2 = new Recruitment.ProjectDataSet2();
            this.vACANCYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.vACANCYTableAdapter = new Recruitment.ProjectDataSet2TableAdapters.VACANCYTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACANCYBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACANCYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDVACDataGridViewTextBoxColumn,
            this.iDEMPDataGridViewTextBoxColumn,
            this.jOBSEEKERIDDataGridViewTextBoxColumn,
            this.jOBTITLEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vACANCYBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDVACDataGridViewTextBoxColumn
            // 
            this.iDVACDataGridViewTextBoxColumn.DataPropertyName = "ID_VAC";
            this.iDVACDataGridViewTextBoxColumn.HeaderText = "ID_VAC";
            this.iDVACDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDVACDataGridViewTextBoxColumn.Name = "iDVACDataGridViewTextBoxColumn";
            this.iDVACDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDVACDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDEMPDataGridViewTextBoxColumn
            // 
            this.iDEMPDataGridViewTextBoxColumn.DataPropertyName = "ID_EMP";
            this.iDEMPDataGridViewTextBoxColumn.HeaderText = "ID_EMP";
            this.iDEMPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDEMPDataGridViewTextBoxColumn.Name = "iDEMPDataGridViewTextBoxColumn";
            this.iDEMPDataGridViewTextBoxColumn.Width = 125;
            // 
            // jOBSEEKERIDDataGridViewTextBoxColumn
            // 
            this.jOBSEEKERIDDataGridViewTextBoxColumn.DataPropertyName = "JOB_SEEKER__ID";
            this.jOBSEEKERIDDataGridViewTextBoxColumn.HeaderText = "JOB_SEEKER__ID";
            this.jOBSEEKERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jOBSEEKERIDDataGridViewTextBoxColumn.Name = "jOBSEEKERIDDataGridViewTextBoxColumn";
            this.jOBSEEKERIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // jOBTITLEDataGridViewTextBoxColumn
            // 
            this.jOBTITLEDataGridViewTextBoxColumn.DataPropertyName = "JOBTITLE";
            this.jOBTITLEDataGridViewTextBoxColumn.HeaderText = "JOBTITLE";
            this.jOBTITLEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jOBTITLEDataGridViewTextBoxColumn.Name = "jOBTITLEDataGridViewTextBoxColumn";
            this.jOBTITLEDataGridViewTextBoxColumn.Width = 125;
            // 
            // vACANCYBindingSource1
            // 
            this.vACANCYBindingSource1.DataMember = "VACANCY";
            this.vACANCYBindingSource1.DataSource = this.projectDataSet2BindingSource;
            // 
            // projectDataSet2BindingSource
            // 
            this.projectDataSet2BindingSource.DataSource = this.projectDataSet2;
            this.projectDataSet2BindingSource.Position = 0;
            // 
            // projectDataSet2
            // 
            this.projectDataSet2.DataSetName = "ProjectDataSet2";
            this.projectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vACANCYBindingSource
            // 
            this.vACANCYBindingSource.DataMember = "VACANCY";
            this.vACANCYBindingSource.DataSource = this.projectDataSet2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(839, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(839, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(839, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(614, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Insert_JobTitle";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(614, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Insert_Old_JobTitle";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Location = new System.Drawing.Point(614, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Insert_JobTitle";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox4.Location = new System.Drawing.Point(614, 218);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Insert_New_JobTitle";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // vACANCYTableAdapter
            // 
            this.vACANCYTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(429, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 48);
            this.button4.TabIndex = 8;
            this.button4.Text = "Filter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(605, 259);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 9;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACANCYBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACANCYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private ProjectDataSet2 projectDataSet2;
        private System.Windows.Forms.BindingSource vACANCYBindingSource;
        private ProjectDataSet2TableAdapters.VACANCYTableAdapter vACANCYTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBSEEKERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vACANCYBindingSource1;
        private System.Windows.Forms.BindingSource projectDataSet2BindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}