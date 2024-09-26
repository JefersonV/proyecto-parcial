using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domotica
{
    public partial class Alarma : Form
    {
        public Alarma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAcceptAlarmaModal_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == "5371")
            {
                DialogResult = DialogResult.OK;
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
