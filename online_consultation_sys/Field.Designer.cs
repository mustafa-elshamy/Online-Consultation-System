namespace online_consultation_sys
{
    partial class Field
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
            this.back_buttom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_buttom
            // 
            this.back_buttom.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.back_buttom.Location = new System.Drawing.Point(12, 12);
            this.back_buttom.Name = "back_buttom";
            this.back_buttom.Size = new System.Drawing.Size(75, 23);
            this.back_buttom.TabIndex = 0;
            this.back_buttom.Text = "Back";
            this.back_buttom.UseVisualStyleBackColor = true;
            this.back_buttom.Click += new System.EventHandler(this.back_buttom_Click);
            // 
            // Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_buttom);
            this.Name = "Field";
            this.Text = "Field";
            this.Load += new System.EventHandler(this.Field_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_buttom;
    }
}