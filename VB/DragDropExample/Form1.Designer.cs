using DevExpress.XtraBars.Ribbon;
namespace DragDropExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.galleryControl2 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient2 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
            this.galleryControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl2)).BeginInit();
            this.galleryControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // galleryControl1
            // 
            this.galleryControl1.Controls.Add(this.galleryControlClient1);
            this.galleryControl1.DesignGalleryGroupIndex = 0;
            this.galleryControl1.DesignGalleryItemIndex = 0;
            // 
            // galleryControlGallery1
            // 
            galleryItemGroup1.Caption = "Drag&Drop";
            this.galleryControl1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.galleryControl1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple;
            this.galleryControl1.Gallery.ShowItemText = true;
            this.galleryControl1.Location = new System.Drawing.Point(13, 13);
            this.galleryControl1.Name = "galleryControl1";
            this.galleryControl1.Size = new System.Drawing.Size(243, 243);
            this.galleryControl1.TabIndex = 0;
            this.galleryControl1.Text = "customGalleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(222, 239);
            // 
            // galleryControl2
            // 
            this.galleryControl2.Controls.Add(this.galleryControlClient2);
            this.galleryControl2.DesignGalleryGroupIndex = 0;
            this.galleryControl2.DesignGalleryItemIndex = 0;
            // 
            // galleryControlGallery2
            // 
            galleryItemGroup2.Caption = "Drag&Drop";
            this.galleryControl2.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup2});
            this.galleryControl2.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple;
            this.galleryControl2.Gallery.ShowItemText = true;
            this.galleryControl2.Location = new System.Drawing.Point(262, 13);
            this.galleryControl2.Name = "galleryControl2";
            this.galleryControl2.Size = new System.Drawing.Size(250, 243);
            this.galleryControl2.TabIndex = 1;
            this.galleryControl2.Text = "customGalleryControl2";
            // 
            // galleryControlClient2
            // 
            this.galleryControlClient2.GalleryControl = this.galleryControl2;
            this.galleryControlClient2.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient2.Size = new System.Drawing.Size(229, 239);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 268);
            this.Controls.Add(this.galleryControl2);
            this.Controls.Add(this.galleryControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
            this.galleryControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl2)).EndInit();
            this.galleryControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GalleryControl galleryControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private GalleryControl galleryControl2;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient2;



    }
}

