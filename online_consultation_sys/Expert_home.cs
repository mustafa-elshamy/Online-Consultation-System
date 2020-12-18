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
        
        string servername = "Data Source = (local); Initial Catalog = online consultation system; Integrated Security = SSPI";
        SqlConnection con;
        public Expert_home()
        {
            InitializeComponent();
            con = new SqlConnection(servername);
            con.Open();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void time_table(string handle)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("select * from meeting Where exp_handle='" + handle + "'", con);
           // SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time_table("Mustafa_Elshamy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
