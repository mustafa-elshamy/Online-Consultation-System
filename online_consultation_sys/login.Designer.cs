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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(131, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "log in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_text
            // 
            this.user_text.Location = new System.Drawing.Point(186, 391);
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(153, 22);
            this.user_text.TabIndex = 2;
            this.user_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(80, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "user name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // pass_text
            // 
            this.pass_text.Location = new System.Drawing.Point(186, 437);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(153, 22);
            this.pass_text.TabIndex = 5;
            this.pass_text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(129, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login here";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Exprt_button
            // 
            this.Exprt_button.Location = new System.Drawing.Point(562, 383);
            this.Exprt_button.Name = "Exprt_button";
            this.Exprt_button.Size = new System.Drawing.Size(137, 28);
            this.Exprt_button.TabIndex = 7;
            this.Exprt_button.Text = "sign up as expert";
            this.Exprt_button.UseVisualStyleBackColor = true;
            this.Exprt_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // user_button
            // 
            this.user_button.Location = new System.Drawing.Point(562, 417);
            this.user_button.Name = "user_button";
            this.user_button.Size = new System.Drawing.Size(137, 28);
            this.user_button.TabIndex = 8;
            this.user_button.Text = "sign up as user";
            this.user_button.UseVisualStyleBackColor = true;
            this.user_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(558, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "sign up here";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // incorrect
            // 
            this.incorrect.AutoSize = true;
            this.incorrect.ForeColor = System.Drawing.Color.Red;
            this.incorrect.Location = new System.Drawing.Point(183, 462);
            this.incorrect.Name = "incorrect";
            this.incorrect.Size = new System.Drawing.Size(156, 17);
            this.incorrect.TabIndex = 12;
            this.incorrect.Text = "The password incorrect";
            this.incorrect.Click += new System.EventHandler(this.label4_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 566);
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
            this.Name = "login";
            this.Text = "Online System Consultation";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

