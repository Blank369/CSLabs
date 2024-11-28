using static lab5.NumberPanel;

namespace lab5
{
    public partial class Form1 : Form
    {
        NumberPanel numPanel1 = new NumberPanel();

        public Form1()
        {
            InitializeComponent();

            numPanel1.MinValue = (int)numericUpDown_min.Value;
            numPanel1.MaxValue = (int)numericUpDown_max.Value;
            numPanel1.IsHorisontal = radioButton_horiz.Checked;
            numPanel1.SizeM = (int)numericUpDown_column.Value;

            numPanel1.NumberClicked += numPanel1_OnNumberClicked;

            this.Controls.Add(numPanel1);
        }

        private void numPanel1_OnNumberClicked(object sender, NumberPanelEventArgs e)
        {
            textBox_output.Text += e.Num.ToString();
        }

        private void numericUpDown_min_ValueChanged(object sender, EventArgs e)
        {
            numPanel1.MinValue = (int)numericUpDown_min.Value;
            numericUpDown_min.Value = numPanel1.MinValue;
        }

        private void numericUpDown_max_ValueChanged(object sender, EventArgs e)
        {
            numPanel1.MaxValue = (int)numericUpDown_max.Value;
            numericUpDown_max.Value = numPanel1.MaxValue;

        }

        private void radioButton_horiz_CheckedChanged(object sender, EventArgs e)
        {
            numPanel1.IsHorisontal = radioButton_horiz.Checked;
        }

        private void numericUpDown_column_ValueChanged(object sender, EventArgs e)
        {
            numPanel1.SizeM = (int)numericUpDown_column.Value;
            numericUpDown_column.Value = numPanel1.SizeM; 
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_output.Clear();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    class1.Check = !class1.Check;
        //}
    }
}
