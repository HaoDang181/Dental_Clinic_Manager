namespace Dental_Clinic_Program
{
    partial class Schedule
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
            this.dayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.sundayLb = new System.Windows.Forms.Label();
            this.mondayLb = new System.Windows.Forms.Label();
            this.tuesdayLb = new System.Windows.Forms.Label();
            this.wednesdayLb = new System.Windows.Forms.Label();
            this.ThursdayLb = new System.Windows.Forms.Label();
            this.fridayLb = new System.Windows.Forms.Label();
            this.saturdayLb = new System.Windows.Forms.Label();
            this.dateLb = new System.Windows.Forms.Label();
            this.addAppointmentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayContainer
            // 
            this.dayContainer.Location = new System.Drawing.Point(12, 106);
            this.dayContainer.Name = "dayContainer";
            this.dayContainer.Size = new System.Drawing.Size(1020, 692);
            this.dayContainer.TabIndex = 0;
            // 
            // previousBtn
            // 
            this.previousBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(176)))));
            this.previousBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.previousBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.previousBtn.Location = new System.Drawing.Point(835, 804);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(94, 37);
            this.previousBtn.TabIndex = 0;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = false;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(176)))));
            this.nextBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.nextBtn.Location = new System.Drawing.Point(938, 804);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(94, 37);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // sundayLb
            // 
            this.sundayLb.AutoSize = true;
            this.sundayLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sundayLb.Location = new System.Drawing.Point(35, 65);
            this.sundayLb.Name = "sundayLb";
            this.sundayLb.Size = new System.Drawing.Size(90, 28);
            this.sundayLb.TabIndex = 2;
            this.sundayLb.Text = "Chủ nhật";
            // 
            // mondayLb
            // 
            this.mondayLb.AutoSize = true;
            this.mondayLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mondayLb.Location = new System.Drawing.Point(202, 65);
            this.mondayLb.Name = "mondayLb";
            this.mondayLb.Size = new System.Drawing.Size(61, 28);
            this.mondayLb.TabIndex = 3;
            this.mondayLb.Text = "Thứ 2";
            // 
            // tuesdayLb
            // 
            this.tuesdayLb.AutoSize = true;
            this.tuesdayLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tuesdayLb.Location = new System.Drawing.Point(346, 65);
            this.tuesdayLb.Name = "tuesdayLb";
            this.tuesdayLb.Size = new System.Drawing.Size(61, 28);
            this.tuesdayLb.TabIndex = 4;
            this.tuesdayLb.Text = "Thứ 3";
            // 
            // wednesdayLb
            // 
            this.wednesdayLb.AutoSize = true;
            this.wednesdayLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wednesdayLb.Location = new System.Drawing.Point(487, 65);
            this.wednesdayLb.Name = "wednesdayLb";
            this.wednesdayLb.Size = new System.Drawing.Size(61, 28);
            this.wednesdayLb.TabIndex = 5;
            this.wednesdayLb.Text = "Thứ 4";
            // 
            // ThursdayLb
            // 
            this.ThursdayLb.AutoSize = true;
            this.ThursdayLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThursdayLb.Location = new System.Drawing.Point(638, 65);
            this.ThursdayLb.Name = "ThursdayLb";
            this.ThursdayLb.Size = new System.Drawing.Size(61, 28);
            this.ThursdayLb.TabIndex = 6;
            this.ThursdayLb.Text = "Thứ 5";
            // 
            // fridayLb
            // 
            this.fridayLb.AutoSize = true;
            this.fridayLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fridayLb.Location = new System.Drawing.Point(781, 65);
            this.fridayLb.Name = "fridayLb";
            this.fridayLb.Size = new System.Drawing.Size(61, 28);
            this.fridayLb.TabIndex = 7;
            this.fridayLb.Text = "Thứ 6";
            // 
            // saturdayLb
            // 
            this.saturdayLb.AutoSize = true;
            this.saturdayLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saturdayLb.Location = new System.Drawing.Point(909, 65);
            this.saturdayLb.Name = "saturdayLb";
            this.saturdayLb.Size = new System.Drawing.Size(61, 28);
            this.saturdayLb.TabIndex = 8;
            this.saturdayLb.Text = "Thứ 7";
            // 
            // dateLb
            // 
            this.dateLb.AutoSize = true;
            this.dateLb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLb.Location = new System.Drawing.Point(428, 9);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(155, 37);
            this.dateLb.TabIndex = 9;
            this.dateLb.Text = "Tháng Năm";
            // 
            // addAppointmentBtn
            // 
            this.addAppointmentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(176)))));
            this.addAppointmentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addAppointmentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.addAppointmentBtn.Location = new System.Drawing.Point(938, 9);
            this.addAppointmentBtn.Name = "addAppointmentBtn";
            this.addAppointmentBtn.Size = new System.Drawing.Size(140, 37);
            this.addAppointmentBtn.TabIndex = 10;
            this.addAppointmentBtn.Text = "Tạo lịch hẹn";
            this.addAppointmentBtn.UseVisualStyleBackColor = false;
            this.addAppointmentBtn.Click += new System.EventHandler(this.addAppointmentBtn_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1082, 853);
            this.Controls.Add(this.addAppointmentBtn);
            this.Controls.Add(this.dateLb);
            this.Controls.Add(this.saturdayLb);
            this.Controls.Add(this.fridayLb);
            this.Controls.Add(this.ThursdayLb);
            this.Controls.Add(this.wednesdayLb);
            this.Controls.Add(this.tuesdayLb);
            this.Controls.Add(this.mondayLb);
            this.Controls.Add(this.sundayLb);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.dayContainer);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel dayContainer;
        private Button previousBtn;
        private Button nextBtn;
        private Label sundayLb;
        private Label mondayLb;
        private Label tuesdayLb;
        private Label wednesdayLb;
        private Label ThursdayLb;
        private Label fridayLb;
        private Label saturdayLb;
        private Label dateLb;
        private Button addAppointmentBtn;
    }
}