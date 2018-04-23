using System;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;

namespace DragDropExample.Gallery {
    public class CustomGalleryControl :GalleryControl {
        bool fIsDragDrop;
        internal bool IsDragDrop {
            get { return fIsDragDrop; }
        }

        public void BeginDrag() {
            fIsDragDrop = true;
        }

        public void EndDrag() {
            fIsDragDrop = false;
        }

        protected override void OnMouseLeave(EventArgs e) {
            base.OnMouseLeave(e);
            EndDrag();
        }

        protected override GalleryControlGallery CreateGallery() {
            return new CustomGalleryControlGallery(this);
        }
    }
}
