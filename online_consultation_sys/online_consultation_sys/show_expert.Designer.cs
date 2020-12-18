namespace online_consultation_sys
{
    partial class show_expert
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
            this.label1 = new System.Windows.Forms.Label();
            this.expert_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.field_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fees = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.meeting_table = new System.Windows.Forms.DataGridView();
            this.meeting_id_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Confirm_button = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.mode_buuton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.meeting_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // expert_name
            // 
            this.expert_name.AutoSize = true;
            this.expert_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expert_name.Location = new System.Drawing.Point(91, 89);
            this.expert_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.expert_name.Name = "expert_name";
            this.expert_name.Size = new System.Drawing.Size(57, 20);
            this.expert_name.TabIndex = 1;
            this.expert_name.Text = "label2";
            this.expert_name.Click += new System.EventHandler(this.expert_name_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Field :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // field_name
            // 
            this.field_name.AutoSize = true;
            this.field_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field_name.Location = new System.Drawing.Point(91, 141);
            this.field_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.field_name.Name = "field_name";
            this.field_name.Size = new System.Drawing.Size(57, 20);
            this.field_name.TabIndex = 3;
            this.field_name.Text = "label2";
            this.field_name.Click += new System.EventHandler(this.field_name_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(496, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Duration of Consultation :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration.Location = new System.Drawing.Point(715, 89);
            this.duration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(57, 20);
            this.duration.TabIndex = 5;
            this.duration.Text = "label2";
            this.duration.Click += new System.EventHandler(this.duration_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fees per duration :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fees
            // 
            this.fees.AutoSize = true;
            this.fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fees.Location = new System.Drawing.Point(715, 141);
            this.fees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fees.Name = "fees";
            this.fees.Size = new System.Drawing.Size(57, 20);
            this.fees.TabIndex = 7;
            this.fees.Text = "label2";
            this.fees.Click += new System.EventHandler(this.fees_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rate :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // rate
            // 
            this.rate.AutoSize = true;
            this.rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate.Location = new System.Drawing.Point(362, 89);
            this.rate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(57, 20);
            this.rate.TabIndex = 9;
            this.rate.Text = "label2";
            this.rate.Click += new System.EventHandler(this.rate_Click);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(379, 141);
            this.gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(57, 20);
            this.gender.TabIndex = 11;
            this.gender.Text = "label2";
            this.gender.Click += new System.EventHandler(this.gender_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Gender :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // meeting_table
            // 
            this.meeting_table.AllowUserToAddRows = false;
            this.meeting_table.AllowUserToDeleteRows = false;
            this.meeting_table.AllowUserToResizeColumns = false;
            this.meeting_table.AllowUserToResizeRows = false;
            this.meeting_table.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.meeting_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meeting_table.Location = new System.Drawing.Point(95, 174);
            this.meeting_table.Margin = new System.Windows.Forms.Padding(2);
            this.meeting_table.Name = "meeting_table";
            this.meeting_table.ReadOnly = true;
            this.meeting_table.RowTemplate.Height = 24;
            this.meeting_table.ShowEditingIcon = false;
            this.meeting_table.Size = new System.Drawing.Size(571, 206);
            this.meeting_table.TabIndex = 12;
            this.meeting_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.meeting_table_CellContentClick);
            // 
            // meeting_id_box
            // 
            this.meeting_id_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meeting_id_box.Location = new System.Drawing.Point(166, 398);
            this.meeting_id_box.Margin = new System.Windows.Forms.Padding(2);
            this.meeting_id_box.Name = "meeting_id_box";
            this.meeting_id_box.Size = new System.Drawing.Size(133, 26);
            this.meeting_id_box.TabIndex = 13;
            this.meeting_id_box.TextChanged += new System.EventHandler(this.meeting_id_box_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 401);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "meeting time id :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Confirm_button
            // 
            this.Confirm_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Confirm_button.Location = new System.Drawing.Point(312, 398);
            this.Confirm_button.Margin = new System.Windows.Forms.Padding(2);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.Size = new System.Drawing.Size(87, 26);
            this.Confirm_button.TabIndex = 15;
            this.Confirm_button.Text = "Confirm";
            this.Confirm_button.UseVisualStyleBackColor = true;
            this.Confirm_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(143, 423);
            this.message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 20);
            this.message.TabIndex = 16;
            this.message.Click += new System.EventHandler(this.message_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(10, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "log out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.back_button.Location = new System.Drawing.Point(95, 11);
            this.back_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(66, 33);
            this.back_button.TabIndex = 18;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // mode_buuton
            // 
            this.mode_buuton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode_buuton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mode_buuton.Location = new System.Drawing.Point(712, 11);
            this.mode_buuton.Name = "mode_buuton";
            this.mode_buuton.Size = new System.Drawing.Size(75, 28);
            this.mode_buuton.TabIndex = 19;
            this.mode_buuton.Text = "Mode";
            this.mode_buuton.UseVisualStyleBackColor = true;
            this.mode_buuton.Click += new System.EventHandler(this.Mode_buuton_Click);
            // 
            // show_expert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::online_consultation_sys.Properties.Resources.login1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 448);
            this.Controls.Add(this.mode_buuton);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.Confirm_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.meeting_id_box);
            this.Controls.Add(this.meeting_table);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fees);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.field_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expert_name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "show_expert";
            this.Text = "show_expert";
            this.Load += new System.EventHandler(this.show_expert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meeting_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label expert_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label field_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView meeting_table;
        private System.Windows.Forms.TextBox meeting_id_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Confirm_button;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button mode_buuton;
    }
}