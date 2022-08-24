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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet2.VACANCY' table. You can move, or remove it, as needed.
            // this.vACANCYTableAdapter.Fill(this.projectDataSet2.VACANCY); 

            // TODO: This line of code loads data into the 'projectDataSet.VACANCY' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'onlineRecruitmentDataSet.VACANCY' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'onlineRecruitmentDataSet.VACANCY' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'onlineRecruitmentDataSet.VACANCY' table. You can move, or remove it, as needed.
            FetchData();

        }
        private void FetchData()
        {

            SqlConnection objConnection = new SqlConnection("Data Source=DESKTOp-O7M3KNK;Initial Catalog=Project;Integrated Security=True");
            string strCommand = "Select * from [dbo].[VACANCY]";
            SqlCommand com = new SqlCommand(strCommand, objConnection);
            objConnection.Open();
            com.CommandType = CommandType.Text;
            SqlDataReader reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                BindingSource objSource = new BindingSource();
                objSource.DataSource = reader;
                dataGridView1.DataSource = objSource;
            }
            reader.Close();
            objConnection.Close();
            objConnection.Dispose();
        }

        private void Filter()
        {

            SqlConnection objConnection = new SqlConnection("Data Source=DESKTOp-O7M3KNK;Initial Catalog=Project;Integrated Security=True");
            string strCommand = "SELECT distinct JOB_SEEKER.NAME FROM JOB_SEEKER,VACANCY,EMPLOYER WHERE JOB_SEEKER.ID = VACANCY.JOB_SEEKER__ID AND JOB_SEEKER.EXPERIENCE_LEVEL = '" + employer.experience_level + "' and JOB_SEEKER.INDUSTRY ='" + employer.industry + "'";
            SqlCommand com = new SqlCommand(strCommand, objConnection);
            objConnection.Open();
            com.CommandType = CommandType.Text;
            SqlDataReader reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                BindingSource objSource = new BindingSource();
                objSource.DataSource = reader;
                dataGridView2.DataSource = objSource;
            }
            reader.Close();
            objConnection.Close();
            objConnection.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id=0;
            SqlConnection con = new SqlConnection();
            string job = textBox3.Text;
            con.ConnectionString = "Data Source=DESKTOP-O7M3KNK;Initial Catalog=Project;Integrated Security=True";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = "select ID_VAC from VACANCY where JOBTITLE='"+job+"' and ID_EMP='"+employer.emlpoyer_id+"'";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader reader = com.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    id= int.Parse(reader[0].ToString());
                }
                SqlCommand cmd = new SqlCommand("Delete from VACANCY where VACANCY.ID_VAC = '" + id + "'", con);
                MessageBox.Show(cmd.CommandText);
                reader.Close();
                cmd.ExecuteNonQuery();
            } 
            else
            {
                MessageBox.Show("there Is No JobTitle with This Name ");
            }
            FetchData();
            con.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=DESKTOP-O7M3KNK;Initial Catalog=Project;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("Insert Into VACANCY (JOBTITLE,ID_EMP)" +
                "values ('" + textBox1.Text + "','"+employer.emlpoyer_id+"')", con);
            con.Open();
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
            FetchData();
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string old_job = textBox2.Text;
            string new_job = textBox4.Text;
            int id = 0;
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=DESKTOP-O7M3KNK;Initial Catalog=Project;Integrated Security=True";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = "select ID_VAC from VACANCY where JOBTITLE='" + old_job + "' and ID_EMP='" + employer.emlpoyer_id + "'";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = int.Parse(reader[0].ToString());
                }
                SqlCommand cmd = new SqlCommand("update VACANCY set JOBTITLE = '" + textBox4.Text + "' where ID_VAC = '" + id + "'", con);
                MessageBox.Show(cmd.CommandText);
                reader.Close();
                cmd.ExecuteNonQuery();
            }
            FetchData();
            con.Close();
            reader.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
