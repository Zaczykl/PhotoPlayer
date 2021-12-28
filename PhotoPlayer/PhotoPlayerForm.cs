using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;


namespace PhotoPlayer
{
    public partial class PhotoPlayerForm : Form
    {
        private string _picturePath;
        private string _savePath = Path.Combine(Environment.CurrentDirectory, "save.txt");
        private Size defaultWindowSize = new Size(221, 84);
        public PhotoPlayerForm()
        {
            InitializeComponent();
            LoadSettings();
            TryToLoadPicture();
        }
        private void LoadSettings()
        {
            Size = defaultWindowSize;
            openFileDialog1.FileName = "Please select an image file";
            openFileDialog1.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
            openFileDialog1.Title = "Open an image file";
        }
        private void TryToLoadPicture()
        {
            if (File.Exists(_savePath))
            {
                _picturePath = File.ReadAllText(_savePath);
                if (_picturePath.Length!=0)
                    LoadPictureFromFile();
            }
        }
        private void LoadPictureFromFile()
        {
            try
            {
                pictureBox1.Image = Image.FromFile(_picturePath);
                Size = pictureBox1.Image.Size;
                buttonLoadPicture.Visible = false;
                buttonRemovePhoto.Visible = true;

            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Niepoprawny typ pliku");
            }
        }
        private void RemovePhoto()
        {
            pictureBox1.Image = null;
            buttonRemovePhoto.Visible = false;
            buttonLoadPicture.Visible = true;
            Size = defaultWindowSize;
        }


        //jeśli użytkownik wybierze plik to:
        //przypisz wybraną przez użytkownika ścieżkę do zmiennej_picturePath
        //wywołaj metodę LoadPictureFromFile
        private void buttonLoadPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _picturePath = openFileDialog1.FileName;
                LoadPictureFromFile();
            }
        }

        private void buttonRemovePhoto_Click(object sender, EventArgs e)
        {
            RemovePhoto();
        }

        private void PhotoPlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePathToFile();
        }
        private void SavePathToFile()
        {
            if (pictureBox1.Image != null)
                File.WriteAllText(_savePath, _picturePath);
            else
                File.WriteAllText(_savePath, "");
        }

    }
}
