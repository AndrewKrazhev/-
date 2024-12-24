using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДемоЭкз
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            
           // if (textBoxLogin.Text == "admin" && textBoxLogin.Text == "admin")
            if (Helper.CheckUser(textBoxLogin.Text, textBoxLogin.Text))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Введённая пара логин и пароль неверные, попробуйте ещё раз","Неверный логин/пароль",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
