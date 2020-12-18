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
        string server_name = "Data Source=192.168.43.221;Initial Catalog=online consultation system;User ID=AS;Password=123456";
        bool light_mode;
        public login(bool mode)
        {
            InitializeComponent();
            incorrect.Hide();
            light_mode = mode;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user_text.Text == "admin" && pass_text.Text == "admin")
            {
                this.Hide();
                Admin admin = new Admin();
                admin.ShowDialog();
            }
            else
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
           
                        this.Hide();
                        Home home = new Home(user_text.Text,light_mode);
                        home.ShowDialog();

                        // incorrect.Show();
                    }
                    else//htlt3o msg ano el password8lt 
                    {
                        incorrect.Text = "The password incorrect";
                        incorrect.Show();
                    }
                    reader.Close();

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
                            Expert_home expert_Home = new Expert_home((string)readerr["handle"],light_mode);
                            this.Hide();
                            expert_Home.ShowDialog();
                        }
                        else//htlt3o msg ano el password8lt 
                        {
                            incorrect.Text = "The password incorrect";
                            incorrect.Show();
                        }
                    }
                    else
                    {
                        incorrect.Text = "There is no user with this name try to sign up first";
                        incorrect.Show();
                        //hytl3lo msg ano m=lazm y3ml  sign up 
                    }
                    readerr.Close();
                }
                con.Close();
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
            Form1 signUp_Expert = new Form1(light_mode);
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
            change_mode(light_mode);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            SignUp_Expert signUp_Expert = new SignUp_Expert(light_mode);           
            signUp_Expert.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            light_mode = !light_mode;
            change_mode(light_mode);
        }

        private void change_mode(bool light_mode)
        {
            if (light_mode)
            {
                this.BackgroundImage = Properties.Resources.sign_in;

                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                Exprt_button.BackColor = Color.White;
                user_button.BackColor = Color.White;
                mode_buuton.BackColor = Color.White;

                button1.ForeColor = Color.Blue;
                button2.ForeColor = Color.Blue;
                Exprt_button.ForeColor = Color.Black;
                user_button.ForeColor = Color.Black;
                mode_buuton.ForeColor = Color.Blue;

                label1.BackColor = Color.White;
                label2.BackColor = Color.White;
                label3.BackColor = Color.White;
                label6.BackColor = Color.White;
                incorrect.BackColor = Color.White;

                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Blue;
                label6.ForeColor = Color.Blue;
            }
            else
            {
                this.BackgroundImage = null;
                this.BackColor = Color.Black;

                button1.BackColor = Color.Black;
                button2.BackColor = Color.Black;
                Exprt_button.BackColor = Color.Black;
                user_button.BackColor = Color.Black;
                mode_buuton.BackColor = Color.Black;

                button1.ForeColor = Color.White;
                button2.ForeColor = Color.White;
                Exprt_button.ForeColor = Color.White;
                user_button.ForeColor = Color.White;
                mode_buuton.ForeColor = Color.White;

                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label6.BackColor = Color.Black;
                incorrect.BackColor = Color.LightBlue;

                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label6.ForeColor = Color.White;
            }
        }
    }
}
