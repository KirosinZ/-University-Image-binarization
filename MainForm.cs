using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KG1
{

    public partial class MainForm : Form
    {
        #region Probably confidential
        static string Dir = "C:\\Users\\Kiril\\source\\repos\\KG1\\imgs\\";
        #endregion

        static string Filter = "*.bmp;*.jpg;*.jpeg;*.png";

        const int MinHeight = 300;
        const int MaxHeight = 500;

        Bitmap _image;

        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            OpenFileDialog.InitialDirectory = Dir;
            OpenFileDialog.Filter = $"Файлы изображений ({Filter})|{Filter}";
            Size = new Size(Size.Width, 110);

            OpenFileMenuStrip.Click += (ob, ev) => LoadImage();
            DepthBox.ValueChanged += (ob, ev) => DrawImitation();
        }

        public void LoadImage()
        {
            if (OpenFileDialog.ShowDialog(this) != DialogResult.OK) return;

            _image = new Bitmap(OpenFileDialog.FileName);
            _image = ManageBitmapSize(_image);
            _image = _image.ToGrayscale();

            Size = new Size(50 + _image.Width, 120 + 2 * _image.Height);
            OriginalPicBox.Size = _image.Size;
            ImitatedPicBox.Location = new Point(ImitatedPicBox.Location.X, 70 + _image.Height);
            ImitatedPicBox.Size = _image.Size;

            OriginalPicBox.Image = _image;

            DrawImitation();
        }

        public void DrawImitation()
        {
            Bitmap imit = new Bitmap(_image);
            BitmapWrapper wimit = new BitmapWrapper(imit);
            imit = BitmapBinarizer.Binarize(wimit, (int)DepthBox.Value);
            ImitatedPicBox.Image = imit;
        }

        public static Bitmap ManageBitmapSize(Bitmap bm, int minheight = MinHeight, int maxheight = MaxHeight)
        {
            float res = (float)bm.Width / bm.Height;
            if (bm.Height < minheight) return bm.Resize((int)(res * minheight), minheight);
            if (bm.Height > maxheight) return bm.Resize((int)(res * maxheight), maxheight);
            return bm;
        }
    }
}
