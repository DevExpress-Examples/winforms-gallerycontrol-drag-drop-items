using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using System.Collections.Generic;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Drawing;
using DragDropExample.Gallery;

namespace DragDropExample {
    public partial class Form1 :Form {
        static int Index;
        RibbonHitInfo DragItemHitInfo;
        GalleryControl DragSource;

        public Form1() {
            InitializeComponent();
            InsertSample(customGalleryControl1.Gallery.Groups[0].Items, 5);
            InsertSample(customGalleryControl2.Gallery.Groups[0].Items, 20);
        }

        static void InsertSample(GalleryItemCollection items, int count) {
            for (int i = 0; i < count; i++) {
                items.Add(new GalleryItem(null, null, string.Concat("DX Sample ", ++Index),
                    string.Concat("The Drag&Drop gallery items example."), -1, -1, null,
                    string.Empty, true, false));
            }
        }

        private void OnGalleryControlMouseDown(object sender, MouseEventArgs e) {
            GalleryControl gallery = (GalleryControl)sender;
            RibbonHitInfo hitInfo = gallery.CalcHitInfo(e.Location);
            if (hitInfo.InGalleryItem && gallery.Gallery.GetCheckedItems().Count > 0) {
                DragItemHitInfo = hitInfo;
                DragSource = gallery;
            } else DragItemHitInfo = null;
        }

        private void OnGalleryControlMouseMove(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Left || ModifierKeys != Keys.None || DragItemHitInfo == null)
                return;
            GalleryControl gallery = (GalleryControl)sender;
            List<GalleryItem> checkedItems = gallery.Gallery.GetCheckedItems();
            if (checkedItems.Count == 0) return;
            if (!new Rectangle(DragItemHitInfo.HitPoint.X - SystemInformation.DragSize.Width / 2,
                DragItemHitInfo.HitPoint.Y - SystemInformation.DragSize.Height / 2,
                SystemInformation.DragSize.Width, SystemInformation.DragSize.Height)
                .Contains(e.Location))
                gallery.DoDragDrop(checkedItems, DragDropEffects.All);
        }

        private void OnGalleryControlDragOver(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(typeof(List<GalleryItem>)))
                e.Effect = DragDropEffects.Move;
            CustomGalleryControl gallery = (CustomGalleryControl)sender;
            gallery.BeginDrag();
            gallery.Invalidate();
        }

        private void OnGalleryControlDragDrop(object sender, DragEventArgs e) {
            if (!e.Data.GetDataPresent(typeof(List<GalleryItem>)) || DragSource == null)
                return;
            CustomGalleryControl dragTarget = (CustomGalleryControl)sender;
            GalleryItemCollection source = DragSource.Gallery.Groups[0].Items;
            GalleryItemCollection target = dragTarget.Gallery.Groups[0].Items;
            int index = target.IndexOf(dragTarget.CalcHitInfo(dragTarget.PointToClient(new Point(e.X, e.Y))).GalleryItem);
            foreach (GalleryItem item in (List<GalleryItem>)e.Data.GetData(typeof(List<GalleryItem>))) {
                source.Remove(item);
                target.Insert(index++, item);
            }
            dragTarget.EndDrag();
        }
    }
}
