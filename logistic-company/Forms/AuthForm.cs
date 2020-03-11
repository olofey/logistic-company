using System;
using logistic_company.App_Data;
using System.Windows.Forms;
using logistic_company.Forms;

namespace logistic_company
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        static RegForm regForm = new RegForm();

        private void btnAuth_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbxLogin.Text) || string.IsNullOrEmpty(tbxPassword.Text))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                DBConnection.GetAuthClient(tbxLogin.Text, tbxPassword.Text);
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            regForm.ShowDialog();
        }
    }
}
