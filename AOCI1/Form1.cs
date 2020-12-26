using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOCI1
{
    public partial class Form1 : Form
    {
        ImageEditor imgEditor = new ImageEditor();
        Image<Bgr, byte> image, defaultImage;
        PointF[] srcPoints = new PointF[4];
        List<PointF> points = new List<PointF>();
        int mouseX, mouseY;
        public Form1()
        {
            InitializeComponent();
            //button1.Click += new EventHandler(button1_Click);
            imageBox1.MouseClick += new MouseEventHandler(imageBox2_MouseClick);

        }

        private void imageBox2_MouseClick(object sender, MouseEventArgs e)
        {
            mouseX = (int)(e.Location.X / imageBox1.ZoomScale / ((double)imageBox1.Width / (double)defaultImage.Width));
            mouseY = (int)(e.Location.Y / imageBox1.ZoomScale / ((double)imageBox1.Width / (double)defaultImage.Width));

            points.Add(new PointF(mouseX, mouseY));
            if(points.Count > 4)
            {
                points.RemoveAt(0);
            }
            if(points.Count == 4)
            {
                srcPoints = points.ToArray();
            }

            Point center = new Point(mouseX, mouseY);
            int radius = 2;
            int thickness = 2;
            var color = new Bgr(Color.Red).MCvScalar;
            // функция, рисующая на изображении круг с заданными параметрами
            CvInvoke.Circle(defaultImage, center, radius, color, thickness);
            imgEditor.ShowImage(imageBox1, defaultImage);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            defaultImage = imgEditor.SetSourceImage(OpenImageFile());
            imgEditor.ShowImage(imageBox1, defaultImage);
        }

        private string OpenImageFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png *.PNG) | *.jpg; *.jpeg; *.jpe; *.jfif *.png *.PNG";
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                return fileName;
            }
            return null;
        }

        

        
      

        private void buttonScale_Click(object sender, EventArgs e)
        {
            image = imgEditor.ReturnScaled(defaultImage, Double.Parse(textBoxX.Text, CultureInfo.InvariantCulture), Double.Parse(textBoxY.Text, CultureInfo.InvariantCulture));
            FillImage2(false);
        }

        private void buttonShift_Click(object sender, EventArgs e)
        {
            image = imgEditor.ReturnShifted(defaultImage, Double.Parse(textBoxShiftX.Text, CultureInfo.InvariantCulture), Double.Parse(textBoxShiftY.Text, CultureInfo.InvariantCulture));
            FillImage2();
        }

        private void buttonReflection_Click(object sender, EventArgs e)
        {
            image = imgEditor.ReturnReflected(defaultImage, Convert.ToInt32(textBoxQx.Text), Convert.ToInt32(textBoxQy.Text));
            FillImage2();
        }

        private void buttonHomo_Click(object sender, EventArgs e)
        {
        
            image = imgEditor.ReturnHomo(defaultImage, srcPoints);
            FillImage2();
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            image = imgEditor.ReturnRotated(defaultImage, Double.Parse(textBoxAngle.Text, CultureInfo.InvariantCulture), mouseX, mouseY);
            FillImage2();
        }

        private void FillImage2(bool mode = true)
        {
            
            imgEditor.ShowImage(imageBox2, image, mode);
        }

        
    }
}
