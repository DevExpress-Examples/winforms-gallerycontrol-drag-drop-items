using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.ViewInfo;
using DevExpress.XtraBars.Ribbon.Drawing;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace DragDropExample.Gallery {
    public class CustomGalleryItemGroupPainter :GalleryControlItemGroupPainter {
        public override void Draw(GraphicsCache cache, GalleryItemGroupViewInfo viewInfo, ImageGalleryInfoArgs gi) {
            base.Draw(cache, viewInfo, gi);
            CustomGalleryControl galleryControl = (CustomGalleryControl)((GalleryControlGallery)viewInfo.Gallery).GalleryControl;
            Point mousePosition = galleryControl.PointToClient(Control.MousePosition);
            if (!galleryControl.IsDragDrop) return;
            foreach (GalleryItemViewInfo itemViewInfo in viewInfo.Items)
                if (itemViewInfo.Bounds.Contains(mousePosition))
                    new CustomPrimitivesPainter(galleryControl.GetController().PaintStyle)
                        .DrawGalleryItemDropMark(cache.Graphics, itemViewInfo, LinkDropTargetEnum.Before);
        }
    }
}
