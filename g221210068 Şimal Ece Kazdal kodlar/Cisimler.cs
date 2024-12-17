/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
**
** ÖDEV NUMARASI.............: 1
** ÖĞRENCİ ADI...............: Şimal Ece Kazdal
** ÖĞRENCİ NUMARASI..........: g221210068
** DERS GRUBU................: 2B
** YOUTUBE LİNKİ.............: https://youtu.be/oPEOTVWHcwY
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g221210068_simal_ece_kazdal
{
    public class Cisimler<cisim>
    {
        public int X;
        public int Y;
        public int Z;
        public int Cap;
        public int yukseklik;
        public int genislik;
        public int derinlik;
    }
    class Nokta<cisim> : Cisimler<cisim>
    {
        public Nokta()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 301);
            Y = random.Next(1, 301);
            Z = random.Next(1, 301);
        }
        public void NoktaCiz(PictureBox pictureBox)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Red);

            graphics.DrawEllipse(pen, X, Y, 1, 1);
        }
    }
    class Dortgen<cisim> : Cisimler<cisim>
    {
        public Dortgen()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 201);
            Y = random.Next(1, 201);
            yukseklik = random.Next(1, 201);
            genislik = random.Next(1, 201);
        }
        public void DortgenCiz(PictureBox pictureBox)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.DarkMagenta);

            graphics.DrawRectangle(pen, X, Y, genislik, yukseklik);
        }
    }
    class Dortgen2<cisim> : Cisimler<cisim>
    {
        public Dortgen2()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 201);
            Y = random.Next(1, 201);
            yukseklik = random.Next(1, 201);
            genislik = random.Next(1, 201);
        }
        public void Dortgen2Ciz(PictureBox pictureBox)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.DarkGoldenrod);

            graphics.DrawRectangle(pen, X, Y, genislik, yukseklik);
        }
    }
    class Dikdortgen<cisim> : Cisimler<cisim>
    {
        public Dikdortgen()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 201);
            Y = random.Next(1, 201);
            yukseklik = random.Next(1, 201);
            genislik = random.Next(1, 201);
        }
        public void DikdortgenCiz(PictureBox pictureBox)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.DarkOliveGreen);

            graphics.DrawRectangle(pen, X, Y, genislik, yukseklik);
        }
    }
    class Cember<cisim> : Cisimler<cisim>
    {
        public Cember()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 201);
            Y = random.Next(1, 201);
            Cap = random.Next(1, 201);
        }
        public void CemberCiz(PictureBox pictureBox)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.DarkOrange);

            graphics.DrawEllipse(pen, X, Y, Cap, Cap);
        }
    }
    class Cember2<cisim> : Cisimler<cisim>
    {
        public Cember2()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 201);
            Y = random.Next(1, 201);
            Cap = random.Next(1, 201);
        }
        public void Cember2Ciz(PictureBox pictureBox)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.DarkOrchid);

            graphics.DrawEllipse(pen, X, Y, Cap, Cap);
        }
    }
    class Prizma<cisim> : Cisimler<cisim>
    {
        public Prizma()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 201);
            Y = random.Next(1, 201);
            Z = random.Next(1, 201);
            yukseklik = random.Next(1, 201);
            genislik = random.Next(1, 201);
            derinlik = random.Next(1, 201);
        }
        public void PrizmaCiz(PictureBox pictureBox)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.DarkRed);

            // Alt yüzey
            graphics.DrawRectangle(pen, X, Y, genislik, yukseklik);

            // Üst yüzey
            graphics.DrawRectangle(pen, X + derinlik, Y + derinlik, genislik, yukseklik);

            // Yan yüzeyler
            graphics.DrawLine(pen, X, Y, X + derinlik, Y + derinlik);
            graphics.DrawLine(pen, X + genislik, Y, X + genislik + derinlik, Y + derinlik);
            graphics.DrawLine(pen, X, Y + yukseklik, X + derinlik, Y + yukseklik + derinlik);
            graphics.DrawLine(pen, X + genislik, Y + yukseklik, X + genislik + derinlik, Y + yukseklik + derinlik);
        }
    }
    class Prizma2<cisim> : Cisimler<cisim>
    {
        public Prizma2()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 201);
            Y = random.Next(1, 201);
            Z = random.Next(1, 201);
            yukseklik = random.Next(1, 201);
            genislik = random.Next(1, 201);
            derinlik = random.Next(1, 201);
        }
        public void Prizma2Ciz(PictureBox pictureBox)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.DarkSalmon);

            // Alt yüzey
            graphics.DrawRectangle(pen, X, Y, genislik, yukseklik);

            // Üst yüzey
            graphics.DrawRectangle(pen, X + derinlik, Y + derinlik, genislik, yukseklik);

            // Yan yüzeyler
            graphics.DrawLine(pen, X, Y, X + derinlik, Y + derinlik);
            graphics.DrawLine(pen, X + genislik, Y, X + genislik + derinlik, Y + derinlik);
            graphics.DrawLine(pen, X, Y + yukseklik, X + derinlik, Y + yukseklik + derinlik);
            graphics.DrawLine(pen, X + genislik, Y + yukseklik, X + genislik + derinlik, Y + yukseklik + derinlik);
        }
    }
    class Kure<cisim> : Cisimler<cisim>
    {
        public Kure()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 301);
            Y = random.Next(1, 301);
            Z = random.Next(1, 301);
            Cap = random.Next(1, 101);
        }
        public void KureCiz(PictureBox pictureBox)
        {
            Graphics graphics = pictureBox.CreateGraphics();

            graphics.FillEllipse(Brushes.DarkGray, X, Y, Cap, Cap); 
        }
    }
    class Kure2<cisim> : Cisimler<cisim>
    {
        public Kure2()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 301);
            Y = random.Next(1, 301);
            Z = random.Next(1, 301);
            Cap = random.Next(1, 101);
        }
        public void Kure2Ciz(PictureBox pictureBox)
        {
            Graphics graphics = pictureBox.CreateGraphics();

            graphics.FillEllipse(Brushes.DarkGreen, X, Y, Cap, Cap);
        }
    }
    class Silindir<cisim> : Cisimler<cisim>
    {
        public Silindir()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 201);
            Y = random.Next(1, 201);
            Z = random.Next(1, 201);
            Cap = random.Next(1, 101);
            yukseklik = random.Next(1, 101);
            derinlik = random.Next(1, 101);
        }
        public void SilindirCiz(PictureBox pictureBox)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.DeepPink);

            // alt yüzeyi çizdirme
            graphics.DrawEllipse(pen, X, Y, Cap, Cap);

            // üst yüzeyi çizdirme
            graphics.DrawEllipse(pen, X, Y + yukseklik, Cap, Cap);

            // yan yüzeyleri çizdirme
            graphics.DrawLine(pen, X, Y + Cap / 2, X, Y + yukseklik + Cap / 2);
            graphics.DrawLine(pen, X + Cap, Y + Cap / 2, X + Cap, Y + yukseklik + Cap / 2);
        }
    }
    class Silindir2<cisim> : Cisimler<cisim>
    {
        public Silindir2()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 201);
            Y = random.Next(1, 201);
            Z = random.Next(1, 201);
            Cap = random.Next(1, 101);
            yukseklik = random.Next(1, 101);
            derinlik = random.Next(1, 101);
        }
        public void Silindir2Ciz(PictureBox pictureBox)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.DarkSlateBlue);

            // alt yüzeyi çizdirme
            graphics.DrawEllipse(pen, X, Y, Cap, Cap);

            // üst yüzeyi çizdirme
            graphics.DrawEllipse(pen, X, Y + yukseklik, Cap, Cap);

            // yan yüzeyleri çizdirme
            graphics.DrawLine(pen, X, Y + Cap / 2, X, Y + yukseklik + Cap / 2);
            graphics.DrawLine(pen, X + Cap, Y + Cap / 2, X + Cap, Y + yukseklik + Cap / 2);
        }
    }
    class Yuzey<cisim> : Cisimler<cisim>
    {
        public Yuzey()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 201);
            Y = random.Next(1, 201);
            Z = random.Next(1, 201);
            yukseklik = random.Next(1, 201);
            genislik = 1;
            derinlik = random.Next(1, 201);
        }
        public void YuzeyCiz(PictureBox pictureBox)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.DarkSlateGray);

            // Alt yüzey
            graphics.DrawRectangle(pen, X, Y, genislik, yukseklik);

            // Üst yüzey
            graphics.DrawRectangle(pen, X + derinlik, Y + derinlik, genislik, yukseklik);

            // Yan yüzeyler
            graphics.DrawLine(pen, X, Y, X + derinlik, Y + derinlik);
            graphics.DrawLine(pen, X + genislik, Y, X + genislik + derinlik, Y + derinlik);
            graphics.DrawLine(pen, X, Y + yukseklik, X + derinlik, Y + yukseklik + derinlik);
            graphics.DrawLine(pen, X + genislik, Y + yukseklik, X + genislik + derinlik, Y + yukseklik + derinlik);
        }
    }
}