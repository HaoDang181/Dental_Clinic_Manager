namespace Dental_Clinic_Program
{
    partial class UserControlDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.daysLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daysLb
            // 
            this.daysLb.AutoSize = true;
            this.daysLb.Font = new System.Drawing.Font("Mongolian Baiti", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daysLb.Location = new System.Drawing.Point(11, 16);
            this.daysLb.Name = "daysLb";
            this.daysLb.Size = new System.Drawing.Size(32, 24);
            this.daysLb.TabIndex = 0;
            this.daysLb.Text = "00";
            // 
            // UserControlDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.daysLb);
            this.Name = "UserControlDay";
            this.Size = new System.Drawing.Size(138, 105);
            this.Load += new System.EventHandler(this.UserControlDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label daysLb;
    }
}
