namespace ironocrTest
{
    using IronOcr;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;

    public partial class Form1 : Form
    {
        //Image ingImg;

        public static Image resizeImg(Image imgToSize, Size size)
        {
            return (Image)(new Bitmap(imgToSize, size));
        }

        /*public static Image PreProcessing(Image imgToProcess)
        {
            IronTesseract IronOcr = new IronTesseract();
            using (var PreImage = new OcrInput(imgToProcess))
            {
                PreImage.DeNoise();
                PreImage.Deskew();
                PreImage.Contrast();
                PreImage.Binarize();

                var OcrOutput = IronOcr.Read(PreImage);
                
            }

        }*/

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {         
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbPic.Image = resizeImg(new Bitmap(open.FileName), new Size(800, 500));
                Image ingImg = new Bitmap(open.FileName);
                /*IronTesseract IronOcr = new IronTesseract();
                using (var image2Pro = new OcrInput(ingImg))
                {
                    image2Pro.Rotate(90);
                    image2Pro.DeNoise();
                    //image2Pro.Deskew();
                    image2Pro.Contrast();
                    image2Pro.Binarize();

                }*/
                //pbPic.Image = ResizeImage(ingImg, 800, 500);
                tbPath.Text = open.FileName;
            }

        }

        private void btnOcr_Click(object sender, EventArgs e)
        {
            IronTesseract IronOcr = new IronTesseract();
            var OCR = IronOcr.Read(tbPath.Text);
            rtocrOut.Text = IronOcr.Read(tbPath.Text);
        }
    }

}