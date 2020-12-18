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
    public partial class Admin : Form
    {
        string server = "Data Source=192.168.43.221;Initial Catalog=online consultation system;User ID=AS;Password=123456";
        string selected_command, selected_type;
        SqlConnection connect;
        Stack<String> handle;
        public Admin()
        {
            InitializeComponent();
            connect = new SqlConnection(server);
            handle = new Stack<string>();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_command = this.command_box.GetItemText(this.command_box.SelectedItem);
            if (selected_command == "Add")
            {
                type_box.Items.Clear();
                type_box.Items.Add("Field");
                confirm.Text = "Add";
                label5.Text = "Field Name:";
            }
            else if (selected_command == "Delete")
            {
                type_box.Items.Clear();
                type_box.Items.Add("Field");
                type_box.Items.Add("Expert");
                type_box.Items.Add("User");
                confirm.Text = "Delete";
                label5.Text = "Handle:";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (Today.Checked)
            {
                SqlCommand cmd = new SqlCommand("UPDATE meeting set is_valid = 1 , user_handle = '' where day = @day", connect);
                cmd.Parameters.Add("@day", System.DateTime.Now.DayOfWeek.ToString());
                cmd.ExecuteNonQuery();

                reset_error.ForeColor = Color.Green;
                reset_error.Text = "Meeting of today reseted";
                reset_error.Show();
            }
            else if (day.Checked)
            {
                string selected_day = this.day_box.GetItemText(this.day_box.SelectedItem);
                if(selected_day !="")
                {
                    SqlCommand cmd = new SqlCommand("UPDATE meeting set is_valid = 1 , user_handle = '' where day = @day", connect);
                    cmd.Parameters.Add("@day", selected_day);
                    cmd.ExecuteNonQuery();

                    reset_error.ForeColor = Color.Green;
                    reset_error.Text = "Meeting of " +selected_day+ " reseted";
                    reset_error.Show();
                }
                else
                {
                    reset_error.ForeColor = Color.Red;
                    reset_error.Text = "select a day";
                    reset_error.Show();
                }
            }
            connect.Close();
        }

        private void Day_CheckedChanged(object sender, EventArgs e)
        {
            day_box.Show();
        }

        private void Today_CheckedChanged(object sender, EventArgs e)
        {
            day_box.Hide();
        }

        private void Type_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LOG_OUT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for using Our system");
            this.Hide();
            login login = new login(true);
            login.ShowDialog();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                message.ForeColor = Color.Red;
                selected_command = this.type_box.GetItemText(this.type_box.SelectedItem);
                message.Text = selected_command + " is empty";
                message.Show();
            }
            else
            {

                selected_command = this.command_box.GetItemText(this.command_box.SelectedItem);

                connect.Open();
                if (selected_command == "Add")
                {
                    SqlCommand cmd = new SqlCommand("select * from TbField where name = @name", connect);
                    cmd.Parameters.Add("@name", textBox1.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        message.ForeColor = Color.Red;
                        message.Text = "Field Exist Before";
                        message.Show();
                    }
                    else
                    {
                        reader.Close();
                        cmd = new SqlCommand("INSERT into TbField values(@name)", connect);
                        cmd.Parameters.Add("@name", textBox1.Text);
                        cmd.ExecuteNonQuery();

                        message.ForeColor = Color.Green;
                        message.Text = "Field added successfully";
                        message.Show();
                    }
                }
                else if (selected_command == "Delete")
                {
                    selected_command = this.type_box.GetItemText(this.type_box.SelectedItem);

                    if (selected_command == "Field")
                    {
                        SqlCommand cmd = new SqlCommand("select * from TbField where name = @name", connect);
                        cmd.Parameters.Add("@name", textBox1.Text);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (!reader.Read())
                        {
                            message.ForeColor = Color.Red;
                            message.Text = "This Field does not Exist";
                            message.Show();
                        }
                        else
                        {
                            int id = (int)reader["id"];
                            reader.Close();

                            SqlCommand command = new SqlCommand("select * from TbExpert where field_id = @id", connect);
                            command.Parameters.Add("@id", id.ToString());
                            SqlDataReader read = command.ExecuteReader();

                            while (read.Read())
                            {
                                handle.Push((string)read["handle"]);
                            }
                            read.Close();

                            while (handle.Count() > 0)
                            {
                                cmd = new SqlCommand("DELETE from meeting where exp_handle = @handle", connect);
                                cmd.Parameters.Add("@handle", handle.Pop());
                                cmd.ExecuteNonQuery();
                            }

                            cmd = new SqlCommand("Delete from TbField where name = @name", connect);
                            cmd.Parameters.Add("@name", textBox1.Text);
                            cmd.ExecuteNonQuery();

                            cmd = new SqlCommand("Delete from TbExpert where field_id = @id", connect);
                            cmd.Parameters.Add("@id", id.ToString());
                            cmd.ExecuteNonQuery();

                            message.ForeColor = Color.Green;
                            message.Text = "This Field deleted successfully";
                            message.Show();
                        }
                    }
                    else if (selected_command == "Expert")
                    {
                        SqlCommand cmd = new SqlCommand("select * from TbExpert where handle = @handle", connect);
                        cmd.Parameters.Add("@handle", textBox1.Text);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (!reader.Read())
                        {
                            message.ForeColor = Color.Red;
                            message.Text = "This Expert does not Exist";
                            message.Show();
                        }
                        else
                        {
                            reader.Close();

                            cmd = new SqlCommand("DELETE from meeting where exp_handle = @handle", connect);
                            cmd.Parameters.Add("@handle", textBox1.Text);
                            cmd.ExecuteNonQuery();

                            cmd = new SqlCommand("DELETE from TbExpert where handle = @handle", connect);
                            cmd.Parameters.Add("@handle", textBox1.Text);
                            cmd.ExecuteNonQuery();

                            message.ForeColor = Color.Green;
                            message.Text = "This Expert deleted successfully";
                            message.Show();
                        }
                    }
                    else if (selected_command == "User")
                    {
                        SqlCommand cmd = new SqlCommand("select * from TbUser where handle = @handle", connect);
                        cmd.Parameters.Add("@handle", textBox1.Text);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (!reader.Read())
                        {
                            message.ForeColor = Color.Red;
                            message.Text = "This User does not Exist";
                            message.Show();
                        }
                        else
                        {
                            reader.Close();

                            cmd = new SqlCommand("UPDATE meeting set is_valid = 1 , user_handle = '' where user_handle = @handle", connect);
                            cmd.Parameters.Add("@handle", textBox1.Text);
                            cmd.ExecuteNonQuery();

                            cmd = new SqlCommand("DELETE from TbUser where handle = @handle", connect);
                            cmd.Parameters.Add("@handle", textBox1.Text);
                            cmd.ExecuteNonQuery();

                            message.ForeColor = Color.Green;
                            message.Text = "This User deleted successfully";
                            message.Show();
                        }

                    }
                }
                connect.Close();
            }
        }


    }
}
