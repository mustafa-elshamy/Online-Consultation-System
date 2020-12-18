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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Field));
            this.BACK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LOG_OUT = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // BACK
            // 
            this.BACK.ActiveBorderThickness = 1;
            this.BACK.ActiveCornerRadius = 20;
            this.BACK.ActiveFillColor = System.Drawing.Color.Blue;
            this.BACK.ActiveForecolor = System.Drawing.Color.White;
            this.BACK.ActiveLineColor = System.Drawing.Color.Blue;
            this.BACK.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BACK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BACK.BackgroundImage")));
            this.BACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BACK.ButtonText = "BACK";
            this.BACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BACK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK.ForeColor = System.Drawing.Color.Blue;
            this.BACK.IdleBorderThickness = 1;
            this.BACK.IdleCornerRadius = 20;
            this.BACK.IdleFillColor = System.Drawing.Color.Gainsboro;
            this.BACK.IdleForecolor = System.Drawing.Color.Blue;
            this.BACK.IdleLineColor = System.Drawing.Color.Blue;
            this.BACK.Location = new System.Drawing.Point(587, 3);
            this.BACK.Margin = new System.Windows.Forms.Padding(5);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(154, 38);
            this.BACK.TabIndex = 3;
            this.BACK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BACK.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // LOG_OUT
            // 
            this.LOG_OUT.ActiveBorderThickness = 1;
            this.LOG_OUT.ActiveCornerRadius = 20;
            this.LOG_OUT.ActiveFillColor = System.Drawing.Color.Blue;
            this.LOG_OUT.ActiveForecolor = System.Drawing.Color.White;
            this.LOG_OUT.ActiveLineColor = System.Drawing.Color.Blue;
            this.LOG_OUT.BackColor = System.Drawing.SystemColors.AppWorkspace;
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
            this.LOG_OUT.Location = new System.Drawing.Point(751, 3);
            this.LOG_OUT.Margin = new System.Windows.Forms.Padding(5);
            this.LOG_OUT.Name = "LOG_OUT";
            this.LOG_OUT.Size = new System.Drawing.Size(156, 38);
            this.LOG_OUT.TabIndex = 4;
            this.LOG_OUT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LOG_OUT.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 475);
            this.Controls.Add(this.LOG_OUT);
            this.Controls.Add(this.BACK);
            this.Name = "Field";
            this.Text = "Field";
            this.Load += new System.EventHandler(this.Field_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 BACK;
        private Bunifu.Framework.UI.BunifuThinButton2 LOG_OUT;
    }
}