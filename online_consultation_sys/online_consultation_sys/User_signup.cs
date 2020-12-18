using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace online_consultation_sys

{
    public partial class Form1 : Form
    {
        bool valid = true;
        string server_name = "Data Source=192.168.43.221;Initial Catalog=online consultation system;User ID=AS;Password=123456";

        SqlConnection connect;
        bool light_mode;
        public Form1(bool mode)
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.im_;
            connect = new SqlConnection(server_name);

            light_mode = mode;
        }
        void timer_Tick(object sender, EventArgs e)
        {
            List<Bitmap> lisimage = new List<Bitmap>();
            lisimage.Add(Properties.Resources.im_);
            lisimage.Add(Properties.Resources.im_);
            var indexbackimage = DateTime.Now.Second % lisimage.Count;
            this.BackgroundImage = lisimage[indexbackimage];
        }
        private bool validation()
        {
            valid = true;

            Regexp(@"^([\w]+)", name_box, pictureBox4, lb1name, "Name");
            Regexp(@"^([\w]+)", handle_box, pictureBox3, lb1handle, "Handle");
            Regexp(@"^([\w]+)@([\w]+)\.([\w]+)$", e_mail_box, pictureBox1, lb1email, "E_mail");
            Regexp(@"^(01)([0-9]{9})$", phone_box, pictureBox5, lb1phone, "phone_number");
            Unique(handle_box, pictureBox3, lb1handle, "handle");
           Unique(e_mail_box, pictureBox1, lb1email, "e_mail");

            pass(pass_box, pictureBox2, lb1pas);
            co_pass(pictureBox6, lb1co_pas, "co_password");
            if (gender_box.Text.Length == 0)
                valid = false;
            return valid; 
        }
        
        public void  Regexp (string re , TextBox tb ,PictureBox pc , Label lb1 , string s)
        {
            Regex regex = new Regex(re);
            if(regex.IsMatch(tb.Text) && !(tb.Text == "admin"))
            {
                pc.Image = Properties.Resources.v1;
                pc.Show();
                lb1.ForeColor = Color.Green;
                lb1.Text= s + " Valid";
                lb1.Show();
            }
            else
            {
                pc.Image = Properties.Resources.in1;
                pc.Show();
                lb1.ForeColor = Color.Red;
                lb1.Text = s + " InValid";
                lb1.Show();
                valid = false;

            }

        }
        public void pass( TextBox tb, PictureBox pc, Label lb1)
        {

            if(tb.Text.Length>=8&& tb.Text.Length<=32)
            {
                pc.Image = Properties.Resources.v1;
                pc.Show();
                lb1.ForeColor = Color.Green;
                lb1.Text =  "Password Valid";
                lb1.Show();

            }
            else
            {
                pc.Image = Properties.Resources.in1;
                pc.Show();
                lb1.ForeColor = Color.Red;
                lb1.Text = "Password Must Contain 8 : 32 Characters";
                lb1.Show();
                valid = false;

            }
        }
        public void co_pass( PictureBox pc, Label lb1, string s)
        {
              
            if ( pass_box.Text == textBox5.Text&& textBox5.Text.Length>0)
                
             {
                pc.Image = Properties.Resources.v1;
                pc.Show();
                lb1.ForeColor = Color.Green;
                lb1.Text= s + " matching";
                lb1.Show();
            }
            else
            {
               pc.Image = Properties.Resources.in1;
                pc.Show();
                lb1.ForeColor = Color.Red;
                lb1.Text = s + " not matching";
                lb1.Show();
                valid = false;
            }

        }
  
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        ///
        private void Unique(TextBox tb, PictureBox pc, Label lb1, string s)
        {
            if (tb.Text.Length > 0)
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("select * from TbUser Where " + s + "= '" + tb.Text+ "'", connect);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)//kda tl3 handle user s7 
                {
                    pc.Image = Properties.Resources.in1;
                    lb1.ForeColor = Color.Red;
                    lb1.Text = s + " is used before";
                    lb1.Show();
                    valid = false;
                    reader.Close();

                }
                else
                {
                    reader.Close();
                    SqlCommand cmdd1 = new SqlCommand("select * from TbExpert Where " + s + "= '" + tb.Text + "'", connect);
                    SqlDataReader readerr = cmdd1.ExecuteReader();
                    if (readerr.Read() == true)//kda tl3 expert we handlo s7 ;
                    {
                        pc.Image = Properties.Resources.in1;
                        lb1.ForeColor = Color.Red;
                        lb1.Text = s + " is used before";
                        lb1.Show();
                        valid = false;


                    }
                    readerr.Close();

                }
                connect.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            change_mode(light_mode);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lb1pas_Click(object sender, EventArgs e)
        {

        }

        private void lb1name_Click(object sender, EventArgs e)
        {

        }

        private void gender_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //  mail@mail.com                        => ^([\w]+)@([\w]+)\.([\w]+)$
            //  http://www.google.com                => ^(http://www\.)([\w]+)\.([\w]+)$
            //  Phone Number like : 0011 XXX XXX XXX => ^(0011)(([ ][0-9]{3}){3})$
            //  Date XX/XX/XXXX                      => ^([0-9]{2})\/([0-9]{2})\/([0-9]{4})$
            if (validation())
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("user_register", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(parameterName: "@handle", value: handle_box.Text);
                cmd.Parameters.Add(parameterName: "@phone", value: phone_box.Text);
                cmd.Parameters.Add(parameterName: "@name", value: name_box.Text);
                cmd.Parameters.Add(parameterName: "@pass", value: pass_box.Text);
                cmd.Parameters.Add(parameterName: "@e_mail", value: e_mail_box.Text);
                cmd.Parameters.Add(parameterName: "@gender", value: gender_box.Text);

                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Successfully Rgistred");
                this.Hide();
                login login = new login(light_mode);
                login.ShowDialog();

            }
        }

        private void Mode_buuton_Click(object sender, EventArgs e)
        {
            light_mode = !light_mode;
            change_mode(light_mode);
        }

        private void change_mode(bool light_mode)
        {
            if (light_mode)
            {
                groupBox1.BackgroundImage = Properties.Resources._66;
                groupBox1.BackColor = Color.White;
                groupBox1.ForeColor = Color.Black;

                bunifuThinButton21.BackColor = Color.White;

                mode_buuton.BackColor = Color.White;
                mode_buuton.ForeColor = Color.Blue;

            }
            else
            {
                groupBox1.BackgroundImage = null;
                groupBox1.BackColor = Color.Black;
                groupBox1.ForeColor = Color.White;

                bunifuThinButton21.BackColor = Color.Black;

                mode_buuton.BackColor = Color.Black;
                mode_buuton.ForeColor = Color.White;

            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login home = new login(light_mode);
            home.ShowDialog();
        }
    }
 
}

