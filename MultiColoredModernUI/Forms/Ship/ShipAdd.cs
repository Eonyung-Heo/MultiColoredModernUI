using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiColoredModernUI.Forms.Ship
{
    public partial class ShipAdd : Form
    {
        public ShipAdd()
        {
            InitializeComponent();
        }

        private void Ship_XYMap_Bt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tablog.neocities.org/keywordposition");
        }
    }
}
