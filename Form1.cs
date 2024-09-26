namespace domotica
{
    public partial class Domotica : Form
    {
        public Domotica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Temperatura temp = new Temperatura();
            temp.ShowDialog();
            if (temp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Cancel");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Alarma alarm = new Alarma();
            alarm.ShowDialog();
        }
    }
}
