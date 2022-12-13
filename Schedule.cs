using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic_Program
{
    public partial class Schedule : Form
    {
        Thread th;
        static DateTime now = DateTime.Now;
        static int month = now.Month;
        static int year = now.Year;

     

        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            dateLb.Text = "Tháng " + month + " Năm " + year;

            //Get first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);

            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //First lets create a blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayContainer.Controls.Add(ucBlank);
            }

            // create UserControl for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDay ucDays = new UserControlDay();
                ucDays.days(i);
                dayContainer.Controls.Add(ucDays);
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            // clear container
            dayContainer.Controls.Clear();

            //increment month
            month++;
            if(month >= 13)
            {
                month = 1;
                year++;
            }

            displayDays();
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            // clear container
            dayContainer.Controls.Clear();

            //increment month
            month--;
            if (month <= 0)
            {
                month = 12;
                year--;
            }

            displayDays();
        }

        private void addAppointmentBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openAddAppointmentForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openAddAppointmentForm(object obj)
        {
            Application.Run(new AddAppointment());
        }
    }
}
