using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class patientform : Form
    {
        private Dictionary<string, string> savedTexts = new Dictionary<string, string>();
        public Patient Patient { get; set; }
        public patientform()
        {
            InitializeComponent();
            Patient=null;
        }
        public patientform(Patient Patient) : this()
        {
            Namebb.Text = Patient.Name;
            male.Checked=Patient.Gender == Gender.Male; 
            female.Checked=Patient.Gender==Gender.Female;
            Follow.Checked = Patient.Follow;
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
         string age = textBoxAge.Text;
            string address= textBoxAddress.Text;
            string phone = textBoxPhone.Text; 
            string name = Namebb.Text;
          Gender gender =  Gender.Male;
            if(female.Checked)
             gender = Gender.Female ;
           bool follow = Follow.Checked ;
            Patient = new Patient(name, gender, follow, age, phone, address);
            DialogResult = DialogResult.OK;
            try
            {
                // Get text from all TextBoxes
                string ageText = textBoxAge.Text.Trim();
                string addressText = textBoxAddress.Text.Trim();
                string phoneText = textBoxPhone.Text.Trim();

                // Validate that at least one field has content
                if (string.IsNullOrEmpty(ageText) &&
                    string.IsNullOrEmpty(addressText) &&
                    string.IsNullOrEmpty(phoneText))
                {
                    MessageBox.Show("Please enter data in at least one field.", "Warning",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Save to memory dictionary
                savedTexts["textBoxAge"] = ageText;
                savedTexts["textBoxAddress"] = addressText;
                savedTexts["textBoxPhone"] = phoneText;

                // Save to file (modified to handle multiple fields)
                SaveTextToFile(ageText, addressText, phoneText);

                MessageBox.Show("Patient data saved successfully!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving patient data: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveTextToFile(string age, string address, string phone)
        {
            string filePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "PatientData.txt");

            // Create a formatted string with all data
            string dataToSave = $"Age: {age}\nAddress: {address}\nPhone: {phone}";

            File.WriteAllText(filePath, dataToSave);
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
