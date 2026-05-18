using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace showmembers
{
    public partial class NewMenuItem : UserControl
    {
        string relativePath = string.Empty;
        public NewMenuItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(selectedFilePath);

                string projectDirectory = Application.StartupPath;
                string resourcesFolder = Path.Combine(projectDirectory, "Resources");


                if (!Directory.Exists(resourcesFolder))
                {
                    Directory.CreateDirectory(resourcesFolder);
                }

                string destinationPath = Path.Combine(resourcesFolder, fileName);

                if (!File.Exists(destinationPath))
                {
                    File.Copy(selectedFilePath, destinationPath);
                }

                pictureBox1.Image = new Bitmap(destinationPath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                relativePath = Path.Combine("Resources", fileName);

            }
        }
        private void SavePathToDatabase(string relativePath)
        {
            string name = textBox1.Text.Trim();
            decimal price = 0;
            decimal.TryParse(textBox2.Text.Trim(), out price);
            string availability = "0";
            string category = "unnasigned";

            if (radioButton1.Checked == true)
            {
                availability = "1";
            }
            else if (radioButton2.Checked == true)
            {
                availability = "0";
            }

            if (comboBox1.SelectedItem != null)
            {
                category = comboBox1.SelectedItem.ToString();
            }

            string connectionString = "Data Source=localhost;Initial Catalog=SedapMakanDatabase;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = "INSERT INTO MenuItems (Name, Price, ImagePath, Availability, Category)\r\nVALUES (@Name, @Price, @ImagePath, @Availability, @Category)\r\n";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ImagePath", relativePath);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Availability", availability);
                    cmd.Parameters.AddWithValue("@Category", category);
                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New Item Saved.");
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }


                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePathToDatabase(relativePath); 
        }
    }
}
