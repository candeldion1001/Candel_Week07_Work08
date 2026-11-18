using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candel_Week07_Work08
{
    public partial class ucProductListing : UserControl
    {
        public ucProductListing()
        {
            InitializeComponent();
        }

        string[] units = { "Piece", "Box", "Kilogram" };

        List<string> shoppinglist = new List<string>();

        private void ucProductListing_Load(object sender, EventArgs e)
        {
            cmbUnit.Items.AddRange(units);
            cmbUnit.SelectedIndex = 0;

            dgvItems.DataSource = shoppinglist;
        }

        private void updateGUI()
        {
            dgvItems.DataSource = null;
            dgvItems.DataSource = shoppinglist;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
        }
    }
}

