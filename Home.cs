using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Dental_Clinic_Program
{
    public partial class Home : Form
    {
        Thread th;
        public Home()
        {
            InitializeComponent();
        }

        private void patientListBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openPatientListForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openPatientListForm(object obj)
        {
            Application.Run(new PatientList());
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLoginForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openLoginForm(object obj)
        {
            Application.Run(new Login());
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openScheduleForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openScheduleForm(object obj)
        {
            Application.Run(new Schedule());
        }
    }
}
