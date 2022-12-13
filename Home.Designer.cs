namespace Dental_Clinic_Program
{
    partial class Home
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
            this.homeLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.materialBtn = new System.Windows.Forms.Button();
            this.doctorBtn = new System.Windows.Forms.Button();
            this.scheduleBtn = new System.Windows.Forms.Button();
            this.patientListBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeLb
            // 
            this.homeLb.AutoSize = true;
            this.homeLb.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeLb.Location = new System.Drawing.Point(423, 23);
            this.homeLb.Name = "homeLb";
            this.homeLb.Size = new System.Drawing.Size(246, 54);
            this.homeLb.TabIndex = 1;
            this.homeLb.Text = "Dental Clinic";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.reportBtn);
            this.panel1.Controls.Add(this.materialBtn);
            this.panel1.Controls.Add(this.doctorBtn);
            this.panel1.Controls.Add(this.scheduleBtn);
            this.panel1.Controls.Add(this.patientListBtn);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(11, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 641);
            this.panel1.TabIndex = 2;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.logOutBtn.Image = global::Dental_Clinic_Program.Properties.Resources.logout_icon;
            this.logOutBtn.Location = new System.Drawing.Point(795, 347);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(229, 267);
            this.logOutBtn.TabIndex = 11;
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.reportBtn.Image = global::Dental_Clinic_Program.Properties.Resources.report_icon;
            this.reportBtn.Location = new System.Drawing.Point(418, 347);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(229, 267);
            this.reportBtn.TabIndex = 10;
            this.reportBtn.UseVisualStyleBackColor = false;
            // 
            // materialBtn
            // 
            this.materialBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.materialBtn.Image = global::Dental_Clinic_Program.Properties.Resources.medical_icon;
            this.materialBtn.Location = new System.Drawing.Point(39, 347);
            this.materialBtn.Name = "materialBtn";
            this.materialBtn.Size = new System.Drawing.Size(229, 267);
            this.materialBtn.TabIndex = 9;
            this.materialBtn.UseVisualStyleBackColor = false;
            // 
            // doctorBtn
            // 
            this.doctorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.doctorBtn.Image = global::Dental_Clinic_Program.Properties.Resources.doctor_icon;
            this.doctorBtn.Location = new System.Drawing.Point(795, 23);
            this.doctorBtn.Name = "doctorBtn";
            this.doctorBtn.Size = new System.Drawing.Size(229, 267);
            this.doctorBtn.TabIndex = 8;
            this.doctorBtn.UseVisualStyleBackColor = false;
            // 
            // scheduleBtn
            // 
            this.scheduleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.scheduleBtn.Image = global::Dental_Clinic_Program.Properties.Resources.schedule_icon;
            this.scheduleBtn.Location = new System.Drawing.Point(418, 23);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(229, 267);
            this.scheduleBtn.TabIndex = 7;
            this.scheduleBtn.UseVisualStyleBackColor = false;
            this.scheduleBtn.Click += new System.EventHandler(this.scheduleBtn_Click);
            // 
            // patientListBtn
            // 
            this.patientListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.patientListBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patientListBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.patientListBtn.Image = global::Dental_Clinic_Program.Properties.Resources.user_icon;
            this.patientListBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.patientListBtn.Location = new System.Drawing.Point(39, 23);
            this.patientListBtn.Name = "patientListBtn";
            this.patientListBtn.Size = new System.Drawing.Size(229, 267);
            this.patientListBtn.TabIndex = 6;
            this.patientListBtn.Text = "Patient";
            this.patientListBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.patientListBtn.UseVisualStyleBackColor = false;
            this.patientListBtn.Click += new System.EventHandler(this.patientListBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(403, 315);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(0, 0);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homeLb);
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label homeLb;
        private Panel panel1;
        private Button logOutBtn;
        private Button reportBtn;
        private Button materialBtn;
        private Button doctorBtn;
        private Button scheduleBtn;
        private Button patientListBtn;
        private Button button5;
    }
}