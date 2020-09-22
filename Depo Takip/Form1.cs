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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connectDB.Open();
            SqlCommand ekle = new SqlCommand("insert into UrunBilgisi(StokKodu,UrunAdi,Adet) values(@p1,@p2,@p3)",connectDB);
            ekle.Parameters.AddWithValue("@p1",tbStokKodu.Text);
            ekle.Parameters.AddWithValue("@p2",tbUrunAdi.Text);
            ekle.Parameters.AddWithValue("@p3",tbUrunAdeti.Text);

            ekle.ExecuteNonQuery();

            connectDB.Close();


            Listele();
        }

        



        private void Listele()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("select * from UrunBilgisi",connectDB);
            DataSet dataset = new DataSet();
            sqlData.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
        }


        private void Form1_Load(object sender, EventArgs e)
        {
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
            SqlCommand guncelle = new SqlCommand("update UrunBilgisi set StokKodu=@p1,UrunAdi=@p2,Adet=@p3 where StokKodu=@p1", connectDB);
            guncelle.Parameters.AddWithValue("@p1", tbStokKodu.Text);
            guncelle.Parameters.AddWithValue("@p2", tbUrunAdi.Text);

            int yeniUrunAdet = Convert.ToInt32(adet) + Convert.ToInt32(tbUrunAdeti.Text);

            guncelle.Parameters.AddWithValue("@p3", yeniUrunAdet.ToString());
            guncelle.ExecuteNonQuery();
            connectDB.Close();

            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;

            string StokKodu = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            string UrunAdi = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            string Adet = dataGridView1.Rows[sec].Cells[2].Value.ToString();

            tbStokKodu.Text = StokKodu;
            tbUrunAdi.Text = UrunAdi;
            tbUrunAdeti.Text = Adet;

        }

        private void btnDepoCikisi_Click(object sender, EventArgs e)
        {
            connectDB.Open();
            SqlCommand command = new SqlCommand("Delete from UrunBilgisi where StokKodu='@p1'", connectDB);
            command.Parameters.AddWithValue("@p1", tbStokKodu.Text);
            command.ExecuteNonQuery();
            connectDB.Close();

        }
    }
}
