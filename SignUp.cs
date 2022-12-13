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
using System.Diagnostics;
using System.Data.SqlClient;

namespace Dental_Clinic_Program
{
    public partial class SignUp : Form
    {
        Thread th;
        string strCon = @"Data Source=DESKTOP-MJ8P9VM\HOAIBAO;Initial Catalog=DentalClinic;Integrated Security=True";

        SqlConnection sqlCon = null;

        public SignUp()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLoginForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String user = userTb.Text;
                String password = passwordTb.Text;
                String confirmPassword = passwordConfirmTb.Text;
                String username = userNameTb.Text;
                String email = emailTb.Text;
                
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();

                }
                if(String.Compare(password, confirmPassword) == 0)
                {           
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "Insert into ACCOUNT(USERACCOUNT, PASSWORDACCOUNT, USERNAME, EMAIL) VALUES (\'" + user + "\', \'" + password + "\', N\'" + username + "\', \'" + email + "\')";
                    sqlCmd.Connection = sqlCon;

                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Đăng kí thành công");
                    this.Close();
                    th = new Thread(openLoginForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Mật khẩu và nhập lại mật khẩu khác nhau");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void openLoginForm(object obj)
        {
            Application.Run(new Login());
        }
    }
}
