using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = System.Windows.Forms.Application;

namespace Dental_Clinic_Program
{
    public partial class AddAppointment : Form
    {
        Thread th;

        string strCon = @"Data Source=DESKTOP-MJ8P9VM\HOAIBAO;Initial Catalog=DentalClinic;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlCommand sqlCommand;
        DataTable dataTable;
        SqlDataAdapter sqlDataAdapter;
        DataSet dataSet;

        public AddAppointment()
        {
            InitializeComponent();

            timePicker.ShowUpDown = true;
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "dd/MM/yyyy";

            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm";
        }

        private void backBtn_Click(object sender, EventArgs e)
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            DateTime dateTime = this.datePicker.Value.Date;
            String date = dateTime.ToString("dd/MM/yyyy");

            TimeSpan timeSpan = this.timePicker.Value.TimeOfDay;
            String time = timeSpan.ToString();

            String patientName = patientComboBox.SelectedItem.ToString();
            String doctorName = doctorComboBox.SelectedItem.ToString();

            String note = noteTb.Text;

            String ID = "AP12";
            
            try
            {
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
                sqlCmd.CommandText = "SET dateformat DMY Insert into Appointment(AppId, AppDate, AppTime, DoctorOnDuty, PatientName, Note) VALUES (\'" + ID + "\', \'" + date + "\', \'" + time + "\', N\'" + doctorName + "\', N\'" + patientName + "\', N\'" + note + "\')";
                sqlCmd.Connection = sqlCon;

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Thêm lịch hẹn thành công");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

 

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();

                }

                // Get Data from Patient
                sqlCommand = new SqlCommand("select PatientName from Patient", sqlCon);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "PatientTable");
                sqlCon.Close();

                dataTable = dataSet.Tables["PatientTable"];
                List<String> listPatientName = new List<string>();

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    listPatientName.Add(dataTable.Rows[i].ItemArray[0].ToString());
                }

                // Load Data to Combo Patient
                patientComboBox.DataSource = listPatientName;

                // Get Data from Doctor
                sqlCommand = new SqlCommand("select DoctorName from Doctor", sqlCon);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "DoctorTable");
                sqlCon.Close();

                dataTable = dataSet.Tables["DoctorTable"];
                List<String> listDoctorName = new List<string>();

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    listDoctorName.Add(dataTable.Rows[i].ItemArray[0].ToString());
                }

                // Load Data to Combo Doctor
                doctorComboBox.DataSource = listDoctorName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
