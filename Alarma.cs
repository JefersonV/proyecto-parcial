using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domotica
{
    public partial class Alarma : Form
    {
        System.IO.Ports.SerialPort Arduino;
        public Alarma(SerialPort arduino)
        {
            InitializeComponent();
            Arduino = arduino;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAcceptAlarmaModal_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == "ha$h")
            {
                DialogResult = DialogResult.OK;
                Arduino.Write("5");
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }

        private void btnCloseAlarmaModal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
