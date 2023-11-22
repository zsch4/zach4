using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.AppData;
namespace InventorySystem.Forms
{
    public partial class frmEmployee : Form
    {
        InventoryDbEntities db;
        public frmEmployee()
        {
            InitializeComponent();
            db = new InventoryDbEntities();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFramename.Clear();
            txtFramequantity.Clear();
            txtFrameprice.Clear();

            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int frameprice = Int32.Parse(txtFrameprice.Text);
            int quantity = Int32.Parse(txtFramequantity.Text);
            try
            {
                Frameset newFrameset = new Frameset();
                newFrameset.frameName = txtFramename.Text;
                newFrameset.frameType = cmbFrametype.SelectedItem.ToString();
                newFrameset.framePrice = frameprice;
                newFrameset.frameQuantity = quantity;

                db.Frameset.Add(newFrameset);
                db.SaveChanges();

                txtFramename.Clear();
                txtFrameprice.Clear();
                txtFramequantity.Clear();
                MessageBox.Show("Frameset Stored!");
            }
            catch (Exception ee)
            {
                MessageBox.Show($"An error occurred: {ee.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FramesetTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}