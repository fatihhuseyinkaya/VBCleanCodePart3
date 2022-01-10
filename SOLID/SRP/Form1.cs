using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            /*
             * Bir sınıf içindeki bir kodu değiştirmek için birden fazla sebebiniz varsa bu prensibi İHLAL EDİYORSUNUZ demektir!
             * 
             */
            string ad = textBoxUrunAdi.Text;
            decimal fiyat = Convert.ToDecimal(textBoxFiyat.Text);
            ProductBusiness productBusiness = new ProductBusiness();
            int affectedRow = productBusiness.UrunEkle(ad,fiyat);
            string message = affectedRow > 0 ? "İşlem başarılı" : "Başarısız...";
            MessageBox.Show(message);
        }

      
    }
}
