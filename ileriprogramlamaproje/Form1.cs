using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ileriprogramlamaproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Lütfen Yukarıdan Menüden Dosyaya Tıklayarak Fotoğrafınızı Yükleyiniz.");
        }
        private void DosyaAc()
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpeg| video|*.avi| Tüm Dosyalar |*.*";
            dosya.Title = "";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pictureBox1.ImageLocation = DosyaYolu;
        }
        private Bitmap GriYap(Bitmap cikisresmi)
        {
            for(int i = 0; i < cikisresmi.Height - 1; i++)
            {
                for(int j=0; j < cikisresmi.Width - 1; j++)
                {
                    int deger = (cikisresmi.GetPixel(j, i).R + cikisresmi.GetPixel(j, i).G + cikisresmi.GetPixel(j, i).B * 0) / 3;
                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);
                    cikisresmi.SetPixel(j, i, renk);
                }
            }
            return cikisresmi;
        }
        private void DosyaKaydet()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG files(*.jpeg|*.jpeg";
            if(DialogResult.OK == sfd.ShowDialog())
            {
                this.pictureBox2.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                
            }
        }
        private void Negatif()
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("önce bir resim seçin");
            }
            else
            {
                int i, j;
                Color r;
                Bitmap bmp = new Bitmap(pictureBox1.Image);

                for(i=0; i <= bmp.Width - 1; i++)
                {
                    for(j=0; j <= bmp.Height - 1; j++)
                    {
                        r = bmp.GetPixel(i, j);
                        r = Color.FromArgb(r.A, (byte)-r.R, (byte)-r.G, (byte)-r.B);
                        bmp.SetPixel(i, j, r);
                        
                    }
                }
                pictureBox2.Image = bmp;
            }
        }
        private void Cikis()
        {
            Application.Exit();
        }
        private void Piksel()
        {
            int xof, yof;
            var pikselBoyutu = Convert.ToInt16(sikistir_text.Text);

            var orjinalGoruntu = new Bitmap(pictureBox1.Image);
            var goruntuGenislik = orjinalGoruntu.Width;
            var goruntuYukseklik = orjinalGoruntu.Height;

            var piksellestirilmisGoruntu = new Bitmap(goruntuGenislik, goruntuYukseklik);

            for(var i = 0; i < goruntuGenislik; i += pikselBoyutu)
            {
                for(var j = 0; j < goruntuYukseklik; j += pikselBoyutu)
                {
                    xof = yof = pikselBoyutu / 2;

                    if (i + xof >= goruntuGenislik)
                    {
                        xof = goruntuGenislik - i - 1;
                    }
                    if(j+yof >= goruntuYukseklik)
                    {
                        yof = goruntuYukseklik - j - 1;
                    }
                    var piksel = orjinalGoruntu.GetPixel(i + xof, j + yof);

                    for(var x = i; x < i + pikselBoyutu && x < goruntuGenislik; x++)
                    {
                        for(var y = j; y < j + pikselBoyutu && y < goruntuYukseklik; y++)
                        {
                            piksellestirilmisGoruntu.SetPixel(x, y, piksel);
                        }
                    }
                }
            }
            pictureBox2.Image = piksellestirilmisGoruntu;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void griyeÇevir_tool_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap gri = GriYap(image);
            pictureBox2.Image = gri;
        }

        private void negatifeÇevir_tool_Click(object sender, EventArgs e)
        {
            Negatif();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void sıkıştır_tool_Click(object sender, EventArgs e)
        {
            int i;
            if (sikistir_text.Text == "")
            {
                i = 0;
                MessageBox.Show("Sıkıştırmak İstediğiniz Miktarı Boş Olamaz.");
            }
            else { i = 1; }
            if (i == 1)
            {
                Piksel();
            }
        }

        private void dosyaAç_tool_Click(object sender, EventArgs e)
        {
            DosyaAc();
        }

        private void dosyaKaydet_tool_Click(object sender, EventArgs e)
        {
            DosyaKaydet();
        }

        private void çıkış_tool_Click(object sender, EventArgs e)
        {
            Cikis();
        }


        private void netleştir_tool_Click(object sender, EventArgs e)
        {
            netlestir2();
        }
        private void netlestir2()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int x, y, i, j, toplamR, toplamG, toplamB;
            int R, G, B;
            int[] Matris = { 0, -2, 0, -2, 11, -2, 0, -2, 0 };
            int MatrisToplami = 0 + -2 + 0 + -2 + 11 + -2 + 0 + -2 + 0;
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) 
 {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    toplamR = 0;
                    toplamG = 0;
                    toplamB = 0;

                    int k = 0; 
                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                            toplamR = toplamR + OkunanRenk.R * Matris[k];
                            toplamG = toplamG + OkunanRenk.G * Matris[k];
                            toplamB = toplamB + OkunanRenk.B * Matris[k];
                            k++;
                        }
                    }
                    R = toplamR / MatrisToplami;
                    G = toplamG / MatrisToplami;
                    B = toplamB / MatrisToplami;

                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;

                    CikisResmi.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }
            pictureBox2.Image = CikisResmi;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
