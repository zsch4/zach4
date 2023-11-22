using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.AppData;
namespace InventorySystem
{
    public partial class frmRegister : Form
          
    {
        InventoryDbEntities db;
        public frmRegister()
        {
            InitializeComponent();
            db = new InventoryDbEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         

          
                UserAccount newUserAccount = new UserAccount();
                newUserAccount.userfirstname = txtregFirstname.Text;
                newUserAccount.userlastname = txtregLastname.Text; 
                newUserAccount.userName = txtRegusername.Text;
                newUserAccount.userPass = txtRegpassword.Text;
                newUserAccount.roleId = cmbRole.SelectedItem.ToString();

               
                db.UserAccount.Add(newUserAccount);
                db.SaveChanges();

                txtregFirstname.Clear();
                txtregLastname.Clear();
                txtRegusername.Clear();
                txtRegpassword.Clear();
                MessageBox.Show("Registered!");
          


        }
            }
        }
   
