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
    public partial class Field : System.Windows.Forms.Form
    {
        string server_name = "Data Source=192.168.43.221;Initial Catalog=online consultation system;User ID=AS;Password=123456";
        int field_id;
        string global_user;

        int x = 50, y = 70;
        SqlConnection connect;
        bool light_mode;
        public Field(int field , string user , bool mode)
        {
            InitializeComponent();
            field_id = field;
            global_user = user;
            light_mode = mode;
        }

        private void Field_Load(object sender, EventArgs e)
        {
            connectDB();
            SqlCommand cmd;
            SqlDataReader read;
            string query;

            query = "select * from TbExpert where field_id = " + field_id.ToString();
            cmd = new SqlCommand(query, connect);
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                creatButton((string)read["name"], (double)read["rate"],(string)read["handle"]);
            }
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

        private void back_buttom_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(global_user,light_mode);
            home.ShowDialog();
        }

        private void creatButton(string buttonName, double text, string handle)
        {
            Button button = new Button();
            Label label = new Label();
            button.Height = 50;
            button.Width = 120;
            button.Location = new Point(x, y);
            label.Location = new Point(x, y+50);

            x += 200;
            if(x>470)
            {

                 y += 90;
                x = 50;
            }
            

            button.Name = handle;
            button.Text = buttonName;
            label.Text = "Rate : " + text.ToString();

            buttonName += "_Click";
            button.Click += new EventHandler(Button_Click);
            Controls.Add(button);
            Controls.Add(label);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for using Our system");
            this.Hide();
            login login = new login(light_mode);
            login.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(global_user, light_mode);
            home.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for using Our system");
            this.Hide();
            login login = new login(light_mode); 
            login.ShowDialog();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string handle = button.Name;
            this.Hide();
            show_expert show_Expert  = new show_expert(handle,global_user,light_mode);
            show_Expert.ShowDialog();


        }


    }
}
