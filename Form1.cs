using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace FillBitmap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(ofd.FileName);
                pictureBoxFilled.Image = bmp;
                pictureBoxInput.Image = (Bitmap)bmp.Clone();
                List<Color> lst = new List<Color>();
                Color c;
                for (int x = 2; x < bmp.Width; x++)
                {
                    c = bmp.GetPixel(x, 2);
                    if(!lst.Contains(c))
                        lst.Add(c);
                    c = bmp.GetPixel(x, bmp.Height - 3);
                    if (!lst.Contains(c))
                        lst.Add(c);
                }
                for (int y = 0; y < bmp.Height; y++)
                {
                    c = bmp.GetPixel(2, y);
                    if(!lst.Contains(c))
                        lst.Add(c);
                    c = bmp.GetPixel(31, y);
                    if (!lst.Contains(c))
                        lst.Add(c);
                    c = bmp.GetPixel(90, y);
                    if (!lst.Contains(c))
                        lst.Add(c);
                    c = bmp.GetPixel(bmp.Width - 3, y);
                    if (!lst.Contains(c))
                        lst.Add(c);
                }
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        c = bmp.GetPixel(x, y);
                        if (lst.Contains(c))
                        {
                            if (c != Color.White)
                                FloodFill(bmp, x, y, Color.White);
                        }
                    }
                }

                Ocr ocr = new Ocr();

                //Input
                tessnet2.Tesseract tessocr = new tessnet2.Tesseract();
                tessocr.SetVariable("tessedit_char_whitelist", "1234567890+-*=");
                tessocr.Init(null, "eng", false);
                pictureBoxInputLib.Image = tessocr.GetThresholdedImage((Bitmap)pictureBoxInput.Image, Rectangle.Empty);
                List<tessnet2.Word> text = ocr.DoOCRNormal((Bitmap)pictureBoxInput.Image, "eng");
                textBoxInput.Text = text[0].Text;

                //Filled
                tessocr = new tessnet2.Tesseract();
                tessocr.SetVariable("tessedit_char_whitelist", "1234567890+-*=");
                tessocr.Init(null, "eng", false);
                pictureBoxFilledLib.Image = tessocr.GetThresholdedImage((Bitmap)pictureBoxFilled.Image, Rectangle.Empty);
                text = ocr.DoOCRNormal((Bitmap)pictureBoxFilled.Image, "eng");
                textBoxFilled.Text = text[0].Text;
            }
        }

        void FloodFill(Bitmap bitmap, int x, int y, Color color)
        {
            BitmapData data = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int[] bits = new int[data.Stride / 4 * data.Height];
            Marshal.Copy(data.Scan0, bits, 0, bits.Length);

            LinkedList<Point> check = new LinkedList<Point>();
            int floodTo = color.ToArgb();
            int floodFrom = bits[x + y * data.Stride / 4];
            bits[x + y * data.Stride / 4] = floodTo;

            if (floodFrom != floodTo)
            {
                check.AddLast(new Point(x, y));
                while (check.Count > 0)
                {
                    Point cur = check.First.Value;
                    check.RemoveFirst();

                    foreach (Point off in new Point[] {
                new Point(0, -1), new Point(0, 1), 
                new Point(-1, 0), new Point(1, 0)})
                    {
                        Point next = new Point(cur.X + off.X, cur.Y + off.Y);
                        if (next.X >= 0 && next.Y >= 0 &&
                            next.X < data.Width &&
                            next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y * data.Stride / 4] == floodFrom)
                            {
                                check.AddLast(next);
                                bits[next.X + next.Y * data.Stride / 4] = floodTo;
                            }
                        }
                    }
                }
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            bitmap.UnlockBits(data);
        }
    }

    public class Ocr
    {
        public List<tessnet2.Word> DoOCRNormal(Bitmap image, string lang)
        {
            tessnet2.Tesseract ocr = new tessnet2.Tesseract();
            ocr.Init(null, lang, false);
            List<tessnet2.Word> result = ocr.DoOCR(image, Rectangle.Empty);
            return result;
        }
    }
}
