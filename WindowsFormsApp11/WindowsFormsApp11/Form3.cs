
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadData();
        }
        private void Temizle()
        {
            txtBiletID.Text = "";
            txtKullanıcıID.Text = "";
            cmbOtobüsAdi.SelectedIndex = -1;
            cmbKalkis.SelectedIndex = -1;
            cmbVaris.SelectedIndex = -1;
            txtKalkisTarihi.Text = "";
            txtVarisTarihi.Text = "";
            txtFiyat.Text = "";
        }
        private void LoadData()
        {
            using (SqlConnection bağlanti = new SqlConnection("Data Source=BRKDNZ75\\SQLEXPRESS;Initial Catalog=OtobusBiletOtomasyonu;Integrated Security=True"))
            {
                string query;
                if (Form2.currentUserId == 1)
                {
                    query = "SELECT * FROM Biletler"; 
                }
                else
                {
                    query = "SELECT * FROM Biletler WHERE KullaniciID=@KullaniciID"; 
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, bağlanti);
                if (Form2.currentUserId != 1)
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@KullaniciID", Form2.currentUserId);
                }

                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

                int secilen = dataGridView1.SelectedCells[0].RowIndex;

                txtBiletID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                txtKullanıcıID.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                cmbOtobüsAdi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                cmbKalkis.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                cmbVaris.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                txtKalkisTarihi.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                txtVarisTarihi.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
                txtFiyat.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            
        
        }

        
        private void btnEkle_Click(object sender, EventArgs e)
        {

            using (SqlConnection bağlanti = new SqlConnection("Data Source=BRKDNZ75\\SQLEXPRESS;Initial Catalog=OtobusBiletOtomasyonu;Integrated Security=True"))
            {

                using (SqlCommand command = new SqlCommand("INSERT INTO Biletler (KullaniciID, OtobusAdi, Kalkis, Varis, KalkisTarihi, VarisTarihi, Fiyat) VALUES (@KullaniciID, @OtobusAdi, @Kalkis, @Varis, @KalkisTarihi, @VarisTarihi, @Fiyat)", bağlanti))
                {
                    
                    command.Parameters.AddWithValue("@KullaniciID", Form2.currentUserId);
                    command.Parameters.AddWithValue("@OtobusAdi", cmbOtobüsAdi.Text);
                    command.Parameters.AddWithValue("@Kalkis", cmbKalkis.Text);
                    command.Parameters.AddWithValue("@Varis", cmbVaris.Text);
                    command.Parameters.AddWithValue("@KalkisTarihi", DateTime.Parse(txtKalkisTarihi.Text));
                    command.Parameters.AddWithValue("@VarisTarihi", DateTime.Parse(txtVarisTarihi.Text));
                    command.Parameters.AddWithValue("@Fiyat", decimal.Parse(txtFiyat.Text));

                    bağlanti.Open();
                    command.ExecuteNonQuery();
                    bağlanti.Close();

                    LoadData(); 
                    MessageBox.Show("Bilet başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
            }
        }

        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            using (SqlConnection bağlanti = new SqlConnection("Data Source=BRKDNZ75\\SQLEXPRESS;Initial Catalog=OtobusBiletOtomasyonu;Integrated Security=True"))
            {
                
                using (SqlCommand command = new SqlCommand("UPDATE Biletler SET OtobusAdi=@OtobusAdi, Kalkis=@Kalkis, Varis=@Varis, KalkisTarihi=@KalkisTarihi, VarisTarihi=@VarisTarihi, Fiyat=@Fiyat WHERE BiletID=@BiletID", bağlanti))
                {
                    command.Parameters.AddWithValue("@BiletID", int.Parse(txtBiletID.Text));
                    command.Parameters.AddWithValue("@OtobusAdi", cmbOtobüsAdi.Text);
                    command.Parameters.AddWithValue("@Kalkis", cmbKalkis.Text);
                    command.Parameters.AddWithValue("@Varis", cmbVaris.Text);
                    command.Parameters.AddWithValue("@KalkisTarihi", DateTime.Parse(txtKalkisTarihi.Text));
                    command.Parameters.AddWithValue("@VarisTarihi", DateTime.Parse(txtVarisTarihi.Text));
                    command.Parameters.AddWithValue("@Fiyat", decimal.Parse(txtFiyat.Text));

                    bağlanti.Open();
                    command.ExecuteNonQuery();
                    bağlanti.Close();

                    LoadData();
                    MessageBox.Show("Bilet başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
            }
        }

        
        private void btnSil_Click(object sender, EventArgs e)
        {

            using (SqlConnection bağlanti = new SqlConnection("Data Source=BRKDNZ75\\SQLEXPRESS;Initial Catalog=OtobusBiletOtomasyonu;Integrated Security=True"))
            {
                
                using (SqlCommand command = new SqlCommand("DELETE FROM Biletler WHERE BiletID=@BiletID", bağlanti))
                {
                    command.Parameters.AddWithValue("@BiletID", int.Parse(txtBiletID.Text));

                    bağlanti.Open();
                    command.ExecuteNonQuery();
                    bağlanti.Close();

                    LoadData(); 
                    MessageBox.Show("Bilet başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
            }
        }




    }
}