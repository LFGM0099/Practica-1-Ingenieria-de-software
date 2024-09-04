using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Temperatura
{
    public partial class InterfazSensoresN3 : Form
    {
        public InterfazSensoresN3()
        {
            InitializeComponent();
        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            txtReloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnActivar1_Click(object sender, EventArgs e)
        {
            txtFoco1.BackColor = Color.Green;
        }

        private void btnDesactivar1_Click(object sender, EventArgs e)
        {
            txtFoco1.BackColor = Color.Red;
            txtFoco1.Clear();
        }

        private void btnActivar2_Click(object sender, EventArgs e)
        {
            txtFoco2.BackColor = Color.Green;
        }

        private void btnDesactivar2_Click(object sender, EventArgs e)
        {
            txtFoco2.BackColor= Color.Red;
            txtFoco2.Clear();
        }

        private void btnActivar3_Click(object sender, EventArgs e)
        {
            txtFoco3.BackColor = Color.Green;
        }

        private void btnDesactivar3_Click(object sender, EventArgs e)
        {
            txtFoco3.BackColor = Color.Red;
            txtFoco3.Clear();
        }

        private void btnActivar4_Click(object sender, EventArgs e)
        {
            txtFoco4.BackColor = Color.Green;
        }

        private void btnDesactivar4_Click(object sender, EventArgs e)
        {
            txtFoco4.BackColor = Color.Red;
            txtFoco4.Clear();
        }
    }
}
