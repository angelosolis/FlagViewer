using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Flag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CountryNameLabel.Visible = false;
            FlagViewerLabel.Visible = false;
            ProgrammerLabel.Visible = false;
        }

        private void PhilippinesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PhilippinesRadioButton.Checked)
            {
                // Load the image from file
                Image image = Image.FromFile("D:/Philippines.jpg");

                // Set the PictureBox's Image property to the loaded image
                countryPicture.Image = image;
                CountryNameLabel.Text = "Philippines";
            }
        }

        private void USARadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (USARadioButton.Checked)
            {
                // Load the image from file
                Image image = Image.FromFile("D:/USA.png");

                // Set the PictureBox's Image property to the loaded image
                countryPicture.Image = image;
                CountryNameLabel.Text = "USA";
            }
        }

        private void ColumbiaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ColumbiaRadioButton.Checked)
            {
                // Load the image from file
                Image image = Image.FromFile("D:/Columbia.png");

                // Set the PictureBox's Image property to the loaded image
                countryPicture.Image = image;
                CountryNameLabel.Text = "Columbia";
                
            }
        }

        private void FranceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FranceRadioButton.Checked)
            {
                // Load the image from file
                Image image = Image.FromFile("D:/France.jpg");

                // Set the PictureBox's Image property to the loaded image
                countryPicture.Image = image;
                CountryNameLabel.Text = "France";
            }
        }

        private void TitleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TitleCheckBox.Checked)
                FlagViewerLabel.Visible = true;
            else
                FlagViewerLabel.Visible = false;
        }

        private void CountryNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CountryNameCheckBox.Checked)
                CountryNameLabel.Visible = true;
            else
                CountryNameLabel.Visible = false;
        }

        private void ProgrammerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ProgrammerCheckBox.Checked)
            {
                ProgrammerLabel.Text = "Prog Rammer";
                ProgrammerLabel.Visible = true;
            }
            else
                ProgrammerLabel.Visible = false;
        }

    }
}
