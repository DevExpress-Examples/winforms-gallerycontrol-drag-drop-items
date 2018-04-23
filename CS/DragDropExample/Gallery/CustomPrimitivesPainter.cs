using System.Drawing;
using DevExpress.XtraBars.Styles;
using DevExpress.XtraBars.ViewInfo;
using DevExpress.XtraBars.Painters;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace DragDropExample.Gallery {
    public class CustomPrimitivesPainter :PrimitivesPainter {
        public CustomPrimitivesPainter(BarManagerPaintStyle paintStyle) : base(paintStyle) { }

        public override void DrawGalleryItemDropMark(Graphics g, GalleryItemViewInfo item, LinkDropTargetEnum dropTarget) {
            DrawHorizontalDropMark(g, item.Bounds, dropTarget, Color.Orange);
        }

        public override void DrawDropMark(Graphics g, Rectangle r, DropMarkLocation location, Color color) {
            if (location == DropMarkLocation.None) return;
            using (Pen pen = new Pen(color, 5)) { 
                g.DrawLine(pen, new Point(r.X, r.Y + 3), new Point(r.Right - 1, r.Y + 3));
                g.DrawLine(pen, new Point(r.X, r.Y + 1), new Point(r.X, r.Y + 5));
                g.DrawLine(pen, new Point(r.Right - 1, r.Y + 1), new Point(r.Right - 1, r.Y + 5));
            }
        }
    }
}
