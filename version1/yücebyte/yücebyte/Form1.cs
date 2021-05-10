using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace yücebyte
{
    public partial class Form1 : Form
    {
        private string txtFilePthOrig = "";
        private int kalite=0;
        public Form1()
        {
            InitializeComponent();
            this.trckBroKalite.Scroll += new System.EventHandler(this.trckBroKalite_Scroll);
            trckBroKalite.TickFrequency = 1;
            trckBroKalite.LargeChange = 1;
            trckBroKalite.SmallChange = 1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CompressImage(Image sourceImage, int imageQuality, string savePath)
        {
            try
            {
                //Create an ImageCodecInfo-object for the codec information
                ImageCodecInfo jpegCodec = null;

                //Set quality factor for compression
                EncoderParameter imageQualitysParameter = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, imageQuality);

                //List all avaible codecs (system wide)
                ImageCodecInfo[] allCodecs = ImageCodecInfo.GetImageEncoders();

                EncoderParameters codecParameter = new EncoderParameters(1);
                codecParameter.Param[0] = imageQualitysParameter;

                //Find and choose JPEG codec
                for (int i = 0; i < allCodecs.Length; i++)
                {
                    if (allCodecs[i].MimeType == "image/jpeg")
                    {
                        jpegCodec = allCodecs[i];
                        break;
                    }
                }
                
                sourceImage.Save(savePath, jpegCodec, codecParameter);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void btnBrowser_click(object sender, EventArgs e)
        {
            lblIndirildi.ForeColor = Color.DarkGray;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Jpeg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Png Images(*.png)|*.png";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";
            ofd.Filter += "|All(*.JPG, *.PNG, *.bmp)| *.JPG; *.PNG; *.bmp";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFilePthOrig= ofd.FileName;
                Image img = Image.FromFile(txtFilePthOrig);
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            kalite = Convert.ToInt32(lblkaliteGoster.Text);
            if (txtFilePthOrig == "")
            {
                btnBrowser_click(sender,e);
            }
            else if (txtFilePthOrig.Contains(".jpg"))
            {
                CompressImage(Image.FromFile(txtFilePthOrig), kalite, txtFilePthOrig.Insert(txtFilePthOrig.Length - 4, " JPEG Compressed Image"));
                lblIndirildi.ForeColor = Color.Red;
            }
            else
            {
                string x = txtFilePthOrig.Insert(txtFilePthOrig.Length - 4, " JPEG Compressed Image");
                string y = "abcdefg";
                CompressImage(Image.FromFile(txtFilePthOrig), kalite, txtFilePthOrig.Insert(txtFilePthOrig.Length - 4, " JPEG Compressed Image").Substring(0, x.Length - 4) + ".jpg");
                lblIndirildi.ForeColor = Color.Red;
            }
        }

        private void trckBroKalite_Scroll(object sender, EventArgs e)
        {
            lblkaliteGoster.Text = "" + trckBroKalite.Value;
        }
    }
}
