namespace online_consultation_sys
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.delete_button = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.meeting_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.time_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.address_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.day_box = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.mode_buuton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.delete_button.Location = new System.Drawing.Point(77, 122);
            this.delete_button.Margin = new System.Windows.Forms.Padding(2);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(83, 30);
            this.delete_button.TabIndex = 0;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // insert_button
            // 
            this.insert_button.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.insert_button.Location = new System.Drawing.Point(480, 179);
            this.insert_button.Margin = new System.Windows.Forms.Padding(2);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(83, 30);
            this.insert_button.TabIndex = 1;
            this.insert_button.Text = "Add";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // meeting_box
            // 
            this.meeting_box.Location = new System.Drawing.Point(122, 77);
            this.meeting_box.Margin = new System.Windows.Forms.Padding(2);
            this.meeting_box.Name = "meeting_box";
            this.meeting_box.Size = new System.Drawing.Size(131, 20);
            this.meeting_box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meeting ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time :";
            // 
            // time_box
            // 
            this.time_box.Location = new System.Drawing.Point(462, 35);
            this.time_box.Margin = new System.Windows.Forms.Padding(2);
            this.time_box.Name = "time_box";
            this.time_box.Size = new System.Drawing.Size(131, 20);
            this.time_box.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address :";
            // 
            // address_box
            // 
            this.address_box.Location = new System.Drawing.Point(462, 90);
            this.address_box.Margin = new System.Windows.Forms.Padding(2);
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(131, 20);
            this.address_box.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Day :";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(502, 211);
            this.error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 12;
            // 
            // day_box
            // 
            this.day_box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.day_box.FormattingEnabled = true;
            this.day_box.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.day_box.Location = new System.Drawing.Point(462, 140);
            this.day_box.Margin = new System.Windows.Forms.Padding(2);
            this.day_box.Name = "day_box";
            this.day_box.Size = new System.Drawing.Size(131, 21);
            this.day_box.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.Location = new System.Drawing.Point(10, 226);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(812, 237);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(10, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "log out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.Control;
            this.back_button.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.back_button.Location = new System.Drawing.Point(96, 11);
            this.back_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(73, 28);
            this.back_button.TabIndex = 19;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // mode_buuton
            // 
            this.mode_buuton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode_buuton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mode_buuton.Location = new System.Drawing.Point(747, 12);
            this.mode_buuton.Name = "mode_buuton";
            this.mode_buuton.Size = new System.Drawing.Size(75, 28);
            this.mode_buuton.TabIndex = 20;
            this.mode_buuton.Text = "Mode";
            this.mode_buuton.UseVisualStyleBackColor = true;
            this.mode_buuton.Click += new System.EventHandler(this.Mode_buuton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mode_buuton);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.day_box);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.meeting_box);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.delete_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Time Edit";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.TextBox meeting_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox time_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.ComboBox day_box;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button mode_buuton;
        private System.Windows.Forms.Label label5;
    }
}