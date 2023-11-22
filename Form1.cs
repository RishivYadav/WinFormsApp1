using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private List<string> formDataList;
        private Label labelName;
        private Label labelAge;
        private Label labelGender;
        private Label labelAddress;

        public Form1()
        {
            InitializeComponent();
            InitializeLabels();
            formDataList = new List<string>();

            // Hook up the event handler for CheckedListBox selection change
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
        }
        private void InitializeLabels()
        {
            // Create labels to display saved data
            labelName = new Label
            {
                Location = new System.Drawing.Point(22, 300),
                Name = "labelName",
                AutoSize = true,
            };

            labelAge = new Label
            {
                Location = new System.Drawing.Point(22, 320),
                Name = "labelAge",
                AutoSize = true,
            };

            labelGender = new Label
            {
                Location = new System.Drawing.Point(22, 340),
                Name = "labelGender",
                AutoSize = true,
            };

            labelAddress = new Label
            {
                Location = new System.Drawing.Point(22, 360),
                Name = "labelAddress",
                AutoSize = true,
            };

            // Add labels to the form
            Controls.Add(labelName);
            Controls.Add(labelAge);
            Controls.Add(labelGender);
            Controls.Add(labelAddress);

            // Controls.Add(textBoxDisplayData);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            ValidateNameTextBox();
        }


        private void ValidateNameTextBox()
        {
            string input = textBox1.Text;

            if (input.Length >= 5 && input.Length <= 35)

            {

                //if (input.All(char.IsLetter) || input.All(char.IsWhiteSpace) )
                //if (input.All(c => char.IsLetter(c) || (char.IsWhiteSpace(c) && c == ' ')))
                if (input.All(char.IsLetter) || (input.Contains(" ") && input.Split(' ').All(s => s.All(char.IsLetter))))
                // if (input.All(c => char.IsLetter(c) || c == ' '))
                {
                    errorProvider1.SetError(textBox1, "");
                }
                else
                {
                    errorProvider1.SetError(textBox1, "Name must contain only alphabetic characters");
                }
            }
            else
            {
                errorProvider1.SetError(textBox1, "Name must be between 5 and 35 characters");
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            ValidateTextBox2();
        }
        private void ValidateTextBox2()
        {
            string input = textBox2.Text;


            if (input.Length >= 15 && input.Length <= 100)
            {

                errorProvider2.SetError(textBox2, "");
            }
            else
            {

                errorProvider2.SetError(textBox2, "Text must be between 15 and 100 characters");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveDataToForm();
            AddDataToCheckedListBox();
        }

        private void SaveDataToForm()
        {
            string name = textBox1.Text;
            string age = numericUpDown1.Value.ToString();
            string gender = comboBox1.Text;
            string address = textBox2.Text;

            if (ValidateData(name, age, gender, address))
            {
                string formData = $"Name: {name}, Age: {age}, Gender: {gender}, Address: {address}";

                // Check if the data is already in the list
                if (!formDataList.Contains(formData))
                {
                    formDataList.Add(formData);
                    DisplaySavedData(name, age, gender, address);
                    MessageBox.Show("Data saved to form successfully!", "Save Data");
                }
                else
                {
                    MessageBox.Show("Data is already saved.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid data before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddDataToCheckedListBox()
        {
            // Add data to CheckedListBox logic
            string name = textBox1.Text;
            string age = numericUpDown1.Value.ToString();
            string gender = comboBox1.Text;
            string address = textBox2.Text;

            string formData = $"Name: {name}, Age: {age}, Gender: {gender}, Address: {address}";
            checkedListBox1.Items.Add(formData);
            formDataList.Add(formData);
        }





        private void DisplaySavedData(string name, string age, string gender, string address)
        {
            // Display the saved data in labels
            labelName.Text = $"Name: {name}";
            labelAge.Text = $"Age: {age}";
            labelGender.Text = $"Gender: {gender}";
            labelAddress.Text = $"Address: {address}";
            // textBoxDisplayData.Text = string.Join(Environment.NewLine + "------------------" + Environment.NewLine, formDataList);
        }


        private bool ValidateData(string name, string age, string gender, string address)
        {

            if (string.IsNullOrWhiteSpace(name) || (!name.Replace(" ", "").All(char.IsLetter) || name.Count(c => c == ' ') > 1) || name.Length < 5 || name.Length > 35)
                return false;


            if (string.IsNullOrWhiteSpace(address) || address.Length < 15 || address.Length > 100)
                return false;

            if (string.IsNullOrWhiteSpace(age) || !int.TryParse(age, out _) || int.Parse(age) < 1 || int.Parse(age) > 60)
                return false;

            if (string.IsNullOrWhiteSpace(gender))
                return false;



            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            //numericUpDown1.Clear();
            numericUpDown1.Value = numericUpDown1.Minimum;

            errorProvider1.SetError(textBox1, "");
            errorProvider2.SetError(textBox2, "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            SaveDataToFile();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ClearFormData();
            DeleteSelectedItems();
        }
        private void SaveDataToFile()
        {
            // Filter only the checked items
            var checkedItems = checkedListBox1.CheckedItems.OfType<string>().ToList();

            if (checkedItems.Any())
            {
                // Create a SaveFileDialog to prompt the user for the file path
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.FileName = "UserData.txt"; // Default file name

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        // Save only the checked items to the selected file
                        File.WriteAllLines(filePath, checkedItems);

                        MessageBox.Show("Data saved to file successfully!", "Save Data");
                    }
                }
            }
            else
            {
                MessageBox.Show("No data selected to save. Check items in the list first.", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void ClearFormData()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            numericUpDown1.Value = numericUpDown1.Minimum;

            errorProvider1.SetError(textBox1, "");
            errorProvider2.SetError(textBox2, "");

            // You may also want to clear the displayed data labels if you have them
            labelName.Text = "";
            labelAge.Text = "";
            labelGender.Text = "";
            labelAddress.Text = "";

            // Clear the list of form data
            formDataList.Clear();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle CheckedListBox selection change
            int selectedIndex = checkedListBox1.SelectedIndex;

            if (selectedIndex != -1)
            {
                // Retrieve the selected item
                string selectedItem = checkedListBox1.Items[selectedIndex].ToString();

                // Display the selected item's data in labels or perform any other logic
                DisplaySelectedData(selectedItem);
            }
        }
        private void DisplaySelectedData(string selectedItem)
        {
            // You can display the selected item's data in labels or perform any other logic
            // For example, split the string to get individual data fields
            string[] dataFields = selectedItem.Split(new[] { ',', ':' }, StringSplitOptions.RemoveEmptyEntries);

            // Assuming the format is consistent
            string name = dataFields[1].Trim();
            string age = dataFields[3].Trim();
            string gender = dataFields[5].Trim();
            string address = dataFields[7].Trim();

            // Update the form to display the selected data
            DisplaySavedData(name, age, gender, address);
        }

        private void DeleteSelectedItems()
        {
            // Remove selected items from the CheckedListBox and formDataList
            for (int i = checkedListBox1.CheckedItems.Count - 1; i >= 0; i--)
            {
                int index = checkedListBox1.Items.IndexOf(checkedListBox1.CheckedItems[i]);
                checkedListBox1.Items.RemoveAt(index);
                formDataList.RemoveAt(index);
            }
        }
    }

}

