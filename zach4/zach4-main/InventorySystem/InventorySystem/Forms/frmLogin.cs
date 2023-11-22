using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.AppData;
using InventorySystem.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventorySystem
{
    public partial class frmLogin : Form
    {
        InventoryDbEntities db;
        public frmLogin()
        {
            db = new InventoryDbEntities();
            InitializeComponent();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername,"Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider2.SetError(txtPassword, "Empty Field!");
                return;
            }

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var user = db.UserAccount.FirstOrDefault(u => u.userName == username && u.userPass == password);
            UserAccount newUserAccount = new UserAccount();
            db.UserAccount.GetType();
            if (user != null)
            {
                MessageBox.Show("Login successful!");

                switch (user.roleId)
                {
                    case "Client":
                        frmClient frmclient = new frmClient();
                        frmclient.Show();
                        this.Hide();
                        break;
                    case "Employee":
                        frmEmployee frmEmployee = new frmEmployee();
                        frmEmployee.Show();
                        this.Hide();
                        break;
                    case "Administrator":
                        frmAdmin frmadmin   = new frmAdmin();   
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("User has no role!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Login failed. Invalid username or password.");
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
            
        }
    }
}
