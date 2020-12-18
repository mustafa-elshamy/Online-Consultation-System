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
        string server_name = "Data Source = (local); Initial Catalog = online consultation system; Integrated Security = SSPI";
        int field_id;
        int x = 30, y = 70;
        SqlConnection connect;
        public Field(int field)
        {
            InitializeComponent();
            field_id = field;
        }

        private void Field_Load(object sender, EventArgs e)
        {
            connectDB();
            SqlCommand cmd;
            SqlDataReader read;
            string query;

            query = "select name , rate from TbExpert where field_id = " + field_id.ToString();
            cmd = new SqlCommand(query, connect);
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                creatButton(read.GetString(0), read.GetDouble(1));
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
            Home home = new Home();
            home.ShowDialog();
        }

        private void creatButton(string buttonName, double text)
        {
            Button button = new Button();
            Label label = new Label();
            button.Height = 50;
            button.Width = 120;
            button.Location = new Point(x, y);
            label.Location = new Point(x, y + 50);

            x += 170;
            if (x > 370)
            {
                x = 30;
                y += 70;
            }

            button.Name = buttonName;

            button.Text = buttonName;
            label.Text = "Rate : " + text.ToString();

            buttonName += "_Click";
            //button.Click += new EventHandler(button_Click());
            Controls.Add(button);
            Controls.Add(label);
        }



    }
}
