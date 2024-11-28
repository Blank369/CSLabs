namespace lab5
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            numericUpDown_max = new NumericUpDown();
            label1 = new Label();
            numericUpDown_min = new NumericUpDown();
            groupBox2 = new GroupBox();
            radioButton_vert = new RadioButton();
            radioButton_horiz = new RadioButton();
            groupBox3 = new GroupBox();
            numericUpDown_column = new NumericUpDown();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox_output = new TextBox();
            button_clear = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_max).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_min).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_column).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numericUpDown_max);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown_min);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(168, 108);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Диапазон значений";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(6, 69);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 3;
            label2.Text = "max";
            // 
            // numericUpDown_max
            // 
            numericUpDown_max.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown_max.Location = new Point(71, 67);
            numericUpDown_max.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            numericUpDown_max.Name = "numericUpDown_max";
            numericUpDown_max.Size = new Size(75, 27);
            numericUpDown_max.TabIndex = 2;
            numericUpDown_max.Value = new decimal(new int[] { 9, 0, 0, 0 });
            numericUpDown_max.ValueChanged += numericUpDown_max_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 1;
            label1.Text = "min";
            // 
            // numericUpDown_min
            // 
            numericUpDown_min.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown_min.Location = new Point(71, 34);
            numericUpDown_min.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDown_min.Minimum = new decimal(new int[] { 255, 0, 0, int.MinValue });
            numericUpDown_min.Name = "numericUpDown_min";
            numericUpDown_min.Size = new Size(75, 27);
            numericUpDown_min.TabIndex = 0;
            numericUpDown_min.ValueChanged += numericUpDown_min_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(radioButton_vert);
            groupBox2.Controls.Add(radioButton_horiz);
            groupBox2.Location = new Point(3, 117);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(168, 108);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ориентация";
            // 
            // radioButton_vert
            // 
            radioButton_vert.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton_vert.AutoSize = true;
            radioButton_vert.Location = new Point(6, 67);
            radioButton_vert.Name = "radioButton_vert";
            radioButton_vert.Size = new Size(127, 24);
            radioButton_vert.TabIndex = 1;
            radioButton_vert.Text = "Вертикальная";
            radioButton_vert.UseVisualStyleBackColor = true;
            // 
            // radioButton_horiz
            // 
            radioButton_horiz.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton_horiz.AutoSize = true;
            radioButton_horiz.Checked = true;
            radioButton_horiz.Location = new Point(6, 29);
            radioButton_horiz.Name = "radioButton_horiz";
            radioButton_horiz.Size = new Size(144, 24);
            radioButton_horiz.TabIndex = 0;
            radioButton_horiz.TabStop = true;
            radioButton_horiz.Text = "Горизонтальная";
            radioButton_horiz.UseVisualStyleBackColor = true;
            radioButton_horiz.CheckedChanged += radioButton_horiz_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(numericUpDown_column);
            groupBox3.Location = new Point(177, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(148, 89);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Кол-во колонок/строк";
            // 
            // numericUpDown_column
            // 
            numericUpDown_column.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown_column.Location = new Point(37, 46);
            numericUpDown_column.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            numericUpDown_column.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_column.Name = "numericUpDown_column";
            numericUpDown_column.Size = new Size(75, 27);
            numericUpDown_column.TabIndex = 4;
            numericUpDown_column.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_column.ValueChanged += numericUpDown_column_ValueChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Location = new Point(519, 291);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(337, 236);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // textBox_output
            // 
            textBox_output.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_output.Location = new Point(519, 12);
            textBox_output.Multiline = true;
            textBox_output.Name = "textBox_output";
            textBox_output.Size = new Size(337, 227);
            textBox_output.TabIndex = 5;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_clear.Location = new Point(648, 245);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(94, 29);
            button_clear.TabIndex = 6;
            button_clear.Text = "Очистить";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 528);
            Controls.Add(button_clear);
            Controls.Add(textBox_output);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Числовая панель";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_max).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_min).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_column).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private NumericUpDown numericUpDown_max;
        private Label label1;
        private NumericUpDown numericUpDown_min;
        private GroupBox groupBox2;
        private RadioButton radioButton_vert;
        private RadioButton radioButton_horiz;
        private GroupBox groupBox3;
        private NumericUpDown numericUpDown_column;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox_output;
        private Button button_clear;
    }
}
