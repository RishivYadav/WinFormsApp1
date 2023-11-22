namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            Age = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            comboBox1 = new ComboBox();
            button4 = new Button();
            button5 = new Button();
            checkedListBox1 = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();



            comboBox1 = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Items = { "Male", "Female", "Others" },
                Location = new System.Drawing.Point(87, 115),
                Name = "comboBox1",
                Size = new Size(121, 23),
                TabIndex = 5,
            };
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            // Modify the numericUpDown1 initialization in the InitializeComponent method
            numericUpDown1 = new NumericUpDown
            {
                Location = new System.Drawing.Point(87, 59),
                Maximum = new decimal(new int[] { 60, 0, 0, 0 }),
                Minimum = new decimal(new int[] { 1, 0, 0, 0 }),
                Name = "numericUpDown1",
                Size = new Size(120, 23),
                TabIndex = 3,
                ReadOnly = true, // Set ReadOnly to true
                Value = new decimal(new int[] { 1, 0, 0, 0 }),
            };
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(87, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.BackColor = SystemColors.MenuHighlight;
            Age.Location = new Point(22, 61);
            Age.Name = "Age";
            Age.Size = new Size(28, 15);
            Age.TabIndex = 2;
            Age.Text = "Age";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(87, 59);
            numericUpDown1.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.MenuHighlight;
            label2.Location = new Point(16, 118);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.MenuHighlight;
            label3.Location = new Point(16, 173);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Address";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 159);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(334, 72);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(22, 237);
            button1.Name = "button1";
            button1.Size = new Size(75, 40);
            button1.TabIndex = 8;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(170, 237);
            button2.Name = "button2";
            button2.Size = new Size(75, 40);
            button2.TabIndex = 9;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(322, 237);
            button3.Name = "button3";
            button3.Size = new Size(75, 40);
            button3.TabIndex = 10;
            button3.Text = "CANCEL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // comboBox1
            // 
            comboBox1.Location = new Point(86, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.AliceBlue;
            button4.Location = new Point(87, 405);
            button4.Name = "button4";
            button4.Size = new Size(75, 33);
            button4.TabIndex = 12;
            button4.Text = "SEND";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Magenta;
            button5.Location = new Point(248, 405);
            button5.Name = "button5";
            button5.Size = new Size(75, 33);
            button5.TabIndex = 13;
            button5.Text = "DELETE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 294);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(557, 94);
            checkedListBox1.TabIndex = 14;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(833, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(Age);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label Age;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button4;
        private Button button5;
        private CheckedListBox checkedListBox1;
    }
}