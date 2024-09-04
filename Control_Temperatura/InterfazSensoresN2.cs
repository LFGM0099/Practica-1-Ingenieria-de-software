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
    public partial class InterfazSensoresN2 : Form
    {
        public InterfazSensoresN2()
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
            timerSensor1.Start();
        }

        private void btnDesactivar1_Click(object sender, EventArgs e)
        {
            txtFoco1.BackColor = Color.Red;
            timerSensor1.Stop();
            txtFoco1.Clear();
        }

        private void timerSensor1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int temperatura = random.Next(-10, 40);
            lblTemperatura1.Text = temperatura.ToString("0.0") + " °C";
        }

        private void btnActivar2_Click(object sender, EventArgs e)
        {
            txtFoco2.BackColor = Color.Green;
            timerSensor2.Start();
        }

        private void btnDesactivar2_Click(object sender, EventArgs e)
        {
            txtFoco2.BackColor = Color.Red;
            timerSensor2.Stop();
            txtFoco2.Clear();
        }

        private void timerSensor2_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int temperatura = random.Next(-10, 40);
            lblTemperatura2.Text = temperatura.ToString("0.0") + " °C";
        }

        private void btnActivar3_Click(object sender, EventArgs e)
        {
            txtFoco3.BackColor = Color.Green;
            timerSensor3.Start();
        }

        private void btnDesactivar3_Click(object sender, EventArgs e)
        {
            txtFoco3.BackColor = Color.Red;
            timerSensor3.Stop();
            txtFoco3.Clear();
        }

        private void timerSensor3_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int temperatura = random.Next(-10, 40);
            lblTemperatura3.Text = temperatura.ToString("0.0") + " °C";
        }

        private void btnActivar4_Click(object sender, EventArgs e)
        {
            txtFoco4.BackColor = Color.Green;
            timerSensor4.Start();
        }

        private void btnDesactivar4_Click(object sender, EventArgs e)
        {
            txtFoco4.BackColor = Color.Red;
            timerSensor4.Stop();
            txtFoco4.Clear();
        }

        private void timerSensor4_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int temperatura = random.Next(-10, 40);
            lblTemperatura4.Text = temperatura.ToString("0.0") + " °C";
        }
    }
}
