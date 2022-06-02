using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace DevExpress_Project
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }
        public int Kulup { get; set; }
        public string Yol { get; set; } //code first vs database first, one to many many to one 
    }

    public partial class FrmOgrenci : Form
    {
        public Ogrenci ogr;
        NpgsqlConnection baglanti =
            new NpgsqlConnection("Server =localhost;Port=5454;Database=postgres;User Id =ysf; Password=ysf_46;");

        public FrmOgrenci()
        {
            InitializeComponent();
            ogr = new Ogrenci();
        }

        private void txteditId_EditValueChanged(object sender, EventArgs e)
        {
           
            ogr.Id = Convert.ToInt32(txteditId.Text == "" ? "0" : txteditId.Text);
        }

        private void txteditAd_TextChanged(object sender, EventArgs e)
        {
            ogr.Ad = txteditAd.Text;
        }

        private void txteditSoyad_TextChanged(object sender, EventArgs e)
        {
            ogr.Soyad = txteditSoyad.Text;
        }

        private void txteditNumara_TextChanged(object sender, EventArgs e)
        {
            ogr.Numara = txteditNumara.Text;
        }


        private void lookUpEditKulup_EditValueChanged(object sender, EventArgs e)
        {
            ogr.Kulup = Convert.ToInt32(lookUpEditKulup.EditValue == null ? "0" : txteditId.Text);
        }

        void Kulupler()
        {
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from tblkulup", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lookUpEditKulup.Properties.ValueMember = "id";
            lookUpEditKulup.Properties.DisplayMember = "kulup_ad";
            lookUpEditKulup.Properties.DataSource = dt;
        }

        public void Listele()
        {
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select tblogrenci.id,ad,soyad,numara,kulup_ad,fotograf from tblogrenci inner join tblkulup on tblogrenci.kulup_id=tblkulup.id", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControlOgrenci.DataSource = dt;
        }

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(5000);   
            Listele();
            Kulupler();
        }

        private void gridViewOgrenci_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DataRow dr = gridViewOgrenci.GetDataRow(gridViewOgrenci.FocusedRowHandle);
            if (dr != null)
            {
                txteditId.Text = dr[0].ToString();
                txteditAd.Text = dr[1].ToString();
                txteditSoyad.Text = dr[2].ToString();
                txteditNumara.Text = dr[3].ToString();
                lookUpEditKulup.Text = dr[4].ToString();
                if (dr[5].ToString() != "")
                    pictureEdit.Image = Image.FromFile(dr[5].ToString());
                else
                    pictureEdit.Image = null;
            }
        }

        private void pictureEdit_EditValueChanged(object sender, EventArgs e)
        {
            ogr.Yol = pictureEdit.GetLoadedImageLocation();
        }

        private void simpleButtonTemizle_Click(object sender, EventArgs e)
        {
            txteditId.Text = "";
            txteditAd.Text = "";
            txteditSoyad.Text = "";
            txteditNumara.Text = "";
            lookUpEditKulup.Text = "";
            lookUpEditKulup.EditValue = lookUpEditKulup.Properties.GetDataSourceValue("Seçiniz",0);
        }
    }


}

