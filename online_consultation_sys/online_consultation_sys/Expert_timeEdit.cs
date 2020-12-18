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
using System.Text.RegularExpressions;

namespace online_consultation_sys
{
    public partial class Form2 : Form
    {
        string servername = "Data Source=192.168.43.221;Initial Catalog=online consultation system;User ID=AS;Password=123456";
        SqlConnection con;
        
        string global_handle;
        int con_duration,end;
        bool valid , light_mode;
        public Form2(string handle , bool mode)
        {
            InitializeComponent();
            global_handle = handle;
            con = new SqlConnection(servername);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from TbExpert where handle='"+global_handle+"'", con);
  
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                con_duration = (int)reader["con_duration"];
            }
            reader.Close();
            con.Close();

            light_mode = mode;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            time_table();
            change_mode(light_mode);
        }

        void ADD()
        {
            end = Convert.ToInt32(time_box.Text.ToString()) + con_duration;

            con.Open();
            SqlCommand cmd = new SqlCommand("Add_Meetings", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(parameterName: "@handle", value: global_handle);
            cmd.Parameters.Add(parameterName: "@address", value: address_box.Text);
            cmd.Parameters.Add(parameterName: "@day", value: day_box.Text);
            cmd.Parameters.Add(parameterName: "@start", value: time_box.Text);
            cmd.Parameters.Add(parameterName: "@end", value: end );
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)//insert button
        {
            if(time_box.Text.Length>0)
            end = Convert.ToInt32(time_box.Text.ToString()) + con_duration;
            if (validation())
            {
                ADD();
                error.Hide();
                MessageBox.Show("meeting was added successfully");
                time_table();
            }
                        
        }

        public void Regexp(string re, TextBox tb, Label lb1, string s)
        {
            Regex regex = new Regex(re);
            if (!regex.IsMatch(tb.Text))
            {
                lb1.ForeColor = Color.Red;
                lb1.Text = s + " InValid";
                lb1.Show();
                valid = false;
            }
        }


        private bool validation()
        {
            valid = true;
            if(day_box.Text.Length==0)
            {
                error.ForeColor = Color.Red;
                error.Text = "Day not selected";
                error.Show();
                valid = false;
            }


            Regexp(@"^([\w]+)", address_box, error, "Address");
            Regexp(@"^[0-23]", time_box, error, "Time");
            if(valid)
            {
                if(!Valid())
                {
                    error.ForeColor = Color.Red;
                    error.Text = "The time is busy";
                    error.Show();
                    valid = false;

                }
            }


            return valid;

        }
        private bool Valid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Expert_Meetings", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(parameterName: "@handle", value: global_handle);
            cmd.Parameters.Add(parameterName: "@day", value: day_box.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((int)reader["time_start"] >= end || (int)reader["time_end"] <= Convert.ToInt32(time_box.Text.ToString()))
                    ;
                else
                {
                    reader.Close();
                    con.Close();
                    return false;
                }

            }
            reader.Close();
            con.Close();
            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void time_table()
        {
            dataGridView1.ClearSelection();
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from meeting Where exp_handle='" + global_handle + "'", con);
            
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for using Our system");
            this.Hide();
            login login = new login(light_mode);
            login.ShowDialog();

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expert_home login = new Expert_home(global_handle,light_mode);
            login.ShowDialog();

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
                this.BackgroundImage = Properties.Resources.expert;


                mode_buuton.ForeColor = Color.Blue;
                button1.ForeColor = Color.Blue;
                delete_button.ForeColor = Color.Blue;
                insert_button.ForeColor = Color.Blue;
                back_button.ForeColor = Color.Blue;
                dataGridView1.GridColor = Color.Black;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;

                mode_buuton.BackColor = Color.White;
                button1.BackColor = Color.White;
                delete_button.BackColor = Color.White;
                insert_button.BackColor = Color.White;
                back_button.BackColor = Color.White;
                dataGridView1.BackgroundColor = Color.SandyBrown;
                label1.BackColor = Color.White;
                label2.BackColor = Color.White;
                label3.BackColor = Color.White;
                label4.BackColor = Color.White;

            }
            else
            {
                this.BackgroundImage = null;
                this.BackColor = Color.Black;

                mode_buuton.ForeColor = Color.White;
                button1.ForeColor = Color.White;
                delete_button.ForeColor = Color.White;
                insert_button.ForeColor = Color.White;
                back_button.ForeColor = Color.White;
                dataGridView1.GridColor = Color.Blue;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;

                mode_buuton.BackColor = Color.Black;
                button1.BackColor = Color.Black;
                delete_button.BackColor = Color.Black;
                insert_button.BackColor = Color.Black;
                back_button.BackColor = Color.Black;
                dataGridView1.BackgroundColor = Color.Black;
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Black;

            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if(meeting_box.Text.Length > 0)
            {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from meeting where meeting_id ='" + meeting_box.Text + "' AND exp_handle ='" + global_handle + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    if((int)reader["is_valid"]==1)
                    {

                        reader.Close();
                        cmd = new SqlCommand("Delete_Meeting", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(parameterName: "@id", value: Convert.ToInt32(meeting_box.Text.ToString()));

                        cmd.ExecuteNonQuery();

                        label5.Hide();
                        MessageBox.Show("Meeting was deleted Successfully");

                        con.Close();
                        time_table();
                    }
                    else
                    {
                        label5.Text = "Meeting is busy";
                        label5.ForeColor = Color.Red;
                        label5.Show();
                       
                        reader.Close();
                    }
                }
                else
                {
                    label5.Text = "Meeting ID is not Valid";
                    label5.ForeColor = Color.Red;
                    label5.Show();

                    reader.Close();
                }
            con.Close();
            }
            else
            {
                label5.Text = "Meeting ID is empty";
                label5.ForeColor = Color.Red;
                label5.Show();
            }

        }

    }
}
