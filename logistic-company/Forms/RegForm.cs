using System;
using logistic_company.App_Data;
using System.Windows.Forms;

namespace logistic_company.Forms
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxLogin.Text) || string.IsNullOrEmpty(tbxPassword.Text) || string.IsNullOrEmpty(tbxEmail.Text))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                DBConnection.CheckClientAccount(tbxLogin.Text, tbxPassword.Text, tbxEmail.Text);
            }
        }
    }
}
