using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Bitmap variable is declared 
        Bitmap bitmapImage;
        //Arrays are declared in the color class 
        Color[,] ImageArray = new Color[320, 240];
        Color[,] RestoreArray = new Color[320, 240];
        //Integer variable is declared 
        int magcounter;
        //Values are assigned to dimension variables
        int iWidth = 320;
        int iHeight = 240;
        //Double variable is declared 
        double zoom;

        public void Magnification()
        {
            //The dimensions of the image is multiplied by the magnification value selected and convert to an int. 
            Bitmap BitmapZoom = new Bitmap(bitmapImage, Convert.ToInt32(picImage.Width * zoom), Convert.ToInt32(picImage.Height * zoom));
            Graphics g = Graphics.FromImage(BitmapZoom);
            SetBitmapFromArray();
            //Zooms into the centre of the image
            picImage.SizeMode = PictureBoxSizeMode.CenterImage;
            picImage.Image = BitmapZoom;
        }

        // Background Music 
        private void BackgroundMusic()
        {
            SoundPlayer TurkishMarchBackground = new SoundPlayer(Properties.Resources.Turkish_March_by_Wolfgang_Amadeus_Mozart_WAV_FILE);// Locates location of song 
            // Plays and loops located music 
            TurkishMarchBackground.PlayLooping();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundMusic();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                Stream myStream = null;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                //The filter of one of the options in the drop down list box is stated
                openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                //Dropdown list above cancel button contains 2 options 
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                //Title is given to the image browser
                openFileDialog1.Title = "Image Browser";

                try
                {
                    //If ok is clicked 
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if ((myStream = openFileDialog1.OpenFile()) != null)
                        {
                            Image newImage = Image.FromStream(myStream);
                            //The dimensions for bitmapImage is stated and the image upload is fitted into the restraints  
                            bitmapImage = new Bitmap(newImage, 320, 240);
                            picImage.Image = bitmapImage;
                            myStream.Close();
                        }
                    }
                }
                catch
                {
                    //Messagebox appears if the file opened is not acceptable (not a JPG, BMP, or GIF file) 
                    MessageBox.Show("The selected file that you request to open is not acceptable for the following program. Please choose a JPG, BMP, or GIF file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                SetArrayFromBitmap();
            }
            catch
            {
                //Empty catch if cancel or the exit button is selected 
            }
        }
        private void SetBitmapFromArray()
        {
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                {
                    bitmapImage.SetPixel(row, col, ImageArray[row, col]);
                }
        }

        private void SetArrayFromBitmap()
        {
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                {
                    ImageArray[row, col] = bitmapImage.GetPixel(row, col);
                    RestoreArray[row, col] = bitmapImage.GetPixel(row, col);
                }
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Variables are declared 
            Byte Red, Green, Blue;

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height  
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the colors
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    //Red, Green, and Blue values are subtracted from 255 
                    Color newColor = Color.FromArgb(255, 255 - Red, 255 - Green, 255 - Blue);
                    //The alterations are changes the prior array 
                    ImageArray[i, j] = newColor;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnLighten_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                //Messagebox appears 
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Varaibles are declared 
            int Red, Green, Blue;

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height 
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Shade of Red, Green, and Blue increase by 5
                    Red = col.R + 5;
                    Green = col.G + 5;
                    Blue = col.B + 5;

                    // If Red, Green, or Blue values becomes greater than 255, it remains constant at 255

                    if (Red > 255)
                        Red = 255;

                    if (Green > 255)
                        Green = 255;

                    if (Blue > 255)
                        Blue = 255;

                    //Creates a Color variable from the four ARGB component values
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    //Changes are made to the array
                    ImageArray[i, j] = newColor;
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnDarken_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Red, Green, Blue;

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height 
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Shade of Red, Green, and Blue decrease by 5
                    Red = col.R - 5;
                    Green = col.G - 5;
                    Blue = col.B - 5;

                    // If Red, Green, or Blue values becomes less than 0, it remains constant at 0

                    if (Red < 0)
                        Red = 0;

                    if (Green < 0)
                        Green = 0;

                    if (Blue < 0)
                        Blue = 0;

                    //Creates a Color variable from the four ARGB component values
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    //Changes are made to the prior image
                    ImageArray[i, j] = newColor;
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnSunset_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Variables are declared 
            int Red, Green, Blue;

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height 
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Red = col.R + 40;
                    Green = col.G;
                    Blue = col.B - 25;

                    //If the red value surpasses the maximum value of 255 then the red value remains constant at 255
                    if (Red > 255)
                        Red = 255;

                    //If the blue value becomes less than 0 then the blue value remains constant at 0
                    if (Blue < 0)
                        Blue = 0;


                    //Creates a Color variable from the four ARGB component values
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    //Changes to the colors of the original image is displayed
                    ImageArray[i, j] = newColor;
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        //Red filter 
        private void btnRed_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Byte variable is declared
            byte Red;

            // The sample code extracts the red channel of a pixel and assign the color only to red channel

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height 
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Red = col.R;

                    //Creates a Color variable from the four ARGB component values
                    //no values of blue or green are initiated
                    //only values of red
                    Color newColor = Color.FromArgb(255, Red, 0, 0);
                    //The filter covers the original image
                    ImageArray[i, j] = newColor;
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        //Orange filter 
        private void btnOrange_Click(object sender, EventArgs e)
        {

            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                //Messagebox is displayed
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Integer variables are declared
            int Red, Green;

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height  
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Red = col.R + 165;
                    Green = col.G - 43;

                    //If value of red surpasses 255, it remains constant at 255
                    if (Red > 255)
                        Red = 255;

                    //If value of green becomes lower than 0, then the value becomes constant at 0
                    if (Green < 0)
                        Green = 0;


                    //Creates a Color variable from the four ARGB component values
                    //Only shades of red and green are toggled
                    Color newColor = Color.FromArgb(255, Red, Green, 0);
                    //The filter covers the original image
                    ImageArray[i, j] = newColor;
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        //Yellow filter 
        private void btnYellow_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Byte variables are declared
            Byte Red, Green;

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height  
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Red = col.R;
                    Green = col.G;

                    //Creates a Color variable from the four ARGB component values
                    Color newColor = Color.FromArgb(255, Red, Green, 0);
                    //The filter covers the original image
                    ImageArray[i, j] = newColor;
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        //Green Filter
        private void btnGreen_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                //Messagebox is displayed
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //byte variable is declared
            Byte Green;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height  
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Green = col.G;

                    //Creates a Color variable from the four ARGB component values
                    Color newColor = Color.FromArgb(255, 0, Green, 0);
                    //The filter covers the original image
                    ImageArray[i, j] = newColor;
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        //Blue Filter
        private void btnBlue_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                //Messagebox is displayed
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Byte variable is declareed
            Byte Blue;

            // The sample code extracts the blue channel of a pixel and assign the color only to blue channel

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height  
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Blue = col.B;

                    //Creates a Color variable from the four ARGB component values
                    Color newColor = Color.FromArgb(255, 0, 0, Blue);
                    //The filter covers the original image
                    ImageArray[i, j] = newColor;
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        //Indigo Filter
        private void btnIndigo_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Int variables are declared 
            int Red, Green, Blue;

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height  
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Red = col.R + 128;
                    Green = col.G;
                    Blue = col.B + 128;

                    //If values of Red, Green, or Blue surpasses 255, it remains constant at 255
                    if (Red > 255)
                        Red = 255;

                    if (Green > 255)
                        Green = 255;

                    if (Blue > 255)
                        Blue = 255;

                    //Creates a Color variable from the four ARGB component values
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    //The filter covers the original image
                    ImageArray[i, j] = newColor;
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        //Violet Filter
        private void btnViolet_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                //Messagebox is displayed
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Integer variables are invoked 
            int Red, Green, Blue;

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height  
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Red = col.R + 160;
                    Green = col.G;
                    Blue = col.B;

                    //If teh red value surpasses 255 it remains at 255 
                    if (Red > 255)
                        Red = 255;

                    //Creates a Color variable from the four ARGB component values
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    //The filter covers the original image
                    ImageArray[i, j] = newColor;
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Int variables are declared 
            int Red, Green, Blue, ColorAverage;

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height  
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    //ColorAverage is the average of all values of red, green, and blue 
                    ColorAverage = (Red + Green + Blue) / 3;

                    //All ARGB components are the average of red, green, and blue valuesc 
                    Color newColor = Color.FromArgb(255, ColorAverage, ColorAverage, ColorAverage);
                    //Changes are made to the array and displayed to the user 
                    ImageArray[i, j] = newColor;
                }
            }
            SetBitmapFromArray();

            picImage.Image = bitmapImage;
        }

        private void btnVerticalFlip_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is less than half the height  
                for (int j = 0; j < iHeight / 2; j++)
                {
                    //Color variable is declared 
                    Color TempPixel;

                    //All pixels are vertically switched 
                    //Bottom pixel is switched with top pixel 
                    TempPixel = ImageArray[i, iHeight - 1 - j];
                    ImageArray[i, iHeight - 1 - j] = ImageArray[i, j];
                    //Changes are made to the array 
                    ImageArray[i, j] = TempPixel;
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btn180Degrees_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // i loops through each row by an increment of 1 until i is greater than or equal to the width
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is less than half the height  
                for (int j = 0; j < iHeight / 2; j++)
                {
                    //Color variable is declared 
                    Color TempPixel;

                    //All pixels are vertically switched 
                    //Bottom pixel is switched with top pixel 
                    TempPixel = ImageArray[i, iHeight - 1 - j];
                    ImageArray[i, iHeight - 1 - j] = ImageArray[i, j];
                    //Changes are made to the array
                    ImageArray[i, j] = TempPixel;
                }
            }

            // i loops through each row by an increment of 1 until i is less than half the width 
            for (int i = 0; i < iWidth / 2; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height  
                for (int j = 0; j < iHeight; j++)
                {
                    //Color variable is declared 
                    Color TempPixel;

                    //All pixels are horizontally switched 
                    //Left pixel is switched with right pixel 
                    TempPixel = ImageArray[iWidth - 1 - i, j];
                    ImageArray[iWidth - 1 - i, j] = ImageArray[i, j];
                    //Changes are made to the array
                    ImageArray[i, j] = TempPixel;

                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnHorizontalFlip_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // i loops through each row by an increment of 1 until i is less than half the width 
            for (int i = 0; i < iWidth / 2; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height  
                for (int j = 0; j < iHeight; j++)
                {
                    //Color variable is declared 
                    Color TempPixel;

                    //All pixels are horizontally switched 
                    //Left pixel is switched with right pixel 
                    TempPixel = ImageArray[iWidth - 1 - i, j];
                    ImageArray[iWidth - 1 - i, j] = ImageArray[i, j];
                    //Changes are made to the array
                    ImageArray[i, j] = TempPixel;
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exits the program 
            Application.Exit();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // i loops through each row by an increment of 1 until i is less than half the width 
            for (int i = 0; i < iWidth / 2; i++)
            {
                // j loops through each column by an increment of 1 until j is less than half the height  
                for (int j = 0; j < iHeight / 2; j++)
                {
                    //Color variable is declared 
                    Color TempPixel;

                    //The top left quarter of the image is switch with the bottom right quarter of the image 
                    TempPixel = ImageArray[i, j];
                    ImageArray[i, j] = ImageArray[(iWidth / 2) - 1 + i, (iHeight / 2) - 1 + j];
                    ImageArray[(iWidth / 2) - 1 + i, (iHeight / 2) - 1 + j] = TempPixel;
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height  
                for (int j = 0; j < iHeight; j++)
                {
                    //The altered imagearray is replaced by the original array
                    ImageArray[i, j] = RestoreArray[i, j];
                }
            }

            //Resets the magnification combobox to a blank value; 
            CBMagnification.SelectedIndex = -1;
            //Resets the pixellate combobox to a blank value; 
            CBPixellate.SelectedIndex = -1;
            //Clears the Steganography textbox 
            RTBSteganography.Clear();

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnPolarize_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Int variables are declared 
            int Red, Green, Blue;

            //Double variable is declared 
            double ColorAverage;

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height  
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Red is equal to the red values of the array 
                    Red = ImageArray[i, j].R;
                    //Green is equal to the green values of the array 
                    Green = ImageArray[i, j].G;
                    //Blue is equal to the blue values of the array
                    Blue = ImageArray[i, j].B;

                    //The average of all main color values are averaged and converted to a double 
                    ColorAverage = Convert.ToDouble((Red + Blue + Green) / 3);

                    //If the color average is less than or equal to 127.5
                    if (ColorAverage <= (255 / 2))
                    {
                        //Then all values become 0
                        //Then all the colors that fit into this category becomes black
                        Red = 0;
                        Green = 0;
                        Blue = 0;
                    }

                    //If the color average is greater than 127.5
                    else
                    {
                        //Then all values become 0
                        //Then all the colors that fit into this category becomes white 
                        Red = 255;
                        Green = 255;
                        Blue = 255;
                    }

                    //Creates a Color variable from the four ARGB component values
                    Color PolarizedImage = Color.FromArgb(255, Red, Green, Blue);
                    //Changes are made to the array 
                    ImageArray[i, j] = PolarizedImage;
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnBlur_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Color variables are declared 
            Color Color1, Color2, Color3, Color4, Color5, Color6, Color7, Color8;

            //Int variables are declared 
            int AverageRed, AverageGreen, AverageBlue;

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 1; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height  
                for (int j = 1; j < iHeight; j++)
                {
                    if (i < 319 && j < 239)
                    {
                        //Surrounding pixels are selected 
                        Color1 = ImageArray[i - 1, j];
                        Color2 = ImageArray[i, j + 1];
                        Color3 = ImageArray[i + 1, j + 1];
                        Color4 = ImageArray[i - 1, j];
                        Color5 = ImageArray[i + 1, j];
                        Color6 = ImageArray[i - 1, j - 1];
                        Color7 = ImageArray[i, j - 1];
                        Color8 = ImageArray[i + 1, j + 1];

                        //The red values of the surrounding pixels are averaged
                        AverageRed = (Color1.R + Color2.R + Color3.R + Color4.R + Color5.R + Color6.R + Color7.R + Color8.R) / 8;
                        //The blue values of the surrounding pixels are averaged 
                        AverageBlue = (Color1.B + Color2.B + Color3.B + Color4.B + Color5.B + Color6.B + Color7.B + Color8.B) / 8;
                        //The green values of the surrounding pixels are averaged 
                        AverageGreen = (Color1.G + Color2.G + Color3.G + Color4.G + Color5.G + Color6.G + Color7.G + Color8.G) / 8;

                        //The averages of the red, green, and blue values form the ARGB components 
                        Color Blur = Color.FromArgb(255, AverageRed, AverageGreen, AverageBlue);
                        //Changes are made to the array 
                        ImageArray[i, j] = Blur;
                    }
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnPixellate_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //If there is no selection 
            if (CBPixellate.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a pixellation size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CBPixellate.SelectedIndex = -1;
            }

            //If the selected size is 4x4
            if (CBPixellate.SelectedIndex == 0)
            {
                // i loops through each row by an increment of 4 until i is less than the width 
                for (int i = 0; i < iWidth; i = i + 4)
                {
                    // j loops through each column by an increment of 1 until j is greater than or equal to the height  
                    for (int j = 0; j < iHeight; j = j + 4)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            for (int l = 0; l < 4; l++)
                            {
                                ImageArray[i + k, j + l] = ImageArray[i, j];
                            }
                        }
                    }
                }
            }

            //If the selected size if 8x8 
            else if (CBPixellate.SelectedIndex == 1)
            {
                // i loops through each row by an increment of 8 until i is less than the width 
                for (int i = 0; i < iWidth; i = i + 8)
                {
                    // j loops through each column by an increment of 1 until j is greater than or equal to the height  
                    for (int j = 0; j < iHeight; j = j + 8)
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            for (int l = 0; l < 8; l++)
                            {
                                ImageArray[i + k, j + l] = ImageArray[i, j];
                            }
                        }
                    }
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //For every selection in the combobox CBMagnification a value is given 
            if (CBMagnification.SelectedIndex == 0)
                magcounter = 1;
            else if (CBMagnification.SelectedIndex == 1)
                magcounter = 2;
            else if (CBMagnification.SelectedIndex == 2)
                magcounter = 3;
            else if (CBMagnification.SelectedIndex == 3)
                magcounter = 4;
            else if (CBMagnification.SelectedIndex == 4)
                magcounter = 5;
            else if (CBMagnification.SelectedIndex == 5)
                magcounter = 6;
            else if (CBMagnification.SelectedIndex == 6)
                magcounter = 7;
            else if (CBMagnification.SelectedIndex == 7)
                magcounter = 8;
            else if (CBMagnification.SelectedIndex == 8)
                magcounter = 9;
            //If an empty value is selected 
            else if (CBMagnification.SelectedIndex == -1)
                magcounter = 10;

            //Switch case for magcounter 
            switch (magcounter)
            {
                //For each designated value below a method is called 
                //Each case has a particular number that varies how the amount of zoom 
                case 1:
                    zoom = 1;
                    Magnification();
                    break;
                case 2:
                    zoom = 1.5;
                    Magnification();
                    break;
                case 3:
                    zoom = 2;
                    Magnification();
                    break;
                case 4:
                    zoom = 2.5;
                    Magnification();
                    break;
                case 5:
                    zoom = 3;
                    Magnification();
                    break;
                case 6:
                    zoom = 3.5;
                    Magnification();
                    break;
                case 7:
                    zoom = 4;
                    Magnification();
                    break;
                case 8:
                    zoom = 4.5;
                    Magnification();
                    break;
                case 9:
                    zoom = 5;
                    Magnification();
                    break;
                //If an empty value or no size is selected 
                case 10:
                    MessageBox.Show("Please select a magnification size to zoom.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CBMagnification.SelectedIndex = -1;
                    break;
            }
        }

        private void btnRecursion_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                //Messagebox is displayed
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height 
                for (int j = 0; j < iHeight; j++)
                {
                    ImageArray[i / 2, j / 2] = ImageArray[i, j];
                    ImageArray[i / 2 + 160, j / 2] = ImageArray[i, j];
                    ImageArray[i / 2, j / 2 + 120] = ImageArray[i, j];
                    ImageArray[i / 2 + 160, j / 2 + 120] = ImageArray[i, j];
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void VSBScoll_Scroll(object sender, ScrollEventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //A 2D temporary array is created 
            Color[,] tempImage = new Color[320, 240];

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height
                for (int j = 0; j < iHeight; j++)
                {
                    if (j < (iHeight - 40))
                    {
                        // scrolls the pixels vertically by a value of 40.
                        tempImage[i, j + 40] = ImageArray[i, j];
                    }
                    else
                    {
                        //40 pixels that were shifted are regenerated at the top of the image 
                        tempImage[i, j + 40 - 240] = ImageArray[i, j];
                    }
                }
            }

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height
                for (int j = 0; j < iHeight; j++)
                {
                    ImageArray[i, j] = tempImage[i, j];
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // i loops through each row by an increment of 1 until i is greater than or equal to the width 
            for (int i = 0; i < iWidth; i++)
            {
                // j loops through each column by an increment of 1 until j is greater than or equal to the height 
                for (int j = 0; j < iHeight; j++)
                {
                    Color Sort = ImageArray[i, j];
                    int k = j - 1;

                    while (k >= 0)
                    {
                        //Image is sorted in respect to red values 
                        //If the previous j value is greater than the j value after it 
                        if (ImageArray[i, k].R > Sort.R)
                        {
                            ImageArray[i, k + 1] = ImageArray[i, k];
                        }

                        else
                            break;

                        k--;
                    }
                    //Array is changed 
                    ImageArray[i, k + 1] = Sort;
                }
            }
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Message box appears when there is no image in the picture box called picImage
            if (bitmapImage == null)
            {
                //Messagebox is displayed
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Message var is set blank 
            string strMessage = "";

            //The pixel on the top left corner is red 
            int MessageLength = ImageArray[0, 0].R;
            //Byte var is declared 
            byte ascii;
            //Int var is declared 
            int r, c;

            //Values are assigned 
            r = 0;
            c = 10;

            // i starts at zero, increases by one at every loop, until i is greater than or equal to the length of the message 
            for (int i = 0; i < MessageLength; i++)
            {

                ascii = ImageArray[r, c].R;

                //strMessage equals to the message plus the ascii that is converted to a character 
                strMessage = strMessage + Convert.ToChar(ascii);
                c = c + 10;
                if (c > 239)
                {
                    //row is shifted 
                    r++;
                    c = 10;
                }
            }

            //Message is displayed in the messagebox 
            RTBSteganography.Text = strMessage;

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string strmessage;
            strmessage = RTBSteganography.Text;

            //If RTBSteganography is empty
            if (strmessage == "")
            {
                //Messagebox is displayed 
                MessageBox.Show("There is no message to be inputed. Please input a message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //If the the length of the input is greater than 255 
            else if (strmessage.Length > 255)
            {
                //Messagebox is displayed
                MessageBox.Show("The message entered surpasses the maximum capacity of characters. Please revise your input so the number of characters in your message is less than or equal to 255.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Richtextbox is cleared 
                RTBSteganography.Clear();
                RTBSteganography.Focus();
                return;
            }

            // Message box appears when there is no image in the picture box called picImage
            else if (bitmapImage == null)
            {
                //Messagebox is displayed
                MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RTBSteganography.Clear();
                RTBSteganography.Focus();
                return;
            }

            //byte var is declared 
            byte red, green, blue;
            //int var is declared 
            int length;

            length = strmessage.Length;

            //Colors are declared at specific areas of the array 
            red = ImageArray[0, 0].R;
            green = ImageArray[0, 0].G;
            blue = ImageArray[0, 0].B;

            Color newClr = Color.FromArgb(255, length, green, blue);
            ImageArray[0, 0] = newClr;

            char ch;
            byte ascii;
            int r, c;

            //Values are assigned 
            r = 0;
            c = 10;

            for (int i = 0; i < length; i++)
            {
                ch = strmessage[i];
                ascii = (byte)(ch);

                green = ImageArray[r, c].G;
                blue = ImageArray[r, c].B;

                newClr = Color.FromArgb(255, ascii, green, blue);
                ImageArray[r, c] = newClr;

                c = c + 10;
                //if c is greater than 239 
                if (c > 239)
                {
                    //row is shifted 
                    r++;
                    c = 10;
                }
            }

            //Changes are displayed in the array 
            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            //Rich textbox is cleared 
            RTBSteganography.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Message box appears when there is no image in the picture box called picImage
                if (bitmapImage == null)
                {
                    //Messagebox is displayed
                    MessageBox.Show("There is no target image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Bitmap File| *.bmp";
                saveFileDialog1.FilterIndex = 2;
                //Save Dialog is given a title 
                saveFileDialog1.Title = "Save";

                try
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //If the name file is not empty 
                        if (saveFileDialog1.FileName != "")
                        {
                            Stream myStream = null;
                            bitmapImage.Save(saveFileDialog1.FileName);
                            myStream.Close();

                        }
                        //If the user tries to save with an empty name 
                        else
                        {
                            MessageBox.Show("Please include a file name to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch
                {
                }
            }
            catch
            {
            }
        }
    }
}

