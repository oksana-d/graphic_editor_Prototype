using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace graphics_editor
{
    public partial class RectangularForm : AbstractHolst
    {
        private Bitmap bmp;
        static Color CurrentColor=Color.Black;
        public static int size = 5;
        private Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        RectangularPen rectangularPen;
        Pen pen;


        PictureBox pic = new PictureBox();
        private int begin_x;
        private int begin_y;
        bool resize = false;
        private int scroller_vert = -1;
        private int scroller_hor = -1;

        iFigure klon = new CopyRectangle();

        [DllImport("user32.dll")]
        public static extern int SendMessage(
              int hWnd,      // handle to destination window
              uint Msg,       // message
              long wParam,  // first message parameter
              long lParam   // second message parameter
              );

        public RectangularForm()
        {
            InitializeComponent();
            
            bmp = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            rectangularPen = new RectangularPen();
            pen = new Pen(CurrentColor, size);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);


            pic.Parent = pictureBox1;
            pic.BackColor = Color.Transparent;
            pic.SizeMode = PictureBoxSizeMode.AutoSize;
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.Visible = false;

            //klon.pbox1 = (Bitmap)pictureBox1.Image;
        }

        private void touch(MouseEventArgs e)
        {
            using (g = Graphics.FromImage(pictureBox1.Image))
            {
                SolidBrush solidBrush = new SolidBrush(CurrentColor);
                g.FillRectangle(solidBrush, e.X, e.Y, size, size);
            }
            pictureBox1.Invalidate();
        }

        private void цветПераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == System.Windows.Forms.DialogResult.OK)
            {
                CurrentColor = colorDialog1.Color;
            }
            pen = new Pen(CurrentColor, size);
        }
        
        private void размерПераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SizePen("rectangle").ShowDialog();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(pictureBox1.Image);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);
        }

        private void сохранитьРисунокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранить как...";
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;
            sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image.Save(sfd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить изображение","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (highlight_checkBox.Checked != true)
            {
                moving = true;
                touch(e);
                x = e.X;
                y = e.Y;
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    begin_x = e.X;
                    begin_y = e.Y;
                    pic.Left = e.X;
                    pic.Top = e.Y;
                    pic.Width = 0;
                    pic.Height = 0;
                    pic.Visible = true;
                    timer1.Start();
                    resize = true;
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (highlight_checkBox.Checked != true)
            {
                if (moving && x != -1 && y != -1)
                {
                    touch(e);
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    pic.Width = e.X - begin_x;
                    pic.Height = e.Y - begin_y;

                    //Скроллинг...
                    scroller_hor = -1;
                    scroller_vert = -1;

                    if (e.X > pictureBox1.Width - 5)
                    { scroller_hor = 0; }

                    if (e.Y > pictureBox1.Height - 5)
                    { scroller_vert = 0; }

                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (highlight_checkBox.Checked != true)
            {
                moving = false;
                x = e.X;
                y = e.Y;
            }
            else
            {
                pic.Width = 0;
                pic.Height = 0;
                pic.Visible = false;
                timer1.Stop();
                if (resize == true)
                {
                    if ((e.X > begin_x + 10) && (e.Y > begin_y + 10)) //Чтобы совсем уж мелочь не вырезал - и по случайным нажатиям не срабатывал! (можно убрать +10)
                    {
                        Rectangle rec = new Rectangle(begin_x, begin_y, e.X - begin_x, e.Y - begin_y);
                        klon.Clone(klon, bmp, rec);
                        //klon.pbox1 = Copy(pictureBox1.Image, rec).Clone() as Image;
                        //pictureBox1.Image = bmp;
                    }
                }
                resize = false;
            }
        }

        //static public Image Copy(Image srcBitmap, Rectangle section)
        //{
        //    // Вырезаем выбранный кусок картинки
        //    Bitmap bmp = new Bitmap(section.Width, section.Height);
        //    using (Graphics g = Graphics.FromImage(bmp))
        //    {
        //        g.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel);
        //    }
        //    //Возвращаем кусок картинки.
        //    return bmp;
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (scroller_vert > -1)
            {
                SendMessage(pictureBox1.Handle.ToInt32(), 277, 1, scroller_vert);
            }
            if (scroller_hor > -1)
            {
                SendMessage(pictureBox1.Handle.ToInt32(), 276, 1, scroller_hor);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (klon.pbox1 != null)
            {
                using (g = Graphics.FromImage(bmp))
                {
                    if (x_textBox.Text.Length != 0 && y_textBox.Text.Length != 0)
                    {
                        if (klon.pbox1.Width + Int32.Parse(x_textBox.Text) <= bmp.Width && klon.pbox1.Height + Int32.Parse(y_textBox.Text) <= bmp.Height)
                        {
                            g.DrawImage(klon.pbox1, new PointF(Int32.Parse(x_textBox.Text), Int32.Parse(y_textBox.Text)));
                            bmp = (Bitmap)pictureBox1.Image;
                            pictureBox1.Invalidate();
                        }
                        else MessageBox.Show("Ваши координаты вышли за пределы холста, попробуйте другие", "Внимание");
                    } else MessageBox.Show("Введите координаты для вставки", "Внимание");
                }
            }
        }

        private void x_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            char num = e.KeyChar;
            if (!Char.IsDigit(num.ToString(),0) && num != 8)
            { 
                e.Handled = true;
            }
        }

        private void y_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            char num = e.KeyChar;
            if (!Char.IsDigit(num.ToString(), 0) && num != 8)
            {
                e.Handled = true;
            }
        }
    }
}
