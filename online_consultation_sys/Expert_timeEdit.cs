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
    public partial class Form2 : Form
    {
        string servername = "Data Source = (local); Initial Catalog = online consultation system; Integrated Security = SSPI";
        SqlConnection con;
        SqlCommand cmd;
        string expert_handle = "Mustafa_Elshamy";
        float office_houres;
        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection(servername);
            con.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select number_of_office_hours from TbExpert where handle = '" + expert_handle + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                office_houres = (float)reader.GetFloat(0);
            }
            reader.Close();
            float end_time = Convert.ToInt32(textBox2.Text.ToString()) + office_houres;
            if (valid(end_time))
            {
                cmd = new SqlCommand("insert into meeting values('" + expert_handle +"','" + textBox4.Text + "', '" + textBox3.Text + "'," +
                    " '" + textBox2.Text + "','" + end_time + "')", con);
            }
            else
            {
                MessageBox.Show("Time Not Valid");
            }
        }

        private bool valid( float endtime)
        {
            cmd = new SqlCommand("select time_start , time_end from meeting where handle = '" + expert_handle + "' AND day = '" +textBox3.Text +"'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((float)reader["time_start"] >= endtime || (float)reader["time_end"] <= Convert.ToDouble(textBox2.Text.ToString()))
                    ;
                else
                {
                    reader.Close();
                    return false;
                }

            }
            reader.Close();
            return true;
        }
    }
}
