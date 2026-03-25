using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adding_to_resources_assignment
{
    public partial class rbtncpu : Form
    {
        public rbtncpu()
        {
            InitializeComponent();
        }

        

        private void rbtnram_CheckedChanged(object sender, EventArgs e)
        {
            imgCPU.Image= Properties.Resources.RAM_Memory;
        }

        private void rbtnssd_CheckedChanged(object sender, EventArgs e)
        {
            imgCPU.Image = Properties.Resources.SSDGOOD;
        }

        private void rbtnpowersupply_CheckedChanged(object sender, EventArgs e)
        {
            imgCPU.Image= Properties.Resources.power_supply;
        }

        private void rbtnimputperipheral_CheckedChanged(object sender, EventArgs e)
        {
            imgCPU.Image = Properties.Resources.inputone;
            
        }
    }
}
