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
namespace online_consultation_sys
{
    public partial class login : System.Windows.Forms.Form
    {
        string server_name = "Data Source = (local); Initial Catalog = online consultation system; Integrated Security = SSPI";
        public login()
        {
            InitializeComponent();
            incorrect.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(server_name);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from TbUser Where handle='" + user_text.Text + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)//kda tl3 handle user s7 
            {
                //const string V = "password";
                if ((string)reader["password"] == (string)pass_text.Text)//kda el password s7 
                {
                    //incorrect.Text = "The password and username are correct and you are user";
                    //incorrect.ForeColor = Color.FromArgb(0, 1, 0);
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();



                   // incorrect.Show();
                }
                    else//htlt3o msg ano el password8lt 
                    {
                    incorrect.Text = "The password incorrect";
                    incorrect.Show();
                }

            }
            else
            {
                reader.Close();
                SqlCommand cmdd1 = new SqlCommand("select * from TbExpert Where handle='" + user_text.Text + "'", con);
                SqlDataReader readerr = cmdd1.ExecuteReader();
                if (readerr.Read() == true)//kda tl3 expert we handlo s7 ;
                {
                    if ((string)readerr["password"] == (string)pass_text.Text)//kda el password s7 
                    {
                        incorrect.Text = "The password and username are correct and you are expert";
                        incorrect.ForeColor = Color.FromArgb(0, 1, 0);
                        incorrect.Show();
                    }
                    else//htlt3o msg ano el password8lt 
                    {
                        incorrect.Text = "The password incorrect";
                        incorrect.Show();
                    }
                }
                else
                {
                    incorrect.Text = "There is no user with this name try to sing up first";
                    incorrect.Show();
                    //hytl3lo msg ano m=lazm y3ml  sign up 
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 signUp_Expert = new Form1();
            signUp_Expert.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
                }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            SignUp_Expert signUp_Expert = new SignUp_Expert();           
            signUp_Expert.ShowDialog();
        }
    }
}
