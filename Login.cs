using System.Diagnostics;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using System.Linq.Expressions;

namespace Dental_Clinic_Program
{
    public partial class Login : Form
    {

        Thread th;
        string strCon = @"Data Source=DESKTOP-MJ8P9VM\HOAIBAO;Initial Catalog=DentalClinic;Integrated Security=True";

        SqlConnection sqlCon = null;

        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String useraccount = userTb.Text;
                String password = passwordTb.Text;
                
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
                sqlCmd.CommandText = "select PASSWORDACCOUNT from ACCOUNT WHERE USERACCOUNT = \'" + useraccount + "\'";
                sqlCmd.Connection = sqlCon;

                string passwordDatabase = (string)sqlCmd.ExecuteScalar();
             
                
                if (String.Compare(password, passwordDatabase) == 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Close();  
                    th = new Thread(openHomeForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openSignUpForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openSignUpForm(object obj)
        {
            Application.Run(new SignUp());
        }

        private void openHomeForm(object obj)
        {
            Application.Run(new Home());
        }


    }
}