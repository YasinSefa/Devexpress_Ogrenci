
namespace DevExpress_Project
{
    partial class FrmAnasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreen = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::DevExpress_Project.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnasayfa));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAnasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnOgrenciler = new DevExpress.XtraBars.BarButtonItem();
            this.btnEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.btnHesapMakinasi = new DevExpress.XtraBars.BarButtonItem();
            this.btnYardim = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreen
            // 
            splashScreen.ClosingDelay = 500;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnAnasayfa,
            this.btnOgrenciler,
            this.btnEkle,
            this.btnSil,
            this.btnGuncelle,
            this.btnHesapMakinasi,
            this.btnYardim});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1324, 150);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Caption = "ANA SAYFA";
            this.btnAnasayfa.Id = 1;
            this.btnAnasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.ImageOptions.Image")));
            this.btnAnasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.ImageOptions.LargeImage")));
            this.btnAnasayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAnasayfa.Name = "btnAnasayfa";
            // 
            // btnOgrenciler
            // 
            this.btnOgrenciler.Caption = "ÖĞRENCİLER";
            this.btnOgrenciler.Id = 2;
            this.btnOgrenciler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOgrenciler.ImageOptions.Image")));
            this.btnOgrenciler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOgrenciler.ImageOptions.LargeImage")));
            this.btnOgrenciler.ItemAppearance.Normal.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnOgrenciler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnOgrenciler.Name = "btnOgrenciler";
            this.btnOgrenciler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOgrenciler_ItemClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Caption = "EKLE";
            this.btnEkle.Id = 3;
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.LargeImage")));
            this.btnEkle.ItemAppearance.Normal.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ItemAppearance.Normal.Options.UseFont = true;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEkle_ItemClick);
            // 
            // btnSil
            // 
            this.btnSil.Caption = "SİL";
            this.btnSil.Id = 4;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.LargeImage")));
            this.btnSil.ItemAppearance.Normal.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnSil.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSil.Name = "btnSil";
            this.btnSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSil_ItemClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Caption = "GÜNCELLE";
            this.btnGuncelle.Id = 5;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.LargeImage")));
            this.btnGuncelle.ItemAppearance.Normal.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.ItemAppearance.Normal.Options.UseFont = true;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuncelle_ItemClick);
            // 
            // btnHesapMakinasi
            // 
            this.btnHesapMakinasi.Caption = "HESAP MAKİNASI";
            this.btnHesapMakinasi.Id = 6;
            this.btnHesapMakinasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapMakinasi.ImageOptions.Image")));
            this.btnHesapMakinasi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHesapMakinasi.ImageOptions.LargeImage")));
            this.btnHesapMakinasi.ItemAppearance.Normal.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnHesapMakinasi.ItemAppearance.Normal.Options.UseFont = true;
            this.btnHesapMakinasi.Name = "btnHesapMakinasi";
            // 
            // btnYardim
            // 
            this.btnYardim.Caption = "YARDIM";
            this.btnYardim.Id = 7;
            this.btnYardim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYardim.ImageOptions.Image")));
            this.btnYardim.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYardim.ImageOptions.LargeImage")));
            this.btnYardim.ItemAppearance.Normal.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnYardim.ItemAppearance.Normal.Options.UseFont = true;
            this.btnYardim.Name = "btnYardim";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ÖĞRENCİ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAnasayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOgrenciler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSil);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGuncelle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHesapMakinasi);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYardim);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 661);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnAnasayfa;
        private DevExpress.XtraBars.BarButtonItem btnOgrenciler;
        private DevExpress.XtraBars.BarButtonItem btnEkle;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraBars.BarButtonItem btnGuncelle;
        private DevExpress.XtraBars.BarButtonItem btnHesapMakinasi;
        private DevExpress.XtraBars.BarButtonItem btnYardim;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

