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
    

    public partial class Form1 : Form
    {
       
        public Form1()
        {
    
            InitializeComponent();
            Variables.user_id = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            string user_name;
            string email;
            string pass;
            user_name = textBox1.Text;
            email = textBox2.Text;
            pass = textBox3.Text;
            con.ConnectionString = "Data Source=DESKTOP-O7M3KNK;Initial Catalog=Project;Integrated Security=True";
            

            con.Open();

            SqlCommand com = new SqlCommand();
            com.CommandText = "Select * from [dbo].[JOB_SEEKER] where [NAME]=N'" + user_name+ "' and [E_MAIL]='" + email + "' ";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader reader1 = com.ExecuteReader();
            if (reader1.HasRows)
            { 
                MessageBox.Show("the Email Already Taken");
                reader1.Close();
            }  
            else
            {
                reader1.Close();
                SqlCommand cmd = new SqlCommand("Insert Into JOB_SEEKER (NAME,E_MAIL,PASSWORD)" +
                "values ( '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", con);
                MessageBox.Show(cmd.CommandText);
                 cmd.ExecuteNonQuery();
                com.CommandText = "select ID from JOB_SEEKER where JOB_SEEKER. NAME='" + user_name + "'";
                com.Connection = con;
                com.CommandType = CommandType.Text;
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Variables.user_id = int.Parse(reader[0].ToString());
                }
                reader.Close();

            }
           
            con.Close(); 
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name; 
            string email;
            email= textBox2.Text;
            string pass;
            pass =  textBox3.Text;
            name = textBox1.Text;

           
            SqlConnection objConnection = new SqlConnection("Data Source=DESKTOp-O7M3KNK;Initial Catalog=Project;Integrated Security=True");
            string strCommand = "Select * from [dbo].[JOB_SEEKER] where [NAME]=N'"+name+"' and [E_MAIL]='"+email+"' and [PASSWORD]='"+pass+"'";
            SqlCommand com = new SqlCommand(strCommand, objConnection);
            objConnection.Open();
            com.CommandType = CommandType.Text;
            SqlDataReader reader = com.ExecuteReader();
            if(reader.HasRows)
            {
                reader.Read();
                Variables.user_id = int.Parse(reader[0].ToString());
                Variables.industry=reader[5].ToString();
                Variables.experience_level = reader[6].ToString();
                Form5 objForm = new Form5();
                objForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
            reader.Close();
            objConnection.Close();
            objConnection.Dispose();     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
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
    }
}
static class Variables
{
    public static int user_id;
    public static string experience_level="";
    public static string industry=""; 
}