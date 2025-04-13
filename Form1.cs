using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace Clinic
{
    public partial class Clinic : Form
    {

        public Clinic()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            patientform form = new patientform();
            DialogResult result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Add");
                Patient patient = form.Patient;
                listBox.Items.Add(patient);



            }

        }

        private void editbtn_Click(object sender, EventArgs e)
        {

            int index = listBox.SelectedIndex;
            if (index < 0 || index > listBox.Items.Count) return;
            Patient selectedPatient = (Patient)listBox.Items[index];
            patientform form = new patientform(selectedPatient);
            DialogResult result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                listBox.Items.RemoveAt(index);
                listBox.Items.Insert(index, form.Patient);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a patient to delete.", "No Selection",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get confirmation from user
            DialogResult result = MessageBox.Show($"Are you sure you want to delete patient: {listBox.SelectedItem}?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Remove the selected patient from the ListBox
                    listBox.Items.Remove(listBox.SelectedItem);


                    MessageBox.Show("Patient deleted successfully.", "Success",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting patient: {ex.Message}", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void savebtn_Click(object sender, EventArgs e)
        {

            try
            {
                
                List<Patient> patients = listBox.Items.Cast<Patient>().ToList();

                if (patients.Count == 0)
                {
                    MessageBox.Show("No patient data to save.", "Information",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var saveData = new
                {
                    Patients = patients,
                    LastSaved = DateTime.Now,
                    ApplicationVersion = "1.0"
                };

                // Configure save dialog
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "JSON Files (*.json)|*.json|All files (*.*)|*.*";
                    saveDialog.Title = "Save Patient Data";
                    saveDialog.DefaultExt = "json";
                    saveDialog.FileName = $"patients_{DateTime.Now:yyyyMMdd_HHmmss}.json";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Serialize to JSON with formatting
                        string json = JsonSerializer.Serialize(saveData, new JsonSerializerOptions
                        {
                            WriteIndented = true,
                            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                        });

                        
                        File.WriteAllText(saveDialog.FileName, json);

                       
                        CreateBackup(saveDialog.FileName, json);

                        MessageBox.Show($"Saved {patients.Count} patients successfully!", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving patient data: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateBackup(string originalPath, string jsonData)
        {
            try
            {
                string backupDir = Path.Combine(Path.GetDirectoryName(originalPath), "Backups");
                Directory.CreateDirectory(backupDir);

                string backupPath = Path.Combine(backupDir,
                    $"{Path.GetFileNameWithoutExtension(originalPath)}_backup_{DateTime.Now:HHmmss}.json");

                File.WriteAllText(backupPath, jsonData);
            }
            catch
            {
                
            }
        }

    

        private void loadbtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "JSON Files (*.json)|*.json|All files (*.*)|*.*";
                openDialog.Title = "Load Patient Data";
                openDialog.CheckFileExists = true;

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                       
                        Cursor.Current = Cursors.WaitCursor;

                        string json = File.ReadAllText(openDialog.FileName);
                        var loadedData = JsonSerializer.Deserialize<Dictionary<string, object>>(json);

                       
                        if (loadedData.TryGetValue("Patients", out object patientsObj) &&
                            patientsObj is JsonElement patientsElement)
                        {
                            var patients = JsonSerializer.Deserialize<List<Patient>>(patientsElement.GetRawText());

                           
                            this.Invoke((MethodInvoker)delegate {
                                listBox.DataSource = null;
                                listBox.DataSource = patients;
                                listBox.DisplayMember = "FullName";
                            });

                            MessageBox.Show($"Loaded {patients.Count} patients successfully!", "Success",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("File does not contain valid patient data.", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (JsonException)
                    {
                        MessageBox.Show("The file is corrupted or not valid patient data.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading patient data: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
        }
    }
}
