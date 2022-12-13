using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;

namespace Dental_Clinic_Program
{
    public partial class PatientList : Form
    {
        Thread th;
        string strCon = @"Data Source=DESKTOP-MJ8P9VM\HOAIBAO;Initial Catalog=DentalClinic;Integrated Security=True";
        SqlConnection sqlConnection = null;
        SqlCommand sqlCommand;
        DataTable dataTable;
        SqlDataAdapter sqlDataAdapter;
        DataSet dataSet;

        public PatientList()
        {
            InitializeComponent();
        }

        private void PatientList_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(strCon);

            patientListView.Columns.Add("ID", 80);
            patientListView.Columns.Add("Họ và tên", 280);
            patientListView.Columns.Add("Tuổi", 100, HorizontalAlignment.Center);
            patientListView.Columns.Add("Giởi tính", 150, HorizontalAlignment.Center);
            patientListView.Columns.Add("Tình trạng răng", 440);
            patientListView.View = View.Details;

            sqlConnection.Open();
            sqlCommand = new SqlCommand("select * from PATIENT", sqlConnection);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "PatientTable");
            sqlConnection.Close();

            dataTable = dataSet.Tables["PatientTable"];
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                patientListView.Items.Add(dataTable.Rows[i].ItemArray[0].ToString());
                patientListView.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[1].ToString());
                patientListView.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[2].ToString());
                patientListView.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[3].ToString());
                patientListView.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[4].ToString());
            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openAddPatientForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openAddPatientForm(object obj)
        {
            Application.Run(new AddPatient());
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openHomeForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openHomeForm(object obj)
        {
            Application.Run(new Home());
        }
    }
}
