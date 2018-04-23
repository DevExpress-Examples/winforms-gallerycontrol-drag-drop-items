using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using System.Collections.Generic;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Drawing;
using System.Diagnostics;

namespace DragDropExample
{
    public class DragDropHelper
    {
        GalleryControl galleryControl1, galleryControl2, DragSource;
        private Pen _SelectedPen = new Pen(Color.Indigo, 3);
        private GalleryItem targetHighlightItem;
        RibbonHitInfo DragItemHitInfo;

        public DragDropHelper(GalleryControl galleryControl1, GalleryControl galleryControl2)
        {
            this.galleryControl1 = galleryControl1;
            this.galleryControl2 = galleryControl2;
        }

        public Pen SelectedPen
        {
            get { return _SelectedPen; }
            set { _SelectedPen = value; }
        }

        public void EnableDragDrop()
        {
            galleryControl1.AllowDrop = galleryControl2.AllowDrop = true;
            galleryControl1.MouseDown += OnGalleryControlMouseDown;
            galleryControl2.MouseDown += OnGalleryControlMouseDown;
            galleryControl1.MouseMove += OnGalleryControlMouseMove;
            galleryControl2.MouseMove += OnGalleryControlMouseMove;
            galleryControl1.DragOver += OnGalleryControlDragOver;
            galleryControl2.DragOver += OnGalleryControlDragOver;
            galleryControl1.DragDrop += OnGalleryControlDragDrop;
            galleryControl2.DragDrop += OnGalleryControlDragDrop;
            galleryControl1.Gallery.CustomDrawItemText += OnCustomDrawItemText;
            galleryControl2.Gallery.CustomDrawItemText += OnCustomDrawItemText;
        }

        private void OnGalleryControlMouseDown(object sender, MouseEventArgs e)
        {
            GalleryControl gallery = (GalleryControl)sender;
            RibbonHitInfo hitInfo = gallery.CalcHitInfo(e.Location);
            if (hitInfo.InGalleryItem)
            {
                DragItemHitInfo = hitInfo;
                DragSource = gallery;
            }
            else DragItemHitInfo = null;
        }

        private void OnGalleryControlMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || Control.ModifierKeys != Keys.None || DragItemHitInfo == null)
                return;
            GalleryControl gallery = (GalleryControl)sender;
            List<GalleryItem> checkedItems = gallery.Gallery.GetCheckedItems();
            if (checkedItems.Count == 0)
                checkedItems.Add(DragItemHitInfo.GalleryItem);
            if (!new Rectangle(DragItemHitInfo.HitPoint.X - SystemInformation.DragSize.Width / 2,
                DragItemHitInfo.HitPoint.Y - SystemInformation.DragSize.Height / 2,
                SystemInformation.DragSize.Width, SystemInformation.DragSize.Height)
                .Contains(e.Location))
                gallery.DoDragDrop(checkedItems, DragDropEffects.All);
        }

        private void OnGalleryControlDragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<GalleryItem>)))
                e.Effect = DragDropEffects.Move;
            GalleryControl gallery = (GalleryControl)sender;

            RibbonHitInfo hitInfo = gallery.CalcHitInfo(gallery.PointToClient(new Point(e.X, e.Y)));
            targetHighlightItem = hitInfo.GalleryItem;
            gallery.Invalidate();
        }

        private void OnGalleryControlDragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(List<GalleryItem>)) || DragSource == null)
                return;
            GalleryControl dragTarget = (GalleryControl)sender;
            RibbonHitInfo hitInfo = dragTarget.CalcHitInfo(dragTarget.PointToClient(new Point(e.X, e.Y)));
            GalleryItem targetItem = hitInfo.GalleryItem;
            if (targetItem != null)
            {
                GalleryItemCollection target = targetItem.GalleryGroup.Items;
                int index = target.IndexOf(targetItem);
                List<GalleryItem> draggedItems = (List<GalleryItem>)e.Data.GetData(typeof(List<GalleryItem>));
                foreach (GalleryItem item in draggedItems)
                {
                    GalleryItemCollection source = item.GalleryGroup.Items;
                    source.Remove(item);
                    target.Insert(index++, item);
                }
            }
            targetHighlightItem = null;
        }

        private void OnCustomDrawItemText(object sender, GalleryItemCustomDrawEventArgs e)
        {
            if (e.Item == targetHighlightItem)
            {
                Point newPoint = new Point(e.Bounds.X, e.Bounds.Bottom);
                e.Cache.Graphics.DrawLine(SelectedPen,
                    newPoint,
                    new Point(e.Bounds.Right, e.Bounds.Bottom));
            }
        }

        public void DisableDragDrop()
        {
            galleryControl1.AllowDrop = galleryControl2.AllowDrop = true;
            galleryControl1.MouseDown -= OnGalleryControlMouseDown;
            galleryControl2.MouseDown -= OnGalleryControlMouseDown;
            galleryControl1.MouseMove -= OnGalleryControlMouseMove;
            galleryControl2.MouseMove -= OnGalleryControlMouseMove;
            galleryControl1.DragOver -= OnGalleryControlDragOver;
            galleryControl2.DragOver -= OnGalleryControlDragOver;
            galleryControl1.DragDrop -= OnGalleryControlDragDrop;
            galleryControl2.DragDrop -= OnGalleryControlDragDrop;
            galleryControl1.Gallery.CustomDrawItemText -= OnCustomDrawItemText;
            galleryControl2.Gallery.CustomDrawItemText -= OnCustomDrawItemText;
        }
    }
}
