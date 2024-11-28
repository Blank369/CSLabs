using System;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab4
{
    public partial class Form7 : Form
    {
        FEFO<Yogurt> listYogurt = new FEFO<Yogurt>();
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox_mass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool CheckTextBoxs()
        {
            if (textBox_name.Text == "" || textBox_mass.Text == "" || textBox_price.Text == "")
            {
                MessageBox.Show("Заполните все поля", "", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxs())
            {
                Yogurt newYogurt = new Yogurt(textBox_name.Text, int.Parse(textBox_mass.Text), float.Parse(textBox_price.Text), dateTimePicker_expirationDate.Value);

                listYogurt.Add(newYogurt);
                RewriteListView();
            }
        }


        void RewriteListView()
        {

            //INotifyPropertyChanged

            listView1.Items.Clear();
            foreach (var item in listYogurt)
            {
                listView1.Items.Add(new ListViewItem(new string[] { item.Name, item.NetWeight.ToString(), item.Price.ToString(),
                                                                    item.ExpirationDate.ToString("yyyy-MM-dd"), item.GetExpireDays().ToString() }));
            }
            textBox_count.Text = listYogurt.Count.ToString();
        }

        private void button_example_Click(object sender, EventArgs e)
        {
            ShowInfo("Растишка", 190, 73.99f, new DateTime(2024, 10, 15));
        }

        void ShowInfo(string name, int weight, float price, DateTime expirationDate)
        {
            textBox_name.Text = name;
            textBox_mass.Text = weight.ToString();
            textBox_price.Text = price.ToString();
            dateTimePicker_expirationDate.Value = expirationDate;
        }

        void ClearFields()
        {
            textBox_name.Clear();
            textBox_mass.Clear();
            textBox_price.Clear();
            dateTimePicker_expirationDate.Value = DateTime.Now;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (radioButton_delChecked.Checked)
            {
                if (listView1.SelectedItems.Count != 0) listYogurt.RemoveAt(listView1.SelectedIndices[0]);
            }
            else if (radioButton_delED.Checked)
            {
                listYogurt.RemoveBad(int.Parse(textBox_max.Text));
            }
            else if (radioButton_delAll.Checked)
            {
                listYogurt.Clear();
            }

            RewriteListView();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void button_fresh_Click(object sender, EventArgs e)
        {
            Yogurt freshYogurt = listYogurt.PopFresh();

            ShowInfo(freshYogurt.Name, freshYogurt.NetWeight, freshYogurt.Price, freshYogurt.ExpirationDate);
        }

        private void button_bad_Click(object sender, EventArgs e)
        {
            //List<int> g = new List<int>();


            Yogurt badYogurt = listYogurt.PopBad();
            ShowInfo(badYogurt.Name, badYogurt.NetWeight, badYogurt.Price, badYogurt.ExpirationDate);
        }

        public BindingList<Yogurt> yogurts = new BindingList<Yogurt>();

        private void Form7_Load(object sender, EventArgs e)
        {
            yogurts.Add(new Yogurt("Растишка", 170, 80, DateTime.Now));
            yogurts.Add(new Yogurt("Растишка", 170, 80, DateTime.Now.AddDays(3)));

            bindingSource1.DataSource = yogurts;

            dataGridView1.DataSource = bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //yogurts.Add(new Yogurt("Растишка", 370, 80, DateTime.Now));
            yogurts[0].Name = "Чудо";
            //MessageBox.Show(yogurts[0].Price.ToString());
        }
    }
}
