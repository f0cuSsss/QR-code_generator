using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using QR_Code_Generator.entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace QR_Code_Generator
{
    public partial class Form1 : Form
    {
        ColorType _colorType;
        Color _color;
        Bitmap _qr;

        public Form1()
        {
            _colorType = ColorType.User;
            _color = Color.Black;
            InitializeComponent();
        }

        /// <summary>
        /// Шифровка QR-code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EncodeQRcode_Click(object sender, EventArgs e)
        {
            try
            {
                if (generText.Text.Equals(String.Empty))
                {
                    MessageBox.Show("Поле ввода текста пустое!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                QRCodeEncoder QRencoder = new QRCodeEncoder();
                //Bitmap bmp = QRencoder.Encode(generText.Text) as Bitmap;
                //QRcode.Image = bmp;
                if (_color.Equals(Color.Black))
                    _qr = QRencoder.Encode(generText.Text) as Bitmap;
                else
                    _qr = convertColor(QRencoder.Encode(generText.Text) as Bitmap);

                QRcode.Image = _qr;
                btnOpenNewTab.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private Bitmap convertColor(Bitmap bmp)
        {
            List<Pixel> pixels = GetPixels(bmp);
            Bitmap changedBMP = new Bitmap(bmp.Width, bmp.Height);

            //var temp = pixels.Find(x => x._color.Equals(Color.Black));
            //List<Color> colors = new List<Color>();
            //foreach (Pixel item in pixels)
            //{
            //    if(!colors.Contains(item._color))
            //    {
            //        colors.Add(item._color);
            //        MessageBox.Show(item._color.ToString());
            //    }
            //}

            foreach (Pixel pix in pixels)
            {
                if (!pix._color.Equals(Color.FromArgb(255, 255, 255, 255)))
                    pix._color = _color;
                changedBMP.SetPixel(pix._point.X, pix._point.Y, pix._color);
            }


            return changedBMP;
        }

        private List<Pixel> GetPixels(Bitmap bitmap)
        {
            var pixels = new List<Pixel>(bitmap.Width * bitmap.Height);

            for (int x = 0; x < bitmap.Height; x++)
            {
                for (int y = 0; y < bitmap.Width; y++)
                {
                    pixels.Add(new Pixel()
                    {
                        _color = bitmap.GetPixel(x, y),
                        _point = new Point() { X = x, Y = y }
                    });
                }
            }
            return pixels;
        }

        /// <summary>
        /// Сохранение QR-code как картинка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveQRcode_Click(object sender, EventArgs e)
        {
            if (QRcode.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "";
                sfd.Filter = "PNG | *.PNG | JPG | *.jpg | BMP | *.bmp";
                if (!sfd.ShowDialog().Equals(DialogResult.OK))
                    return;
                if (sfd.FileName.Equals(String.Empty))
                {
                    MessageBox.Show("Путь не выбран", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                QRcode.Image.Save(sfd.FileName, ImageFormat.Jpeg);
            }
            else
            {
                MessageBox.Show("QR-code не найден", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("QR-code сохранен!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Копирование QR-code в буфер обмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyQRcode_Click(object sender, EventArgs e)
        {
            if (QRcode.Image != null)
            {
                Clipboard.SetImage(QRcode.Image);
            }
            else
            {
                MessageBox.Show("QR-code не найден", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("QR-code скопирован в буфер обмена", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Расшифровка QR-code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void decryptQRcode_Click(object sender, EventArgs e)
        {
            try
            {
                String decrStr = String.Empty;
                if (QRcode.Image != null)
                {
                    QRCodeDecoder QRdecoder = new QRCodeDecoder();
                    decrStr = QRdecoder.Decode(new QRCodeBitmapImage(QRcode.Image as Bitmap));
                }
                else
                {
                    MessageBox.Show("Загрузите QR-code для расшифровки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (decrStr.Equals(String.Empty))
                {
                    MessageBox.Show("Ошибка расшифровки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                generText.Text = decrStr;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //MessageBox.Show(decrStr, "Расшифровка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Загрузка QR-code с файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uploadQRcode_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = String.Empty;
            ofd.Filter = "PNG | *.png | JPG | *.jpg | BMP | *.bmp | All Files | *.*";
            if (!ofd.ShowDialog().Equals(DialogResult.OK))
                return;
            if (ofd.FileName.Equals(String.Empty))
            {
                MessageBox.Show("Путь не выбран", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            QRcode.ImageLocation = ofd.FileName;
            btnOpenNewTab.Enabled = true;
        }

        /// <summary>
        /// Открытие QR-code в отдельной вкладке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenNewTab_Click(object sender, EventArgs e)
        {
            QRCodeForm _form = new QRCodeForm();
            _form.QRCode_Full.Image = QRcode.Image;
            _form.ShowDialog();
            _form.Close();
        }

        /// <summary>
        /// Выбор цвета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выбратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (!cd.ShowDialog().Equals(DialogResult.OK))
                return;
            else
                _color = cd.Color;
        }
    }
}
