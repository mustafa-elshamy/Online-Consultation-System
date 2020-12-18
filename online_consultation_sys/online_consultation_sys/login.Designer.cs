namespace online_consultation_sys
{
    partial class login
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
            this.button1 = new System.Windows.Forms.Button();
            this.user_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Exprt_button = new System.Windows.Forms.Button();
            this.user_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.incorrect = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.mode_buuton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(143, 422);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "log in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_text
            // 
            this.user_text.Location = new System.Drawing.Point(154, 318);
            this.user_text.Margin = new System.Windows.Forms.Padding(2);
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(116, 20);
            this.user_text.TabIndex = 2;
            this.user_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(51, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 353);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // pass_text
            // 
            this.pass_text.Location = new System.Drawing.Point(154, 355);
            this.pass_text.Margin = new System.Windows.Forms.Padding(2);
            this.pass_text.Name = "pass_text";
            this.pass_text.PasswordChar = '*';
            this.pass_text.Size = new System.Drawing.Size(116, 20);
            this.pass_text.TabIndex = 5;
            this.pass_text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(97, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login here";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Exprt_button
            // 
            this.Exprt_button.Location = new System.Drawing.Point(422, 311);
            this.Exprt_button.Margin = new System.Windows.Forms.Padding(2);
            this.Exprt_button.Name = "Exprt_button";
            this.Exprt_button.Size = new System.Drawing.Size(103, 23);
            this.Exprt_button.TabIndex = 7;
            this.Exprt_button.Text = "sign up as expert";
            this.Exprt_button.UseVisualStyleBackColor = true;
            this.Exprt_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // user_button
            // 
            this.user_button.Location = new System.Drawing.Point(422, 339);
            this.user_button.Margin = new System.Windows.Forms.Padding(2);
            this.user_button.Name = "user_button";
            this.user_button.Size = new System.Drawing.Size(103, 23);
            this.user_button.TabIndex = 8;
            this.user_button.Text = "sign up as user";
            this.user_button.UseVisualStyleBackColor = true;
            this.user_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(418, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "sign up here";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // incorrect
            // 
            this.incorrect.AutoSize = true;
            this.incorrect.ForeColor = System.Drawing.Color.Red;
            this.incorrect.Location = new System.Drawing.Point(152, 388);
            this.incorrect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incorrect.Name = "incorrect";
            this.incorrect.Size = new System.Drawing.Size(118, 13);
            this.incorrect.TabIndex = 12;
            this.incorrect.Text = "The password incorrect";
            this.incorrect.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(516, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // mode_buuton
            // 
            this.mode_buuton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode_buuton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mode_buuton.Location = new System.Drawing.Point(12, 12);
            this.mode_buuton.Name = "mode_buuton";
            this.mode_buuton.Size = new System.Drawing.Size(75, 28);
            this.mode_buuton.TabIndex = 14;
            this.mode_buuton.Text = "Mode";
            this.mode_buuton.UseVisualStyleBackColor = true;
            this.mode_buuton.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::online_consultation_sys.Properties.Resources.consult;
            this.pictureBox1.Location = new System.Drawing.Point(197, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::online_consultation_sys.Properties.Resources.sign_in;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mode_buuton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.incorrect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.user_button);
            this.Controls.Add(this.Exprt_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_text);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "login";
            this.Text = "Online System Consultation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox user_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Exprt_button;
        private System.Windows.Forms.Button user_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label incorrect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button mode_buuton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

