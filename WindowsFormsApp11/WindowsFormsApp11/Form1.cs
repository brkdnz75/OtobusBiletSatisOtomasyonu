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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) ||
           string.IsNullOrEmpty(txtSifre.Text) ||
           string.IsNullOrEmpty(txtTamAdi.Text) ||
           string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection bağlanti = new SqlConnection("Data Source=BRKDNZ75\\SQLEXPRESS;Initial Catalog=OtobusBiletOtomasyonu;Integrated Security=True"))
            {
                
                using (SqlCommand command = new SqlCommand("INSERT INTO Kullanici (KullaniciAdi, Sifre, TamAdi, Email) VALUES (@KullaniciAdi, @Sifre, @TamAdi, @Email)", bağlanti))
                {

                    command.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                    command.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                    command.Parameters.AddWithValue("@TamAdi", txtTamAdi.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);

                bağlanti.Open();
                    command.ExecuteNonQuery();
                bağlanti.Close();

                    MessageBox.Show("Kayıt başarılı!","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide(); 
                    Form2 form2 = new Form2();
                    form2.Show();
                }
            }
        }

        
    }
}