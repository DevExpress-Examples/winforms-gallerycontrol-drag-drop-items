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
            this.customGalleryControl1 = new DragDropExample.Gallery.CustomGalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.customGalleryControl2 = new DragDropExample.Gallery.CustomGalleryControl();
            this.galleryControlClient2 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.customGalleryControl1)).BeginInit();
            this.customGalleryControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customGalleryControl2)).BeginInit();
            this.customGalleryControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customGalleryControl1
            // 
            this.customGalleryControl1.AllowDrop = true;
            this.customGalleryControl1.Controls.Add(this.galleryControlClient1);
            this.customGalleryControl1.DesignGalleryGroupIndex = 0;
            this.customGalleryControl1.DesignGalleryItemIndex = 0;
            // 
            // customGalleryControlGallery1
            // 
            galleryItemGroup1.Caption = "Drag&Drop";
            this.customGalleryControl1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.customGalleryControl1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple;
            this.customGalleryControl1.Gallery.ShowItemText = true;
            this.customGalleryControl1.Location = new System.Drawing.Point(13, 13);
            this.customGalleryControl1.Name = "customGalleryControl1";
            this.customGalleryControl1.Size = new System.Drawing.Size(243, 243);
            this.customGalleryControl1.TabIndex = 0;
            this.customGalleryControl1.Text = "customGalleryControl1";
            this.customGalleryControl1.DragOver += new System.Windows.Forms.DragEventHandler(this.OnGalleryControlDragOver);
            this.customGalleryControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnGalleryControlMouseMove);
            this.customGalleryControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnGalleryControlDragDrop);
            this.customGalleryControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnGalleryControlMouseDown);
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.customGalleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(222, 239);
            // 
            // customGalleryControl2
            // 
            this.customGalleryControl2.AllowDrop = true;
            this.customGalleryControl2.Controls.Add(this.galleryControlClient2);
            this.customGalleryControl2.DesignGalleryGroupIndex = 0;
            this.customGalleryControl2.DesignGalleryItemIndex = 0;
            // 
            // customGalleryControlGallery2
            // 
            galleryItemGroup2.Caption = "Drag&Drop";
            this.customGalleryControl2.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup2});
            this.customGalleryControl2.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple;
            this.customGalleryControl2.Gallery.ShowItemText = true;
            this.customGalleryControl2.Location = new System.Drawing.Point(262, 13);
            this.customGalleryControl2.Name = "customGalleryControl2";
            this.customGalleryControl2.Size = new System.Drawing.Size(250, 243);
            this.customGalleryControl2.TabIndex = 1;
            this.customGalleryControl2.Text = "customGalleryControl2";
            this.customGalleryControl2.DragOver += new System.Windows.Forms.DragEventHandler(this.OnGalleryControlDragOver);
            this.customGalleryControl2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnGalleryControlMouseMove);
            this.customGalleryControl2.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnGalleryControlDragDrop);
            this.customGalleryControl2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnGalleryControlMouseDown);
            // 
            // galleryControlClient2
            // 
            this.galleryControlClient2.GalleryControl = this.customGalleryControl2;
            this.galleryControlClient2.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient2.Size = new System.Drawing.Size(229, 239);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 268);
            this.Controls.Add(this.customGalleryControl2);
            this.Controls.Add(this.customGalleryControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.customGalleryControl1)).EndInit();
            this.customGalleryControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customGalleryControl2)).EndInit();
            this.customGalleryControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DragDropExample.Gallery.CustomGalleryControl customGalleryControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DragDropExample.Gallery.CustomGalleryControl customGalleryControl2;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient2;



    }
}

