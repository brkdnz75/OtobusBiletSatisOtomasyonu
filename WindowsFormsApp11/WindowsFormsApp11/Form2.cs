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
    public partial class Form2 : Form
    {
        public static int currentUserId;
        public Form2()
        {
            InitializeComponent();

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            using (SqlConnection bağlanti = new SqlConnection("Data Source=BRKDNZ75\\SQLEXPRESS;Initial Catalog=OtobusBiletOtomasyonu;Integrated Security=True"))
            {
                
                using (SqlCommand command = new SqlCommand("SELECT KullaniciId FROM Kullanici WHERE  KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre", bağlanti))
                {
                    command.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                    command.Parameters.AddWithValue("@Sifre", txtSifre.Text);

                    bağlanti.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        currentUserId = reader.GetInt32(0);
                        MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form3 anaForm = new Form3();
                        anaForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Giriş başarısız. Kullanıcı adı ve şifrenizi kontrol edin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    bağlanti.Close();
                }
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            
            Form1 kayitFormu = new Form1();
            kayitFormu.Show();

            
            this.Hide();
        }
    }
}