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

namespace online_consultation_sys
{
    public partial class show_expert : Form
    {
        string server_name = "Data Source=192.168.43.221;Initial Catalog=online consultation system;User ID=AS;Password=123456";
       
        SqlConnection connect;

        string global_handle;
        string exp_handle;
        int last_salary, fee;
        int field_id;

        bool light_mode;
        public show_expert(string h,string e , bool mode)
        {
            InitializeComponent();
            connect = new SqlConnection(server_name);
            exp_handle = h;
            global_handle = e;

            light_mode = mode;
        }

        private void show_expert_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from TbExpert inner join TbField on TbExpert.field_id = TbField.id where handle ='" + exp_handle + "'", connect);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                expert_name.Text = (string)reader["name"];
                field_name.Text = (string)reader[14];// 14= index of field name 
                rate.Text = ((double)reader["rate"]).ToString();
                gender.Text = (string)reader["gender"];
                duration.Text = ((int)reader["con_duration"]).ToString();
                fees.Text = ((int)reader["fees"]).ToString(); ;
                fee = (int)reader["fees"];
                last_salary = (int)reader["week_salary"];
                field_id = (int)reader["field_id"];
            }


           reader.Close();
            connect.Close();
            time_table();

            change_mode(light_mode);
        }
        private void time_table()
        {
            meeting_table.ClearSelection();
            connect.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select meeting_id,address,day,time_start,time_end from meeting where exp_handle ='" + exp_handle + "' And is_valid = 1", connect);
            
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            meeting_table.DataSource = dt;
            connect.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for using Our system");
            this.Hide();
            login login = new login(light_mode);
            login.ShowDialog();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Field feild = new Field(field_id,global_handle,light_mode);
            feild.ShowDialog();
        }

        private void meeting_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void meeting_id_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void message_Click(object sender, EventArgs e)
        {

        }

        private void gender_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rate_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fees_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void duration_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void field_name_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void expert_name_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                this.BackgroundImage = Properties.Resources.login;

                button1.ForeColor = Color.Black;
                mode_buuton.ForeColor = Color.Black;
                back_button.ForeColor = Color.Black;
                Confirm_button.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                expert_name.ForeColor = Color.Black;
                field_name.ForeColor = Color.Black;
                rate.ForeColor = Color.Black;
                gender.ForeColor = Color.Black;
                duration.ForeColor = Color.Black;
                fees.ForeColor = Color.Black;
                meeting_table.GridColor = Color.Black;


                button1.BackColor = Color.White;
                mode_buuton.BackColor = Color.White;
                back_button.BackColor = Color.White;
                Confirm_button.BackColor = Color.White;
                label1.BackColor = Color.White;
                label2.BackColor = Color.White;
                label3.BackColor = Color.White;
                label4.BackColor = Color.White;
                label5.BackColor = Color.White;
                label6.BackColor = Color.White;
                label7.BackColor = Color.White;
                expert_name.BackColor = Color.White;
                field_name.BackColor = Color.White;
                rate.BackColor = Color.White;
                gender.BackColor = Color.White;
                duration.BackColor = Color.White;
                fees.BackColor = Color.White;
                message.BackColor = Color.White;
                meeting_table.BackgroundColor = Color.LightBlue;
            }
            else
            {
                this.BackgroundImage = null;
                this.BackColor = Color.Black;

                button1.ForeColor = Color.White;
                mode_buuton.ForeColor = Color.White;
                back_button.ForeColor = Color.White;
                Confirm_button.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                expert_name.ForeColor = Color.White;
                field_name.ForeColor = Color.White;
                rate.ForeColor = Color.White;
                gender.ForeColor = Color.White;
                duration.ForeColor = Color.White;
                fees.ForeColor = Color.White;
                meeting_table.GridColor = Color.Blue;


                button1.BackColor = Color.Black;
                mode_buuton.BackColor = Color.Black;
                back_button.BackColor = Color.Black;
                Confirm_button.BackColor = Color.Black;
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;
                label4.BackColor = Color.Black;
                label5.BackColor = Color.Black;
                label6.BackColor = Color.Black;
                label7.BackColor = Color.Black;
                expert_name.BackColor = Color.Black;
                field_name.BackColor = Color.Black;
                rate.BackColor = Color.Black;
                gender.BackColor = Color.Black;
                duration.BackColor = Color.Black;
                fees.BackColor = Color.Black;
                message.BackColor = Color.Black;
                meeting_table.BackgroundColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (meeting_id_box .Text.Length == 0)
            {
                message.ForeColor = Color.Red;
                message.Text = "Meeting ID is Empty";
                
            }
            else
            {
             connect.Open();
            SqlCommand cmd = new SqlCommand("select * from meeting where exp_handle =@handle And is_valid = 1 AND meeting_id = @id", connect);
                cmd.Parameters.Add("@handle", exp_handle);
                cmd.Parameters.Add("@id", meeting_id_box.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    SqlCommand command = new SqlCommand("update meeting set user_handle = '" + global_handle + "' , is_valid = 0 where meeting_id = '" + meeting_id_box.Text.ToString() + "'", connect);
                    command.ExecuteNonQuery();
                    last_salary += fee;
                    command = new SqlCommand("update TbExpert set week_salary ='"+last_salary.ToString()+"'where handle = '"+exp_handle+"'", connect);
                   // cmd.Parameters.Add("@handle", expert_name);
                    command.ExecuteNonQuery();
                    connect.Close();
                    time_table();
                    message.ForeColor = Color.Green;
                    message.Text = "Meeeting was booked successfuly";


                }
                else
                {
                    message.ForeColor = Color.Red;
                    message.Text = "Meeting ID Not Valid";
                    reader.Close();
                }

                connect.Close();
            }


            //Refresh();
        }
    }
}
