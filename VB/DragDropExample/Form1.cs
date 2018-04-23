using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using System.Collections.Generic;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Drawing;
using System.Diagnostics;

namespace DragDropExample {
    public partial class Form1 :Form {
        
        static int Index;
        DragDropHelper dragDropHelper;

        public Form1() {
            InitializeComponent();
            InsertSample(galleryControl1.Gallery.Groups[0].Items, 5);
            InsertSample(galleryControl2.Gallery.Groups[0].Items, 20);

            dragDropHelper = new DragDropHelper(galleryControl1, galleryControl2);
            dragDropHelper.EnableDragDrop();
        }

        static void InsertSample(GalleryItemCollection items, int count) {
            for (int i = 0; i < count; i++) {
                items.Add(new GalleryItem(null, null, string.Concat("DX Sample ", ++Index),
                    string.Concat("The Drag&Drop gallery items example."), -1, -1, null,
                    string.Empty, true, false));
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            dragDropHelper.DisableDragDrop();
        }
    }
}