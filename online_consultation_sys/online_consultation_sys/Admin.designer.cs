namespace online_consultation_sys

{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.label2 = new System.Windows.Forms.Label();
            this.command_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.type_box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Today = new System.Windows.Forms.RadioButton();
            this.day = new System.Windows.Forms.RadioButton();
            this.day_box = new System.Windows.Forms.ComboBox();
            this.reset_error = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LOG_OUT = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome , Admin";
            // 
            // command_box
            // 
            this.command_box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.command_box.ForeColor = System.Drawing.SystemColors.MenuText;
            this.command_box.FormattingEnabled = true;
            this.command_box.Items.AddRange(new object[] {
            "Add",
            "Delete"});
            this.command_box.Location = new System.Drawing.Point(122, 40);
            this.command_box.Name = "command_box";
            this.command_box.Size = new System.Drawing.Size(121, 22);
            this.command_box.TabIndex = 2;
            this.command_box.Text = "Select";
            this.command_box.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(32, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Command :";
            // 
            // type_box
            // 
            this.type_box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.type_box.ForeColor = System.Drawing.SystemColors.MenuText;
            this.type_box.FormattingEnabled = true;
            this.type_box.Location = new System.Drawing.Point(122, 102);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(121, 22);
            this.type_box.TabIndex = 4;
            this.type_box.Text = "Select";
            this.type_box.SelectedIndexChanged += new System.EventHandler(this.Type_box_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(56, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(27, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Handle :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 21);
            this.textBox1.TabIndex = 7;
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.confirm.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(122, 252);
            this.confirm.Margin = new System.Windows.Forms.Padding(0);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 8;
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(119, 193);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 14);
            this.message.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(129, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Today
            // 
            this.Today.AutoSize = true;
            this.Today.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Today.Checked = true;
            this.Today.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Today.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Today.Location = new System.Drawing.Point(115, 84);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(102, 18);
            this.Today.TabIndex = 11;
            this.Today.TabStop = true;
            this.Today.Text = "Reset Today";
            this.Today.UseVisualStyleBackColor = false;
            this.Today.CheckedChanged += new System.EventHandler(this.Today_CheckedChanged);
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.day.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.day.Location = new System.Drawing.Point(93, 135);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(151, 18);
            this.day.TabIndex = 12;
            this.day.Text = "Reset Specific day";
            this.day.UseVisualStyleBackColor = false;
            this.day.CheckedChanged += new System.EventHandler(this.Day_CheckedChanged);
            // 
            // day_box
            // 
            this.day_box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.day_box.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_box.ForeColor = System.Drawing.SystemColors.MenuText;
            this.day_box.FormattingEnabled = true;
            this.day_box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.day_box.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thrusday",
            "Friday",
            "Saturday"});
            this.day_box.Location = new System.Drawing.Point(106, 181);
            this.day_box.Name = "day_box";
            this.day_box.Size = new System.Drawing.Size(121, 22);
            this.day_box.TabIndex = 13;
            this.day_box.Text = "Choose Day";
            this.day_box.Visible = false;
            // 
            // reset_error
            // 
            this.reset_error.AutoSize = true;
            this.reset_error.Location = new System.Drawing.Point(90, 233);
            this.reset_error.Name = "reset_error";
            this.reset_error.Size = new System.Drawing.Size(0, 14);
            this.reset_error.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.type_box);
            this.groupBox1.Controls.Add(this.command_box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.message);
            this.groupBox1.Controls.Add(this.confirm);
            this.groupBox1.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(27, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 312);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add & Delete";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.Today);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.reset_error);
            this.groupBox2.Controls.Add(this.day);
            this.groupBox2.Controls.Add(this.day_box);
            this.groupBox2.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(421, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 312);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reset Meetings";
            // 
            // LOG_OUT
            // 
            this.LOG_OUT.ActiveBorderThickness = 1;
            this.LOG_OUT.ActiveCornerRadius = 20;
            this.LOG_OUT.ActiveFillColor = System.Drawing.Color.Blue;
            this.LOG_OUT.ActiveForecolor = System.Drawing.Color.White;
            this.LOG_OUT.ActiveLineColor = System.Drawing.Color.Blue;
            this.LOG_OUT.BackColor = System.Drawing.SystemColors.Control;
            this.LOG_OUT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LOG_OUT.BackgroundImage")));
            this.LOG_OUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LOG_OUT.ButtonText = "LOG_OUT";
            this.LOG_OUT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LOG_OUT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOG_OUT.ForeColor = System.Drawing.Color.Blue;
            this.LOG_OUT.IdleBorderThickness = 1;
            this.LOG_OUT.IdleCornerRadius = 20;
            this.LOG_OUT.IdleFillColor = System.Drawing.Color.Gainsboro;
            this.LOG_OUT.IdleForecolor = System.Drawing.Color.Blue;
            this.LOG_OUT.IdleLineColor = System.Drawing.Color.Blue;
            this.LOG_OUT.Location = new System.Drawing.Point(690, 13);
            this.LOG_OUT.Margin = new System.Windows.Forms.Padding(4);
            this.LOG_OUT.Name = "LOG_OUT";
            this.LOG_OUT.Size = new System.Drawing.Size(97, 34);
            this.LOG_OUT.TabIndex = 18;
            this.LOG_OUT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LOG_OUT.Click += new System.EventHandler(this.LOG_OUT_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LOG_OUT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox command_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox type_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Today;
        private System.Windows.Forms.RadioButton day;
        private System.Windows.Forms.ComboBox day_box;
        private System.Windows.Forms.Label reset_error;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 LOG_OUT;
    }
}

