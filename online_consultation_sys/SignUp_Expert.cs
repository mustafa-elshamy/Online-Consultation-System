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
        string server_name = "Data Source = (local); Initial Catalog = online consultation system; Integrated Security = SSPI";
        SqlConnection connect;
        bool ready = false;
        public SignUp_Expert()
        {
            InitializeComponent();
            connect = new SqlConnection(server_name);
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
            if (regex.IsMatch(tb.Text))
            {
                pc.Image = Properties.Resources.valid;
                lb1.ForeColor = Color.Green;
                lb1.Text = s + " Valid";
                lb1.Show();
            }
            else
            {
                pc.Image = Properties.Resources.invalid;
                lb1.ForeColor = Color.Red;
                lb1.Text = s + " InValid";
                lb1.Show();
                ready = false;

            }

        }

        public void insert_date()
        {

        }


        public void co_pass(string v, TextBox tb, PictureBox pc, Label lb1, string s)
        {
            Regex pass = new Regex(v);
            if (pass.IsMatch(tb.Text) && pass_box.Text == co_pass_box.Text)
            {
                pc.Image = Properties.Resources.valid;
                lb1.ForeColor = Color.Green;
                lb1.Text = s + " not matching";
                lb1.Show();
                ready = false;
            }

            else
            {
                pc.Image = Properties.Resources.invalid;
                lb1.ForeColor = Color.Red;
                lb1.Text = s + " matching";
                lb1.Show();

            }

        }

        private void Sign_Up_Click(object sender, EventArgs e)
        {
            //  mail@mail.com                        => ^([\w]+)@([\w]+)\.([\w]+)$
            //  http://www.google.com   => ^(http://www\.)([\w]+)\.([\w]+)$
            //   https://github.com/Manar-kotb
            //  Phone Number like : 0011 XXX XXX XXX => ^(0011)(([ ][0-9]{3}){3})$
            //  Date XX/XX/XXXX                      => ^([0-9]{2})\/([0-9]{2})\/([0-9]{4})$

            ready = true;
            Regexp(@"^([\w]+) ([\w]+)", name_box, pictureBox4, lb1name, "Name");
            Regexp(@"^([\w]+)_([\w]+)", handle_box, pictureBox3, lb1handle, "Handel");
            Regexp(@"^([\w]+)@([\w]+)\.([\w]+)$", email_box, pictureBox1, lb1email, "E_mail");
            Regexp(@"^([0-9]{6})$", pass_box, pictureBox2, lb1pas, "password");
            Regexp(@"^([0-9]{6})$", co_pass_box, pictureBox6, lb1co_pas, "co_password");
            Regexp(@"^(2019)(190)([0-9]{3})$", field_box, pictureBox7, lb1id, "Id");
            Regexp(@"^([0-9]{1})$", duration_box, pictureBox11, lb1hour, "Duration");
            Regexp(@"^(https://github\.)([\w]+)/([\w]+)$", cv_box, pictureBox10, lb1cv, "Cv");
            Regexp(@"^([0-9]{2}(%))$", fees_box, pictureBox9, lb1rate, "fees");
            Regexp(@"^([0-9]{15})$", creadit_box, pictureBox5, lb1c_n, "phone_number");
            //co_pass(@"^([0-9]{9})$", pass_box, pictureBox2, lb1pas, "password");
            // co_pass(@"^(01)([0-9]{9})$", co_pass_box, pictureBox6, lb1co_pas, "co_password");
            if (ready || true) 
            {

                connect.Open();
                string com = @"insert into TbExpert(handle, name, con_duration ,e_mail ,password,cv,creadit_number ,phone,fees ,gender) values
                (@handle_var,@name_var,@con_duration_var ,@e_mail_var ,@password_var,@cv_var,@creadit_number_var ,@phone_var,@fees_var ,@gender_var)";
                SqlCommand cmd = new SqlCommand(com, connect);
                cmd.Parameters.Add(new SqlParameter("@handle_var", handle_box.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@name_var", name_box.Text.ToString()));
               // cmd.Parameters.Add(new SqlParameter("@rate_var", (float)0));
                cmd.Parameters.Add(new SqlParameter("@con_duration_var", Convert.ToDouble(duration_box.Text.ToString())));
                cmd.Parameters.Add(new SqlParameter("@e_mail_var", email_box.Text.ToString()));
              //  cmd.Parameters.Add(new SqlParameter("@fiel_id_var", Convert.ToInt32(field_box.Text.ToString())));
                cmd.Parameters.Add(new SqlParameter("@password_var", pass_box.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@cv_var", cv_box.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@creadit_number_var", creadit_box.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@phone_var", "01154360039" )) ;
                cmd.Parameters.Add(new SqlParameter("@fees_var", Convert.ToInt32(fees_box.Text.ToString())));
                cmd.Parameters.Add(new SqlParameter("@gender_var",  gender_box.ToString()));
                cmd.ExecuteNonQuery();
                connect.Close();

                MessageBox.Show("congratulation");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
