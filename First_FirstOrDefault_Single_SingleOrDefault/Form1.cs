using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_FirstOrDefault_Single_SingleOrDefault
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] sayilar = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };
        private void button1_Click(object sender, EventArgs e)
        {
            int a = sayilar.First();
            int b = sayilar.First(x => x > 13);
            int d = sayilar.FirstOrDefault(x => x > 12);
            int f = sayilar.FirstOrDefault(x => x > 30);

            try
            {
                // int c = sayilar.First(x => x > 30);
            }
            catch (InvalidOperationException hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // int a = sayilar.Single();
                // int b = sayilar.Single(x => x > 13);
                // int c = sayilar.SingleOrDefault(x => x > 25);
            }
            catch (InvalidOperationException hata)
            {
                MessageBox.Show(hata.Message);
            }

            int d = sayilar.Single(x => x > 27);
            int g = sayilar.SingleOrDefault(x => x == 13);
            int f = sayilar.SingleOrDefault(x => x > 29);
            int h = sayilar.SingleOrDefault(x => x > 30);
        }
    }
}
// First metodu bir dizi içerisinden ilk elemanı seçmek için kullanılır.

// Aynı şekilde bir kriter sonucunda sonuç birden fazla dönerse yine dizinin belirlenen kritere göre ilk elemanı seçilecektir.

// Eğer herhangi bir sonuç dönmezse InvalidOperationException hatası verilir.

// First metodunda çalışan kriter sağlanmazsa bu hatayı verirken, FirstOrDefault metodunda aynı kriter sağlanmadığı zaman 0 döndürür. Aradaki tek fark budur. Hata vermesindense değer atanacak değişkene 0 gönderir.

// Single metodu ise First metodundan farklı olarak tek bir değer döndürmek zorundadır. Aksi halde InvalidOperationException hatasını verir.

// Single ile First arasındaki fark: First belirlenen kritere göre diziden bulduğu sadece ilk değeri yakalayabilirken, single ilk değerden fazlasını yakalar ve bu yüzden hata verir.

// Single metoduna mutlaka tek değer yakalayacağı bir kriter yazılmak zorundadır.

// SingleOrDefault metoduda aynı şekilde birden fazla değer yakalarsa hata verecektir. Ama Single metodundan tek farkı eğer belirlenen kriterin dışına çıkılmışsa 0 döndürür.