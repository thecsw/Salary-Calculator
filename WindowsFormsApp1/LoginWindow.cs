using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class LoginWindow : MetroFramework.Forms.MetroForm
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        String abb, usser;
        private void button1_Click(object sender, EventArgs e)
        {
            if (MR.Checked == false && MRS.Checked == false && MS.Checked == false) {
                MessageBox.Show("Please choose personal title");
                return;
            }
            if (nameTT.Text == "" || nameTT.Text == " ") {
                MessageBox.Show("Please fill your name correctly");
                return;
            }
            if (SUPER.Checked == false && ADMIN.Checked == false && ACC.Checked == false)
            {
                MessageBox.Show("Please choose account type");
                return;
            }
            StreamWriter sww = new StreamWriter("login.txt");
            if (SUPER.Checked == true) usser = "user";
            if (ADMIN.Checked == true) usser = "admin";
            if (ACC.Checked == true) usser = "accountant";
            if (MR.Checked == true) abb = "Mr.";
            if (MS.Checked == true) abb = "Ms.";
            if (MRS.Checked == true) abb = "Mrs.";
            sww.WriteLine(usser);
            sww.WriteLine(abb + " " + nameTT.Text);
            sww.Close();
            mainForm m = new mainForm();
            m.Show();
            this.Hide();
        }

        private void MR_Click(object sender, EventArgs e)
        {
            MRS.Checked = false;
            MS.Checked = false;
            MR.Checked = true;
        }

        private void MS_Click(object sender, EventArgs e)
        {
            MR.Checked = false;
            MRS.Checked = false;
            MS.Checked = true;
        }

        private void MRS_Click(object sender, EventArgs e)
        {
            MR.Checked = false;
            MS.Checked = false;
            MRS.Checked = true;
        }

        private void ADMIN_Click(object sender, EventArgs e)
        {
            ADMIN.Checked = true;
            ACC.Checked = false;
            SUPER.Checked = false;
        }

        private void LoginWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ACC_Click(object sender, EventArgs e)
        {
            ADMIN.Checked = false;
            SUPER.Checked = false;
            ACC.Checked = true;
        }

        private void USER_Click(object sender, EventArgs e)
        {
            ADMIN.Checked = false;
            ACC.Checked = false;
            SUPER.Checked = true;
        }
    }
}
