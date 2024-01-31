using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tangkay
{

    public partial class Registration : Form
    {
        sysdbEntities db;
        public Registration()
        {
            InitializeComponent();
            db = new sysdbEntities();
        }

        private void registration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            UserAccount newUserAccount = new UserAccount();
            newUserAccount.userfirstname = txtFname.Text;
            newUserAccount.userlastname = txtLname.Text;
            newUserAccount.userName = txtUname.Text;
            newUserAccount.userPass = Cryptography.Encrypt(txtPassword.Text.ToString());

            db.UserAccount.Add(newUserAccount);
            db.SaveChanges();
            MessageBox.Show("Registered!");
        }
    }
}
