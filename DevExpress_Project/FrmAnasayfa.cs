using DevExpress.XtraEditors;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress_Project
{
    public partial class FrmAnasayfa : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server =localhost;Port=5454;Database=postgres;User Id =ysf; Password=ysf_46;");
        FrmOgrenci _frmOgrenci;

        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void btnOgrenciler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_frmOgrenci == null)
            {
                _frmOgrenci = new FrmOgrenci();
                _frmOgrenci.MdiParent = this;
                _frmOgrenci.Show();
            }
        }

        private void btnEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            baglanti.Open();
            try
            {
            NpgsqlCommand komut = new NpgsqlCommand("Insert into tblogrenci (ad,soyad,numara,kulup_id,fotograf) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
                komut.Parameters.AddWithValue("@p1", _frmOgrenci.ogr.Ad);
                komut.Parameters.AddWithValue("@p2", _frmOgrenci.ogr.Soyad);
                komut.Parameters.AddWithValue("@p3", _frmOgrenci.ogr.Numara);
                komut.Parameters.AddWithValue("@p4", _frmOgrenci.ogr.Kulup);
                komut.Parameters.AddWithValue("@p5", _frmOgrenci.ogr.Yol);
                komut.ExecuteNonQuery();
                XtraMessageBox.Show("Öğrenci Kaydı Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _frmOgrenci.Listele();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Hata");
                //throw;
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komutSil = new NpgsqlCommand("Delete From tblogrenci where id=@p1", baglanti);
            komutSil.Parameters.AddWithValue("@p1", _frmOgrenci.ogr.Id);
            komutSil.ExecuteNonQuery();
            baglanti.Close();
            XtraMessageBox.Show("Kayıt silme işleme yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _frmOgrenci.Listele();
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(5000);
        }

        private void btnGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //int a = _frmOgrenci.ogr.Kulup == null ? 0 : _frmOgrenci.ogr.Kulup;
            baglanti.Open();
            try
            {
                NpgsqlCommand komut = new NpgsqlCommand
                ("Update tblogrenci set ad=@p1,soyad=@p2,numara=@p3,kulup_id=@p4,fotograf=@p5 where id=@p6", baglanti);
                komut.Parameters.AddWithValue("@p1", _frmOgrenci.ogr.Ad);
                komut.Parameters.AddWithValue("@p2", _frmOgrenci.ogr.Soyad);
                komut.Parameters.AddWithValue("@p3", _frmOgrenci.ogr.Numara);
                komut.Parameters.AddWithValue("@p4", _frmOgrenci.ogr.Kulup);
                komut.Parameters.AddWithValue("@p5", _frmOgrenci.ogr.Yol ?? "");
                komut.Parameters.AddWithValue("@p6", _frmOgrenci.ogr.Id);
                komut.ExecuteNonQuery();
                XtraMessageBox.Show("Kayıt Güncellendi");
                _frmOgrenci.Listele();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Hata");
            }
            finally
            {
                baglanti.Close();
            }
        }

        
    }
}
