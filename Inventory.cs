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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }
        private void ShowPage(UserControl page)
        {
            pnlContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }

        private void productListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPage(new ucProductListing());
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPage(new ucHomePage());
        }
    }
}
