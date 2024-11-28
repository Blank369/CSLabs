namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //label1.Text = metronome1.PendulumAngle.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metronome1.SwitchedOn = !metronome1.SwitchedOn;
            label1.Text = metronome1.SwitchedOn.ToString();
            //metronome1.PendulumAngle += 1;
            // label1.Text = metronome1.PendulumPosition.ToString();
            //label2.Text = metronome1.BPM.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = metronome1.BPM.ToString();
        }
    }
}
