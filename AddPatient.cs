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
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Dental_Clinic_Program
{
    public partial class AddPatient : Form
    {
        Thread th;
        string strCon = @"Data Source=DESKTOP-MJ8P9VM\HOAIBAO;Initial Catalog=DentalClinic;Integrated Security=True";

        SqlConnection sqlCon = null;
        public AddPatient()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String id = idTb.Text;
                String name = nameTb.Text;
                String age = ageTb.Text;
                String sex = sexTb.Text;
                String status = statusTb.Text;

                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();

                }
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Insert into PATIENT(PatientID, PatientName, Age, Gender, Status) VALUES (\'" + id + "\', N\'" + name + "\', " + age + ", N\'" + sex + "\', N\'" + status + "\')";
                sqlCmd.Connection = sqlCon;

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Thêm bệnh nhân thành công");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
