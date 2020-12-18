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
    public partial class SignUp_Expert : Form
    {
        string server_name = "Data Source=192.168.43.221;Initial Catalog=online consultation system;User ID=AS;Password=123456";
        SqlConnection connect;
        bool valid = false;
        int field_id = 0;
        bool light_mode;
        public SignUp_Expert(bool mode)
        {
            InitializeComponent();
            connect = new SqlConnection(server_name);
            light_mode = mode;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void Regexp(string re, TextBox tb, PictureBox pc, Label lb1, string s)
        {
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text) && !(tb.Text == "admin"))
            {
                pc.Image = Properties.Resources.valid;
                pc.Show();
                lb1.ForeColor = Color.Green;
                lb1.Text = s + " Valid";
                lb1.Show();
            }
            else
            {
                pc.Image = Properties.Resources.invalid;
                pc.Show();
                lb1.ForeColor = Color.Red;
                lb1.Text = s + " InValid";
                lb1.Show();
                valid = false;

            }

        }

        public void insert_date()
        {

        }

        public void pass(TextBox tb, PictureBox pc, Label lb1)
        {

            if (tb.Text.Length >= 8 && tb.Text.Length <= 32)
            {
                pc.Image = Properties.Resources.v1;
                pc.Show();
                lb1.ForeColor = Color.Green;
                lb1.Text = "Password Valid";
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
        public void co_pass(PictureBox pc, Label lb1, string s)
        {

            if (pass_box.Text == co_pass_box.Text && co_pass_box.Text.Length > 0)

            {
                pc.Image = Properties.Resources.v1;
                pc.Show();
                lb1.ForeColor = Color.Green;
                lb1.Text = s + " matching";
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
        private void Unique(TextBox tb, PictureBox pc, Label lb1, string s)
        {
            if (tb.Text.Length > 0 && !(tb.Text == "admin"))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("select * from TbUser Where " + s + "= '" + tb.Text + "'", connect);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    pc.Image = Properties.Resources.in1;
                    pc.Show();
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
                    if (readerr.Read() == true)
                    {
                        pc.Image = Properties.Resources.in1;
                        pc.Show();
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
        private int feild_Id(string feild)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select id from TbField where name = '" + feild + "'", connect);
            cmd.CommandType = CommandType.Text;
            SqlDataReader read = cmd.ExecuteReader();
           
            if (read.Read())
            {
                int x = (int)read["id"];
                read.Close();
                connect.Close();
                return x;
            }
            else
            {
                read.Close();
                connect.Close();
                return -1;
            }
            

        }

        private bool validation()
        {
            valid = true;
            Regexp(@"^([\w]+)", name_box, pictureBox4, lb1name, "Name");
            Regexp(@"^([\w]+)", handle_box, pictureBox3, lb1handle, "Handle");
            Regexp(@"^([\w]+)@([\w]+)\.([\w]+)$", email_box, pictureBox1, lb1email, "E_mail");
            Regexp(@"^([1-9]{1})$", duration_box, pictureBox11, lb1hour, "Duration");
            Regexp(@"^(https://github\.)([\w]+)/([\w]+)$", cv_box, pictureBox10, lb1cv, "Cv");
            Regexp(@"^([0-9]{1})", fees_box, pictureBox9, lb1rate, "fees");
            Regexp(@"^(01)([0-9]{9})$", phone_box, pictureBox8, label3, "phone_number");
            Regexp(@"^([0-9]{16})$", creadit_box, pictureBox5, lb1c_n, "Credit Number");


            field_id = feild_Id(field_box.Text.ToString());
            if (field_id == -1)
            {
                pictureBox7.Image = Properties.Resources.invalid;
                pictureBox7.Show();
                lb1id.ForeColor = Color.Red;
                lb1id.Text = " Field does not exist";
                lb1id.Show();
                valid = false;
            }
            else
            {
                pictureBox7.Image = Properties.Resources.v1;
                pictureBox7.Show();
                lb1id.ForeColor = Color.Green;
                lb1id.Text = " Field is Valid";
                lb1id.Show();


            }
            if (creadit_box.Text.Length != 16)
            {

                pictureBox5.Image = Properties.Resources.invalid;
                pictureBox5.Show();
                lb1c_n.ForeColor = Color.Red;
                lb1c_n.Text = "Credit Number InValid";
                lb1c_n.Show();
                valid = false;

            }
            Unique(handle_box, pictureBox3, lb1handle, "handle");
            Unique(email_box, pictureBox1, lb1email, "e_mail");

            pass(pass_box, pictureBox2, lb1pas);
            co_pass(pictureBox6, lb1co_pas, "co_password");
            if (gender_box.Text.Length == 0)
                valid = false;



            return valid;


        }
     

        private void Form1_Load(object sender, EventArgs e)
        {
            change_mode(light_mode);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //  mail@mail.com                        => ^([\w]+)@([\w]+)\.([\w]+)$
            //  http://www.google.com   => ^(http://www\.)([\w]+)\.([\w]+)$
            //   https://github.com/Manar-kotb
            //  Phone Number like : 0011 XXX XXX XXX => ^(0011)(([ ][0-9]{3}){3})$
            //  Date XX/XX/XXXX                      => ^([0-9]{2})\/([0-9]{2})\/([0-9]{4})$


            if (validation())
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("expert_register", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(parameterName: "@handle", value: handle_box.Text);
                cmd.Parameters.Add(parameterName: "@phone", value: phone_box.Text);
                cmd.Parameters.Add(parameterName: "@name", value: name_box.Text);
                cmd.Parameters.Add(parameterName: "@pass", value: pass_box.Text);
                cmd.Parameters.Add(parameterName: "@e_mail", value: email_box.Text);
                cmd.Parameters.Add(parameterName: "@gender", value: gender_box.Text);
                cmd.Parameters.Add(parameterName: "@duration", value: duration_box.Text);
                cmd.Parameters.Add(parameterName: "@field", value: field_id);
                cmd.Parameters.Add(parameterName: "@cv", value: cv_box.Text);
                cmd.Parameters.Add(parameterName: "@credit", value: creadit_box.Text);
                cmd.Parameters.Add(parameterName: "@fees", value: fees_box.Text);





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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login home = new login(light_mode);
            home.ShowDialog();
        }
    }
}
