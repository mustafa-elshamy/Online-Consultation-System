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
    public partial class Home : System.Windows.Forms.Form
    {
        string server_name = "Data Source = (local); Initial Catalog = online consultation system; Integrated Security = SSPI";

        SqlConnection connect;
        int x = 30, y = 70, global_id=0;
        public Home()
        {
            InitializeComponent();
        }

        private void connectDB()
        {
            connect = new SqlConnection(server_name);
            connect.Open();
        }

        private void DisconnectDB()
        {
            connect.Close();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            connectDB();
            SqlCommand cmd; ;
            SqlDataReader read;
            string query;

            query = "select id,name from TbField";
            cmd = new SqlCommand(query, connect);
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                creatButton((string)read["name"].ToString(),(int)read["id"]);
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void creatButton(string buttonName, int id)
        {
            global_id = 8;
            Button button = new Button();
            button.Height = 50;
            button.Width = 120;
            button.Location = new Point(x, y);
            x += 170;
            if (x > 370)
            {
                x = 30;
                y += 70;
            }
            button.Text = buttonName;
            button.Name = id.ToString()+ buttonName;
           

            
            button.Click += new EventHandler(Button_Click);
            Controls.Add(button);
        }

        
        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string s = b.Name.ToString();
            string ss = b.Text.ToString();
            s=s.Remove(s.Length - ss.Length);
            int id = Convert.ToInt32(s);



            this.Hide();
            Field field = new Field(id);
            field.ShowDialog();
        }
    }
}
