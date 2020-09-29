using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Depo_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        SqlConnection connectDB = new SqlConnection(@"Data Source = ASUS;Initial Catalog=depotakip;Integrated Security=True");
        //SqlConnection connectDB = new SqlConnection(@"Server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\depotakip\depotakip.mdf;Integrated Security=True");

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connectDB.Open();
            SqlCommand command = new SqlCommand("select StokKodu from UrunBilgisi", connectDB);
            SqlDataReader stokKodu = command.ExecuteReader();

            bool kaydet = true;

            while (stokKodu.Read())
            {
                if (stokKodu[0].ToString() == tbStokKodu.Text)
                {
                    MessageBox.Show(tbStokKodu.Text + " Stok Kodu Mevcut. Farklı bir stok kodu giriniz!!!");
                    kaydet = false;
                    break;
                }
            }

            connectDB.Close();

           

            if (kaydet == true)
            {
                connectDB.Open();
                SqlCommand ekle = new SqlCommand(@"insert into UrunBilgisi(StokKodu,UrunAdi,Adet,GelisFiyati,SatisFiyati,KDV) values(@p1,@p2,@p3,@p4,@p5,@p6)", connectDB);
                ekle.Parameters.AddWithValue("@p1", tbStokKodu.Text);
                ekle.Parameters.AddWithValue("@p2", tbUrunAdi.Text);
                if (string.IsNullOrEmpty(tbUrunAdeti.Text))
                    ekle.Parameters.AddWithValue("@p3", "0");
                else
                    ekle.Parameters.AddWithValue("@p3", tbUrunAdeti.Text);
               
                if (string.IsNullOrEmpty(tbGelisFiyati.Text))
                    ekle.Parameters.AddWithValue("@p4", "");
                else
                    ekle.Parameters.AddWithValue("@p4", Convert.ToDecimal(tbGelisFiyati.Text));

                if (string.IsNullOrEmpty(tbSatisFiyati.Text))
                    ekle.Parameters.AddWithValue("@p5", "");
                else
                    ekle.Parameters.AddWithValue("@p5", Convert.ToDecimal(tbSatisFiyati.Text));

                ekle.Parameters.AddWithValue("@p6", tbKdv.Text);

                ekle.ExecuteNonQuery();

                connectDB.Close();
            }
            


            Listele();
        }

        private void Listele()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("select * from UrunBilgisi",connectDB);
            DataSet dataset = new DataSet();
            sqlData.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
        }

        private void ListeleStokKodu()
        {
            SqlDataAdapter bul = new SqlDataAdapter("select * from UrunBilgisi where StokKodu='" + tbStokKodu.Text + "'", connectDB);
            DataSet dataset = new DataSet();
            bul.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
        }

        string data_path;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                data_path = path + @"\depotakip\";

                System.IO.Directory.CreateDirectory(path + @"\depotakip");
                if (!System.IO.File.Exists(path + @"\depotakip\depotakip.mdf"))
                {
                    System.IO.File.Copy(System.AppDomain.CurrentDomain.BaseDirectory + @"depotakip.mdf", path + @"\depotakip\depotakip.mdf");
                    System.IO.File.Copy(System.AppDomain.CurrentDomain.BaseDirectory + @"depotakip_log.mdf", path + @"\depotakip\depotakip_log.ldf");
                }

            }
            catch (Exception)
            {

                throw;
            }

            connectDB.Open();
            try
            {
                SqlDataAdapter dbversion = new SqlDataAdapter("select DBVersion from DBVersion ", connectDB);
                DataSet dataset = new DataSet();
                dbversion.Fill(dataset);
                int dbVersion = Convert.ToInt32(dataset.Tables[0].Rows[0][0].ToString());

                    switch (dbVersion)
                    {
                        case 0:

                            break;
                        case 1:
                        //SqlCommand command = new SqlCommand("alter table [UrunBilgisi] add [new] int default 0 NOT NULL ", connectDB);
                        //command.ExecuteNonQuery();
                        ////dbversion = dbversion + 1;
                            break;

                        case 2:
                            break;

                        default:
                            break;
                    }

            }
            catch (Exception)
            {

                throw;
            }

            //SqlCommand dbVerisonGuncelle = new SqlCommand("update DBVersion set DBVersion=@p1 ", connectDB);
            //command.ExecuteNonQuery();

            connectDB.Close();

            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
   
                connectDB.Open();
                SqlCommand command = new SqlCommand("select Adet from UrunBilgisi where StokKodu=@p1", connectDB);
                command.Parameters.AddWithValue("@p1", tbStokKodu.Text);
                SqlDataReader urunAdet = command.ExecuteReader();

                int adet = 0;

                while (urunAdet.Read())
                {
                    adet = Convert.ToInt32(urunAdet[0]);
                }
                connectDB.Close();

                connectDB.Open();
                SqlCommand guncelle = new SqlCommand("update UrunBilgisi set StokKodu=@p1,UrunAdi=@p2,Adet=@p3,GelisFiyati=@p4,SatisFiyati=@p5,KDV=@p6 where StokKodu=@p1", connectDB);
                guncelle.Parameters.AddWithValue("@p1", tbStokKodu.Text);
                guncelle.Parameters.AddWithValue("@p2", tbUrunAdi.Text);
                if (string.IsNullOrEmpty(tbUrunAdeti.Text))
                    guncelle.Parameters.AddWithValue("@p3", "");
                else
                    guncelle.Parameters.AddWithValue("@p3", Convert.ToInt32(adet));

                //guncelle.Parameters.AddWithValue("@p4", Convert.ToDecimal(tbGelisFiyati.Text));
                //if (string.IsNullOrEmpty(tbGelisFiyati.Text))
                //{
                //    guncelle.Parameters.AddWithValue("@p5", "");

                //}
                //else
                //{
                //    guncelle.Parameters.AddWithValue("@p5",Convert.ToDecimal(tbGelisFiyati.Text) * (Convert.ToDecimal(tbKdv.Text) / 100));
                //}

                if (string.IsNullOrEmpty(tbGelisFiyati.Text))
                    guncelle.Parameters.AddWithValue("@p4", "");
                else
                    guncelle.Parameters.AddWithValue("@p4", Convert.ToDecimal(tbGelisFiyati.Text));

                if (string.IsNullOrEmpty(tbSatisFiyati.Text))
                    guncelle.Parameters.AddWithValue("@p5", "");
                else
                    guncelle.Parameters.AddWithValue("@p5", Convert.ToDecimal(tbSatisFiyati.Text));

                guncelle.Parameters.AddWithValue("@p6", tbKdv.Text);

                guncelle.ExecuteNonQuery();
                connectDB.Close();

            MessageBox.Show("Ürün Güncellendi.");

                ListeleStokKodu();
            }
           

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            int sec = dataGridView1.SelectedCells[0].RowIndex;

            string StokKodu = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            string UrunAdi = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            string Adet = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            string GelisFiyati = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            string SatisFiyati = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            string kdv= dataGridView1.Rows[sec].Cells[5].Value.ToString();

            tbStokKodu.Text = StokKodu;
            tbUrunAdi.Text = UrunAdi;
            tbUrunAdeti.Text = Adet;
            tbGelisFiyati.Text = GelisFiyati;
            tbSatisFiyati.Text = SatisFiyati;
            tbKdv.Text = kdv;


        }

        private void btnDepoCikisi_Click(object sender, EventArgs e)
        {
            //Ürün sil

            var result = MessageBox.Show(tbStokKodu.Text + " Stok Kodlu Ürünü Silmek İstediğinize Emin misniz?","Form Closing",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                connectDB.Open();
                SqlCommand command = new SqlCommand("Delete from UrunBilgisi where StokKodu=@p1", connectDB);
                command.Parameters.AddWithValue("@p1", tbStokKodu.Text);
                command.ExecuteNonQuery();
                connectDB.Close();
                Listele();
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbStokKodu.Clear();
            tbUrunAdi.Clear();
            tbUrunAdeti.Clear();
            tbKdv.Clear();
            tbGelisFiyati.Clear();
            tbSatisFiyati.Clear();
            tbUrunAdiGetir.Clear();
            tbStokKoduGetir.Clear();
        }

        private void btnStokKodGetir_Click(object sender, EventArgs e)
        {
            SqlDataAdapter bul = new SqlDataAdapter("select * from UrunBilgisi where StokKodu='" + tbStokKoduGetir.Text + "'", connectDB);
            DataSet dataset = new DataSet();
            bul.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
        }

        private void btnUrunAdiGetir_Click(object sender, EventArgs e)
        {
            SqlDataAdapter bul = new SqlDataAdapter("select * from UrunBilgisi where UrunAdi='" + tbUrunAdiGetir.Text + "'", connectDB);
            DataSet dataset = new DataSet();
            bul.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTarih.Text = DateTime.Now.ToLongDateString();
            lbSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnListeGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void tbGelisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbKdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbUrunAdeti_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        { // Ürün Adeti Güncelle

            connectDB.Open();
            SqlCommand command = new SqlCommand("select Adet from UrunBilgisi where StokKodu=@p1", connectDB);
            command.Parameters.AddWithValue("@p1", tbStokKodu.Text);
            SqlDataReader urunAdet = command.ExecuteReader();

            int adet = 0;

            while (urunAdet.Read())
            {
                adet = Convert.ToInt32(urunAdet[0]);
            }
            connectDB.Close();

            connectDB.Open();
            SqlCommand guncelle = new SqlCommand("update UrunBilgisi set Adet=@p3 where StokKodu=@p1", connectDB);
            guncelle.Parameters.AddWithValue("@p1", tbStokKodu.Text);
            if (string.IsNullOrEmpty(tbUrunAdeti.Text))
                guncelle.Parameters.AddWithValue("@p3", "");
            else
                guncelle.Parameters.AddWithValue("@p3", Convert.ToInt32(adet) + Convert.ToInt32(tbUrunAdeti.Text));

            guncelle.ExecuteNonQuery();
            connectDB.Close();

            MessageBox.Show(tbStokKodu.Text + " Stok Kodlu Ürün Adeti Güncellendi.");

            ListeleStokKodu();
        }
    }
}
