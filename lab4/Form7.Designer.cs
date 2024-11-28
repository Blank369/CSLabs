namespace lab4
{
    partial class Form7
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            groupBox1 = new GroupBox();
            button_clear = new Button();
            button_example = new Button();
            button_add = new Button();
            label6 = new Label();
            dateTimePicker_expirationDate = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            textBox_price = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox_mass = new TextBox();
            label1 = new Label();
            textBox_name = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            textBox_count = new TextBox();
            button_fresh = new Button();
            groupBox3 = new GroupBox();
            button_bad = new Button();
            button_delete = new Button();
            groupBox4 = new GroupBox();
            radioButton_delAll = new RadioButton();
            textBox_max = new TextBox();
            radioButton_delED = new RadioButton();
            radioButton_delChecked = new RadioButton();
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.GridLines = true;
            listView1.ImeMode = ImeMode.NoControl;
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(654, 342);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Название";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Масса нетто";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Цена";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Срок годности";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "До конца СГ";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 100;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_clear);
            groupBox1.Controls.Add(button_example);
            groupBox1.Controls.Add(button_add);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker_expirationDate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox_price);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_mass);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_name);
            groupBox1.Location = new Point(12, 370);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 317);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить йогурт";
            // 
            // button_clear
            // 
            button_clear.Location = new Point(234, 271);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(94, 29);
            button_clear.TabIndex = 8;
            button_clear.Text = "Очистить";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_example
            // 
            button_example.Location = new Point(98, 205);
            button_example.Name = "button_example";
            button_example.Size = new Size(147, 51);
            button_example.TabIndex = 9;
            button_example.Text = "Показать пример";
            button_example.UseVisualStyleBackColor = true;
            button_example.Click += button_example_Click;
            // 
            // button_add
            // 
            button_add.Location = new Point(15, 271);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 7;
            button_add.Text = "Добавить";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 153);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 9;
            label6.Text = "Срок годности:";
            // 
            // dateTimePicker_expirationDate
            // 
            dateTimePicker_expirationDate.Location = new Point(134, 148);
            dateTimePicker_expirationDate.Name = "dateTimePicker_expirationDate";
            dateTimePicker_expirationDate.Size = new Size(194, 27);
            dateTimePicker_expirationDate.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(228, 116);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 7;
            label4.Text = "руб";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 116);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 6;
            label5.Text = "Цена:";
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(135, 113);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(87, 27);
            textBox_price.TabIndex = 5;
            textBox_price.KeyPress += textBox_price_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 83);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 4;
            label3.Text = "г";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 83);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 3;
            label2.Text = "Масса нетто:";
            // 
            // textBox_mass
            // 
            textBox_mass.Location = new Point(134, 80);
            textBox_mass.Name = "textBox_mass";
            textBox_mass.Size = new Size(87, 27);
            textBox_mass.TabIndex = 2;
            textBox_mass.KeyPress += textBox_mass_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 50);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Название:";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(134, 47);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(193, 27);
            textBox_name.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(876, 325);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Обновить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox_count);
            groupBox2.Location = new Point(560, 358);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(106, 82);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Количество элементов";
            // 
            // textBox_count
            // 
            textBox_count.Location = new Point(12, 49);
            textBox_count.Name = "textBox_count";
            textBox_count.ReadOnly = true;
            textBox_count.Size = new Size(80, 27);
            textBox_count.TabIndex = 3;
            // 
            // button_fresh
            // 
            button_fresh.BackColor = Color.PaleGreen;
            button_fresh.Location = new Point(6, 26);
            button_fresh.Name = "button_fresh";
            button_fresh.Size = new Size(134, 32);
            button_fresh.TabIndex = 3;
            button_fresh.Text = "Самый свежий";
            button_fresh.UseVisualStyleBackColor = false;
            button_fresh.Click += button_fresh_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button_bad);
            groupBox3.Controls.Add(button_fresh);
            groupBox3.Location = new Point(380, 450);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(289, 76);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Показать продукт";
            // 
            // button_bad
            // 
            button_bad.BackColor = Color.LightCoral;
            button_bad.Location = new Point(145, 25);
            button_bad.Name = "button_bad";
            button_bad.Size = new Size(134, 32);
            button_bad.TabIndex = 4;
            button_bad.Text = "Самый плохой";
            button_bad.UseVisualStyleBackColor = false;
            button_bad.Click += button_bad_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(77, 120);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(148, 29);
            button_delete.TabIndex = 5;
            button_delete.Text = "Удалить";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton_delAll);
            groupBox4.Controls.Add(textBox_max);
            groupBox4.Controls.Add(radioButton_delED);
            groupBox4.Controls.Add(radioButton_delChecked);
            groupBox4.Controls.Add(button_delete);
            groupBox4.Location = new Point(380, 532);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(286, 155);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Удалить";
            // 
            // radioButton_delAll
            // 
            radioButton_delAll.AutoSize = true;
            radioButton_delAll.Location = new Point(6, 86);
            radioButton_delAll.Name = "radioButton_delAll";
            radioButton_delAll.Size = new Size(113, 24);
            radioButton_delAll.TabIndex = 9;
            radioButton_delAll.TabStop = true;
            radioButton_delAll.Text = "Удалить все";
            radioButton_delAll.UseVisualStyleBackColor = true;
            // 
            // textBox_max
            // 
            textBox_max.Location = new Point(145, 55);
            textBox_max.Name = "textBox_max";
            textBox_max.Size = new Size(91, 27);
            textBox_max.TabIndex = 8;
            // 
            // radioButton_delED
            // 
            radioButton_delED.AutoSize = true;
            radioButton_delED.Location = new Point(6, 56);
            radioButton_delED.Name = "radioButton_delED";
            radioButton_delED.Size = new Size(133, 24);
            radioButton_delED.TabIndex = 7;
            radioButton_delED.TabStop = true;
            radioButton_delED.Text = "До конца СГ ≤ ";
            radioButton_delED.UseVisualStyleBackColor = true;
            // 
            // radioButton_delChecked
            // 
            radioButton_delChecked.AutoSize = true;
            radioButton_delChecked.Location = new Point(6, 26);
            radioButton_delChecked.Name = "radioButton_delChecked";
            radioButton_delChecked.Size = new Size(164, 24);
            radioButton_delChecked.TabIndex = 6;
            radioButton_delChecked.TabStop = true;
            radioButton_delChecked.Text = "Выбранный йогурт";
            radioButton_delChecked.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(672, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(497, 306);
            dataGridView1.TabIndex = 7;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 709);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            Name = "Form7";
            Text = "выбираем йогурт";
            Load += Form7_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox_count;
        private Button button_fresh;
        private GroupBox groupBox3;
        private Button button_bad;
        private Button button_delete;
        private GroupBox groupBox4;
        private RadioButton radioButton_delED;
        private RadioButton radioButton_delChecked;
        private RadioButton radioButton_delAll;
        private TextBox textBox_max;
        private Button button_add;
        private Label label1;
        private TextBox textBox_name;
        private Button button_clear;
        private Button button_example;
        private Label label3;
        private Label label2;
        private TextBox textBox_mass;
        private Label label6;
        private DateTimePicker dateTimePicker_expirationDate;
        private Label label4;
        private Label label5;
        private TextBox textBox_price;
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
