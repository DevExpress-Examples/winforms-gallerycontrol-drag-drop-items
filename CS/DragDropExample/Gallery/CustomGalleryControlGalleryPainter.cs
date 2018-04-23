using DevExpress.XtraBars.Ribbon.Drawing;

namespace DragDropExample.Gallery {
    public class CustomGalleryControlGalleryPainter :GalleryControlGalleryPainter {
        protected override GalleryItemGroupPainter CreateGroupPainter() {
            return new CustomGalleryItemGroupPainter();
        }
    }
}
