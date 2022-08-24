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



namespace Recruitment 

{ 
    
    public partial class Form3 : Form
    { 
        public Form3()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Variables.experience_level = textBox4.Text;
            Variables.industry = textBox3.Text;
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=DESKTOP-O7M3KNK;Initial Catalog=Project;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("update JOB_SEEKER set TELEPHONE='" + textBox1.Text + "'" +
                ",LOCATION='" + textBox2.Text + "',INDUSTRY='" + textBox3.Text + "',EXPERIENCE_LEVEL='" + textBox4.Text + "'where JOB_SEEKER.ID='"+Variables.user_id+"'",con); 

            con.Open();
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
            con.Close();
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
