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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            employer.emlpoyer_id = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox4.Text;
            string email = textBox6.Text;
            employer.experience_level = textBox2.Text;
            employer.industry = textBox3.Text;

            SqlConnection con = new SqlConnection();
            SqlCommand com = new SqlCommand();
            con.ConnectionString = "Data Source=DESKTOP-O7M3KNK;Initial Catalog=Project;Integrated Security=True";
            con.Open();
            com.CommandText = "select ID_EMP from EMPLOYER where NAME_EMP='" + name+"' and E_MAIL_EMP='"+email+"'";
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                employer.emlpoyer_id = int.Parse(reader[0].ToString());
            }
            if (reader.HasRows)
            {
                Form4 obj_form4 = new Form4();
                obj_form4.Show();
                this.Hide();
            } 
            else
            {
                SqlCommand cmd = new SqlCommand("Insert Into EMPLOYER (COMPANY_NAME,EXPERIENCE_REQUIRED,INDUSTRY_EMP,NAME_EMP,E_MAIL_EMP,PASSWORD_EMP)" +
               "values ( '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox5.Text + "')", con);
                MessageBox.Show(cmd.CommandText);
                reader.Close();
                cmd.ExecuteNonQuery();

                com.CommandText = "select ID_EMP from EMPLOYER where NAME_EMP='" + name + "' and E_MAIL_EMP='" + email + "'";
                com.Connection = con;
                com.CommandType = CommandType.Text;
                SqlDataReader reader1 = com.ExecuteReader();
                while (reader1.Read())
                {
                    employer.emlpoyer_id = int.Parse(reader1[0].ToString());
                }

                con.Close();
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();

            }
            
        }

        
    }
}
static class employer
{
    public static int emlpoyer_id;
    public static string experience_level="";
    public static string industry ="";
}
