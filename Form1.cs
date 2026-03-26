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
            txtRAM.Visible = true;

            txtCPU.Visible = false;
            txtSSD.Visible = false;
            txtpowersupply.Visible = false;
            txtinput.Visible = false;
            txtoutput.Visible = false;
        }

        private void rbtnssd_CheckedChanged(object sender, EventArgs e)
        {
            imgCPU.Image = Properties.Resources.SSDGOOD;
            txtSSD.Visible = true;

            txtCPU.Visible = false;
            txtRAM.Visible = false;
            txtpowersupply.Visible = false;
            txtinput.Visible = false;
            txtoutput.Visible = false;

        }

        private void rbtnpowersupply_CheckedChanged(object sender, EventArgs e)
        {
            imgCPU.Image= Properties.Resources.power_supply;
            txtpowersupply.Visible = true;

            txtCPU.Visible = false;
            txtRAM.Visible = false;
            txtSSD.Visible = false;
            txtinput.Visible = false;
            txtoutput.Visible = false;
        }

        private void rbtnimputperipheral_CheckedChanged(object sender, EventArgs e)
        {
            Random generator = new Random();
            int randNum = generator.Next(1, 3);
            if (randNum == 1)
            {
                imgCPU.Image = Properties.Resources.inputone;
            }
            else
            {
                imgCPU.Image = Properties.Resources.inputtwo;
            }
            
            txtinput.Visible = true;

            txtCPU.Visible = false;
            txtRAM.Visible = false;
            txtSSD.Visible = false;
            txtpowersupply.Visible = false;
            txtoutput.Visible = false;
        }

        

        private void rbtnoutputperipheral_CheckedChanged(object sender, EventArgs e)
        {
            
            Random generator = new Random();
            int randNum= generator.Next(1,3); 
            if (randNum == 1)
            {
                imgCPU.Image = Properties.Resources.outputone;
            }
            else
            {
                imgCPU.Image = Properties.Resources.outputtwo;
            }

            txtoutput.Visible = true;

            txtSSD.Visible = false;
            txtRAM.Visible = false;
            txtCPU.Visible = false;
            txtpowersupply.Visible = false;
            txtinput.Visible = false;
        }

        private void rbtncpu2_CheckedChanged(object sender, EventArgs e)
        {
            imgCPU.Image = Properties.Resources.CPU;
            txtCPU.Visible = true;

            txtRAM.Visible = false;
            txtSSD.Visible = false;
            txtpowersupply.Visible = false;
            txtinput.Visible = false;
            txtoutput.Visible = false;
        }
    }
}
