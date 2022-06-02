
namespace DevExpress_Project
{
    partial class FrmOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenci));
            this.txteditAd = new DevExpress.XtraEditors.TextEdit();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            this.txteditNumara = new DevExpress.XtraEditors.TextEdit();
            this.lblNumara = new DevExpress.XtraEditors.LabelControl();
            this.txteditSoyad = new DevExpress.XtraEditors.TextEdit();
            this.lblSoyad = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlOgrenci = new DevExpress.XtraGrid.GridControl();
            this.gridViewOgrenci = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnsYol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnsClub = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnsNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnsSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnsName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnsId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txteditId = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.lookUpEditKulup = new DevExpress.XtraEditors.LookUpEdit();
            this.lblKulup = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txteditAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteditNumara.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteditSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOgrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOgrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteditId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditKulup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txteditAd
            // 
            this.txteditAd.Location = new System.Drawing.Point(117, 115);
            this.txteditAd.Name = "txteditAd";
            this.txteditAd.Properties.Appearance.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txteditAd.Properties.Appearance.Options.UseFont = true;
            this.txteditAd.Size = new System.Drawing.Size(238, 32);
            this.txteditAd.TabIndex = 3;
            this.txteditAd.TextChanged += new System.EventHandler(this.txteditAd_TextChanged);
            // 
            // lblAd
            // 
            this.lblAd.Appearance.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Appearance.Options.UseFont = true;
            this.lblAd.Location = new System.Drawing.Point(72, 118);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(39, 25);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "AD:";
            // 
            // txteditNumara
            // 
            this.txteditNumara.Location = new System.Drawing.Point(117, 199);
            this.txteditNumara.Name = "txteditNumara";
            this.txteditNumara.Properties.Appearance.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txteditNumara.Properties.Appearance.Options.UseFont = true;
            this.txteditNumara.Size = new System.Drawing.Size(238, 32);
            this.txteditNumara.TabIndex = 7;
            this.txteditNumara.TextChanged += new System.EventHandler(this.txteditNumara_TextChanged);
            // 
            // lblNumara
            // 
            this.lblNumara.Appearance.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumara.Appearance.Options.UseFont = true;
            this.lblNumara.Location = new System.Drawing.Point(20, 202);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(91, 25);
            this.lblNumara.TabIndex = 6;
            this.lblNumara.Text = "NUMARA:";
            // 
            // txteditSoyad
            // 
            this.txteditSoyad.Location = new System.Drawing.Point(117, 157);
            this.txteditSoyad.Name = "txteditSoyad";
            this.txteditSoyad.Properties.Appearance.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txteditSoyad.Properties.Appearance.Options.UseFont = true;
            this.txteditSoyad.Size = new System.Drawing.Size(238, 32);
            this.txteditSoyad.TabIndex = 5;
            this.txteditSoyad.TextChanged += new System.EventHandler(this.txteditSoyad_TextChanged);
            // 
            // lblSoyad
            // 
            this.lblSoyad.Appearance.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Appearance.Options.UseFont = true;
            this.lblSoyad.Location = new System.Drawing.Point(33, 160);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(78, 25);
            this.lblSoyad.TabIndex = 4;
            this.lblSoyad.Text = "SOYAD:";
            // 
            // simpleButtonTemizle
            // 
            this.simpleButtonTemizle.Appearance.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonTemizle.Appearance.Options.UseFont = true;
            this.simpleButtonTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButtonTemizle.Location = new System.Drawing.Point(226, 287);
            this.simpleButtonTemizle.Name = "simpleButtonTemizle";
            this.simpleButtonTemizle.Size = new System.Drawing.Size(129, 35);
            this.simpleButtonTemizle.TabIndex = 8;
            this.simpleButtonTemizle.Text = "TEMİZLE";
            this.simpleButtonTemizle.Click += new System.EventHandler(this.simpleButtonTemizle_Click);
            // 
            // gridControlOgrenci
            // 
            this.gridControlOgrenci.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridControlOgrenci.Location = new System.Drawing.Point(2, 12);
            this.gridControlOgrenci.MainView = this.gridViewOgrenci;
            this.gridControlOgrenci.Name = "gridControlOgrenci";
            this.gridControlOgrenci.Size = new System.Drawing.Size(910, 505);
            this.gridControlOgrenci.TabIndex = 0;
            this.gridControlOgrenci.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOgrenci});
            // 
            // gridViewOgrenci
            // 
            this.gridViewOgrenci.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnsYol,
            this.columnsClub,
            this.columnsNumber,
            this.columnsSurname,
            this.columnsName,
            this.columnsId});
            this.gridViewOgrenci.GridControl = this.gridControlOgrenci;
            this.gridViewOgrenci.Name = "gridViewOgrenci";
            this.gridViewOgrenci.OptionsView.ShowGroupPanel = false;
            this.gridViewOgrenci.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewOgrenci_RowCellClick);
            // 
            // columnsYol
            // 
            this.columnsYol.Caption = "Yol";
            this.columnsYol.FieldName = "fotograf";
            this.columnsYol.Name = "columnsYol";
            this.columnsYol.OptionsColumn.AllowEdit = false;
            this.columnsYol.OptionsColumn.ReadOnly = true;
            // 
            // columnsClub
            // 
            this.columnsClub.Caption = "Kulübü";
            this.columnsClub.FieldName = "kulup_ad";
            this.columnsClub.Name = "columnsClub";
            this.columnsClub.OptionsColumn.AllowEdit = false;
            this.columnsClub.OptionsColumn.ReadOnly = true;
            this.columnsClub.Visible = true;
            this.columnsClub.VisibleIndex = 3;
            // 
            // columnsNumber
            // 
            this.columnsNumber.Caption = "Numarası";
            this.columnsNumber.FieldName = "numara";
            this.columnsNumber.Name = "columnsNumber";
            this.columnsNumber.OptionsColumn.AllowEdit = false;
            this.columnsNumber.OptionsColumn.ReadOnly = true;
            this.columnsNumber.Visible = true;
            this.columnsNumber.VisibleIndex = 2;
            // 
            // columnsSurname
            // 
            this.columnsSurname.Caption = "Soyadı";
            this.columnsSurname.FieldName = "soyad";
            this.columnsSurname.Name = "columnsSurname";
            this.columnsSurname.OptionsColumn.AllowEdit = false;
            this.columnsSurname.OptionsColumn.ReadOnly = true;
            this.columnsSurname.Visible = true;
            this.columnsSurname.VisibleIndex = 1;
            // 
            // columnsName
            // 
            this.columnsName.Caption = "Adı";
            this.columnsName.FieldName = "ad";
            this.columnsName.Name = "columnsName";
            this.columnsName.OptionsColumn.AllowEdit = false;
            this.columnsName.OptionsColumn.ReadOnly = true;
            this.columnsName.Visible = true;
            this.columnsName.VisibleIndex = 0;
            // 
            // columnsId
            // 
            this.columnsId.Caption = "Id";
            this.columnsId.FieldName = "id";
            this.columnsId.Name = "columnsId";
            this.columnsId.OptionsColumn.AllowEdit = false;
            this.columnsId.OptionsColumn.ReadOnly = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txteditId);
            this.groupControl1.Controls.Add(this.pictureEdit);
            this.groupControl1.Controls.Add(this.lookUpEditKulup);
            this.groupControl1.Controls.Add(this.lblKulup);
            this.groupControl1.Controls.Add(this.simpleButtonTemizle);
            this.groupControl1.Controls.Add(this.lblAd);
            this.groupControl1.Controls.Add(this.txteditNumara);
            this.groupControl1.Controls.Add(this.txteditAd);
            this.groupControl1.Controls.Add(this.lblNumara);
            this.groupControl1.Controls.Add(this.lblSoyad);
            this.groupControl1.Controls.Add(this.txteditSoyad);
            this.groupControl1.Location = new System.Drawing.Point(918, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(406, 505);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "groupControl1";
            // 
            // txteditId
            // 
            this.txteditId.Location = new System.Drawing.Point(117, 89);
            this.txteditId.Name = "txteditId";
            this.txteditId.Size = new System.Drawing.Size(100, 20);
            this.txteditId.TabIndex = 15;
            this.txteditId.Visible = false;
            this.txteditId.EditValueChanged += new System.EventHandler(this.txteditId_EditValueChanged);
            // 
            // pictureEdit
            // 
            this.pictureEdit.Location = new System.Drawing.Point(81, 333);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit.Size = new System.Drawing.Size(274, 144);
            this.pictureEdit.TabIndex = 14;
            this.pictureEdit.EditValueChanged += new System.EventHandler(this.pictureEdit_EditValueChanged);
            // 
            // lookUpEditKulup
            // 
            this.lookUpEditKulup.Location = new System.Drawing.Point(117, 241);
            this.lookUpEditKulup.Name = "lookUpEditKulup";
            this.lookUpEditKulup.Properties.Appearance.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold);
            this.lookUpEditKulup.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditKulup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditKulup.Properties.NullText = "Seçiniz";
            this.lookUpEditKulup.Size = new System.Drawing.Size(238, 32);
            this.lookUpEditKulup.TabIndex = 11;
            this.lookUpEditKulup.EditValueChanged += new System.EventHandler(this.lookUpEditKulup_EditValueChanged);
            // 
            // lblKulup
            // 
            this.lblKulup.Appearance.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKulup.Appearance.Options.UseFont = true;
            this.lblKulup.Location = new System.Drawing.Point(33, 244);
            this.lblKulup.Name = "lblKulup";
            this.lblKulup.Size = new System.Drawing.Size(78, 25);
            this.lblKulup.TabIndex = 10;
            this.lblKulup.Text = "KULÜP:";
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 511);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControlOgrenci);
            this.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmOgrenci";
            this.Text = "FrmOgrenci";
            this.Load += new System.EventHandler(this.FrmOgrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txteditAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteditNumara.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteditSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOgrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOgrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteditId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditKulup.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txteditAd;
        private DevExpress.XtraEditors.LabelControl lblAd;
        private DevExpress.XtraEditors.TextEdit txteditNumara;
        private DevExpress.XtraEditors.LabelControl lblNumara;
        private DevExpress.XtraEditors.TextEdit txteditSoyad;
        private DevExpress.XtraEditors.LabelControl lblSoyad;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTemizle;
        private DevExpress.XtraGrid.GridControl gridControlOgrenci;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOgrenci;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblKulup;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditKulup;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.XtraGrid.Columns.GridColumn columnsId;
        private DevExpress.XtraGrid.Columns.GridColumn columnsName;
        private DevExpress.XtraGrid.Columns.GridColumn columnsClub;
        private DevExpress.XtraGrid.Columns.GridColumn columnsNumber;
        private DevExpress.XtraGrid.Columns.GridColumn columnsSurname;
        private DevExpress.XtraEditors.TextEdit txteditId;
        private DevExpress.XtraGrid.Columns.GridColumn columnsYol;
    }
}