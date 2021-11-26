using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Gallery_App_Windows_Form
{
    public partial class Form1 : Form
    {
        // this project was created for educational purposes only
        // no rights were claimed or violated by the use of the external files in this project

        int pictureNumber = 1; 

        public Form1()
        {
            InitializeComponent();

            ChangePictures(pictureNumber);
        }

        private void GoBack(object sender, EventArgs e)
        {

            pictureNumber -= 1;

            if (pictureNumber < 1)
            {
                pictureNumber = 5;
            }

            ChangePictures(pictureNumber);


        }

        private void GoNext(object sender, EventArgs e)
        {
            pictureNumber += 1;

            if (pictureNumber > 5)
            {
                pictureNumber = 1;
            }

            ChangePictures(pictureNumber);
        }

        private void ChangePictures(int picNum)
        {
            switch(picNum)
            {

                case 1:
                    pictureViewer.Image = Properties.Resources._01;
                    lblInfo.Text = "This is the first image, picture of a very nice lake with the hills around it.";
                    break;
                case 2:
                    pictureViewer.Image = Properties.Resources._02;
                    lblInfo.Text = "This is the second image, picture of a cottage in the lake with lots of mountains around it";
                    break;
                case 3:
                    pictureViewer.Image = Properties.Resources._03;
                    lblInfo.Text = "This is the third image, looks like a nice green field, mountains and the lake";
                    break;
                case 4:
                    pictureViewer.Image = Properties.Resources._04;
                    lblInfo.Text = "This is the fourth image, a beautiful sunset on the horizon";
                    break;
                case 5:
                    pictureViewer.Image = Properties.Resources._05;
                    lblInfo.Text = "This is the fifth image, it has the nice red sunset and it reflects on the water, the clouds and the mountains";
                    break;
            }


        }
    }
}
