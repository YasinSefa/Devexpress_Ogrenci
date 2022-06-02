
namespace DevExpress_Project
{
    partial class SplashScreen1
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
            this.labelCopyright = new DevExpress.XtraEditors.LabelControl();
            this.labelStatus = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.peImage = new DevExpress.XtraEditors.PictureEdit();
            this.peLogo = new DevExpress.XtraEditors.PictureEdit();
            this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCopyright
            // 
            this.labelCopyright.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCopyright.Appearance.Options.UseFont = true;
            this.labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelCopyright.Location = new System.Drawing.Point(24, 287);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(71, 13);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = "2022 © AXOY";
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(24, 215);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(50, 13);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Starting...";
            // 
            // peImage
            // 
            this.peImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.peImage.EditValue = global::DevExpress_Project.Properties.Resources.University;
            this.peImage.Location = new System.Drawing.Point(1, 1);
            this.peImage.Name = "peImage";
            this.peImage.Properties.AllowFocused = false;
            this.peImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peImage.Properties.Appearance.Options.UseBackColor = true;
            this.peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peImage.Properties.ShowMenu = false;
            this.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peImage.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.peImage.Size = new System.Drawing.Size(448, 200);
            this.peImage.TabIndex = 9;
            // 
            // peLogo
            // 
            this.peLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peLogo.EditValue = global::DevExpress_Project.Properties.Resources.Logo;
            this.peLogo.Location = new System.Drawing.Point(335, 250);
            this.peLogo.Name = "peLogo";
            this.peLogo.Properties.AllowFocused = false;
            this.peLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peLogo.Properties.Appearance.Options.UseBackColor = true;
            this.peLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peLogo.Properties.ShowMenu = false;
            this.peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peLogo.Size = new System.Drawing.Size(102, 66);
            this.peLogo.TabIndex = 8;
            // 
            // progressBarControl
            // 
            this.progressBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl.EditValue = 0;
            this.progressBarControl.Location = new System.Drawing.Point(25, 232);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Size = new System.Drawing.Size(402, 12);
            this.progressBarControl.TabIndex = 5;
            this.progressBarControl.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            // 
            // SplashScreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.peImage);
            this.Controls.Add(this.peLogo);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.progressBarControl);
            this.Name = "SplashScreen1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "SplashScreen1";
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
        private DevExpress.XtraEditors.LabelControl labelCopyright;
        private DevExpress.XtraEditors.LabelControl labelStatus;
        private DevExpress.XtraEditors.PictureEdit peImage;
        private DevExpress.XtraEditors.PictureEdit peLogo;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
