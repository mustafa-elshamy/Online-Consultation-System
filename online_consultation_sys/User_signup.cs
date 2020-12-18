using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.im_;
            //change the background image every second  
           
            /*var timer = new Timer();
            timer.Interval = 100000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();*/
        }
        void timer_Tick(object sender, EventArgs e)
        {
             
            List<Bitmap> lisimage = new List<Bitmap>();
            lisimage.Add(Properties.Resources.im_);
            lisimage.Add(Properties.Resources.im_);
            var indexbackimage = DateTime.Now.Second % lisimage.Count;
            this.BackgroundImage = lisimage[indexbackimage];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
        public void  Regexp (string re , TextBox tb ,PictureBox pc , Label lb1 , string s)
        {
            Regex regex = new Regex(re);
            if(regex.IsMatch(tb.Text))
            {
                pc.Image = Properties.Resources.v1;
                lb1.ForeColor = Color.Green;
                lb1.Text= s + " Valid";
                lb1.Show();
            }
            else
            {
               pc.Image = Properties.Resources.in1;
                lb1.ForeColor = Color.Red;
                lb1.Text = s + " InValid";
                lb1.Show();
                
            }
            
        }
        public void co_pass( string v ,TextBox tb, PictureBox pc, Label lb1, string s)
        {
               Regex pass= new  Regex(v);
            if (pass.IsMatch(tb.Text)  && textBox4.Text == textBox5.Text)
                
             {
                pc.Image = Properties.Resources.v1;
                lb1.ForeColor = Color.Green;
                lb1.Text= s + " matching";
                lb1.Show();
            }
                
            else
            {
               pc.Image = Properties.Resources.in1;
                lb1.ForeColor = Color.Red;
                lb1.Text = s + " not matching";
                lb1.Show();
                
            }

        }
  
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void Sign_Up_Click(object sender, EventArgs e)
        {
            //  mail@mail.com                        => ^([\w]+)@([\w]+)\.([\w]+)$
            //  http://www.google.com                => ^(http://www\.)([\w]+)\.([\w]+)$
            //  Phone Number like : 0011 XXX XXX XXX => ^(0011)(([ ][0-9]{3}){3})$
            //  Date XX/XX/XXXX                      => ^([0-9]{2})\/([0-9]{2})\/([0-9]{4})$
            Regexp(@"^([\w]+)([\w]+)", textBox1, pictureBox4, lb1name, "Name");
            Regexp(@"^([\w]+)_([\w]+)", textBox2, pictureBox3, lb1handle, "Handel");
            
            Regexp(@"^([\w]+)@([\w]+)\.([\w]+)$", textBox3, pictureBox1, lb1email, "E_mail");

            Regexp(@"^([0-9]{10})$", textBox4, pictureBox2, lb1pas, "password");
            Regexp(@"^([0-9]{10})$", textBox5, pictureBox6, lb1co_pas, "co_password");

            Regexp(@"^(01)([0-9]{9})$", textBox6, pictureBox5, lb1phone , "phone_number");

            co_pass(@"^([0-9]{9})$", textBox4, pictureBox2, lb1pas, "password");
            co_pass(@"^(01)([0-9]{9})$", textBox5, pictureBox6, lb1co_pas, "co_password");
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
 
}

