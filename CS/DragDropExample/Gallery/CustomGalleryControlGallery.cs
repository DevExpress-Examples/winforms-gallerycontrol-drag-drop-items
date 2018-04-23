using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Drawing;
using DevExpress.XtraBars.Ribbon.Gallery;

namespace DragDropExample.Gallery {
    public class CustomGalleryControlGallery :GalleryControlGallery {
        public CustomGalleryControlGallery(GalleryControl galleryControl) : base(galleryControl) { }

        protected override GalleryControlPainter CreatePainter() {
            return new CustomGalleryControlGalleryPainter();
        }
    }
}
