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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet2.VACANCY' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'projectDataSet1.VACANCY' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'projectDataSet.JOB_SEEKER' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'projectDataSet.VACANCY' table. You can move, or remove it, as needed.
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
            string strCommand = "select distinct VACANCY.JOBTITLE from VACANCY ,EMPLOYER,JOB_SEEKER where VACANCY.ID_EMP = EMPLOYER.ID_EMP and EMPLOYER.EXPERIENCE_REQUIRED = '"+Variables.experience_level+"' and EMPLOYER.INDUSTRY_EMP = '"+Variables.industry+"'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string job = textBox1.Text;
            SqlConnection con = new SqlConnection(); 
            con.ConnectionString = "Data Source=DESKTOP-O7M3KNK;Initial Catalog=Project;Integrated Security=True";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = "select *  from VACANCY where JOB_SEEKER__ID IS NOT NULL and JOBTITLE='"+job+"'";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("The Job Is Already Taken");
                reader.Close();
            }
            else
            {
                reader.Close();
                SqlCommand cmd = new SqlCommand("update VACANCY set JOB_SEEKER__ID =  '" + Variables.user_id + "'where VACANCY.JOBTITLE='" + textBox1.Text + "'", con);
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                FetchData();
                con.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();


            con.ConnectionString = "Data Source=DESKTOP-O7M3KNK;Initial Catalog=Project;Integrated Security=True";
            SqlCommand cmd = new SqlCommand ("update JOB_SEEKER set SAVED_TITLES  ='" + textBox2.Text + "'where ID ='"+Variables.user_id+"'",con);

            con.Open();
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Filter();   
        }
    }
}
