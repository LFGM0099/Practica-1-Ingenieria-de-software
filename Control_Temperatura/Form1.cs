using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Temperatura
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> usuariosClaves = new Dictionary<string, string>
    {
        { "UsuariosN1", "111" },
        { "UsuariosN2", "222" },
        { "UsuariosN3", "333" }
    };
        public Form1()
        {
            InitializeComponent();

            cmbUsuarios.Items.Add("UsuariosN1");
            cmbUsuarios.Items.Add("UsuariosN2");
            cmbUsuarios.Items.Add("UsuariosN3");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string seleccion = cmbUsuarios.SelectedItem?.ToString();

            if (seleccion == null)
            {
                MessageBox.Show("Por favor, selecciona una opción.");
                return;
            }

            // Verificar si la clave ingresada es correcta
            if (txtClave.Text != usuariosClaves[seleccion])
            {
                MessageBox.Show("Clave incorrecta. Intenta nuevamente.");
                return;
            }

            Form Form = null;

            btnAceptar.Click += btnAceptar_Click;

            switch (seleccion)
            {
                case "UsuariosN1":
                    Form = new InterfazSensoresN1();
                    break;
                case "UsuariosN2":
                    Form = new InterfazSensoresN2();
                    break;
                case "UsuariosN3":
                    Form = new InterfazSensoresN3();
                    break;
            }
            Form?.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
