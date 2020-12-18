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
    public partial class Expert_home : Form
    {


        string servername = "Data Source=192.168.43.221;Initial Catalog=online consultation system;User ID=AS;Password=123456";
        SqlConnection con;
        string global_handle;
        int salary;
        bool light_mode;
        public Expert_home(string handle , bool mode)
        {
            InitializeComponent();
            global_handle = handle;
            con = new SqlConnection(servername);

            get_info();
            salary_lable.Text = "You Made " + salary + " Until Now";

            light_mode = mode;
        }
        private void get_info()
        {
            con.Open();
            SqlCommand command = new SqlCommand("select * from TbExpert where handle ='" + global_handle + "'", con);
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                salary = (int)reader["week_salary"];

            }
            reader.Close();
            con.Close();
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void time_table(string handle)
        {
            dataGridView1.ClearSelection();
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from meeting Where exp_handle='" + handle + "'", con);
           
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time_table(global_handle);
            change_mode(light_mode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(global_handle,light_mode);
            form2.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for using Our system");
            this.Hide();
            login login = new login(light_mode);
            login.ShowDialog();

        }

        private void salary_lable_Click(object sender, EventArgs e)
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
                this.BackgroundImage = Properties.Resources.expert;
                

                edit_button.ForeColor = Color.Blue;
                mode_buuton.ForeColor = Color.Blue;
                button1.ForeColor = Color.Blue;
                dataGridView1.GridColor = Color.Black;
                salary_lable.ForeColor = Color.Black;

                edit_button.BackColor = Color.White;
                mode_buuton.BackColor = Color.White;
                button1.BackColor = Color.White;
                dataGridView1.BackgroundColor = Color.LightBlue;
                salary_lable.BackColor = Color.White;
            }
            else
            {
                this.BackgroundImage = null;
                this.BackColor = Color.Black;

                edit_button.ForeColor = Color.White;
                mode_buuton.ForeColor = Color.White;
                button1.ForeColor = Color.White;
                dataGridView1.GridColor = Color.Blue;
                

                salary_lable.ForeColor = Color.White;

                edit_button.BackColor = Color.Black;
                mode_buuton.BackColor = Color.Black;
                button1.BackColor = Color.Black;
                dataGridView1.BackgroundColor = Color.Black;
                salary_lable.BackColor = Color.Black;

            }
        }
    }
}
