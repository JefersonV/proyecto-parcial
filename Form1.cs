namespace domotica
{
    public partial class Form1 : Form
    {

        System.IO.Ports.SerialPort Arduino;
        //timer
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            //
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            // Intervalo en milisegundos (1 segundo)
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            try
            {
                Arduino = new System.IO.Ports.SerialPort("COM6", 9600);
                Arduino.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el puerto COM: {ex.Message}");
            }
        }

        private void Timer_Tick(object? sender, EventArgs e) // Agregar el modificador de nulabilidad para resolver CS8622
        {
            // Lógica del temporizador
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arduino.Write("1");
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
            Alarma alarm = new Alarma(Arduino);
            alarm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCloseDoor_Click(object sender, EventArgs e)
        {
            Arduino.Write("2");
        }

        private void btnOpenWindow_Click(object sender, EventArgs e)
        {
            Arduino.Write("3");
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Arduino.Write("4");
        }
    }
}
