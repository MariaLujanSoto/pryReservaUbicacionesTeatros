using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryReservaUbicacionesTeatros
{
    public partial class frmReservaQuenaken : Form
    {
        public frmReservaQuenaken()
        {
            InitializeComponent();
        }


        private void frmReservaQuenaken_Load(object sender, EventArgs e)
        {
             
        
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {

        }

        string AsientosElegidos ;
        
        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (A1.Checked)
            {
                A1.Enabled = false;
                
               
            }
            if (A2.Checked)
            {
                A2.Enabled = false;

            }
            if (A3.Checked)
            {
                A3.Enabled = false;

            }



        }

        private void B3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
