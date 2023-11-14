using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem.Forms
{
    public partial class frmEmployee : Form
    {
        Frameset frame = new Frameset();
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frame.frameId = ;
            frame.frameName = txtFramename.Text;
            frame.frameType = ;
            frame.framePrice = txtFrameprice.Text;
            frame.frameQuantity =;
        }
    }
}