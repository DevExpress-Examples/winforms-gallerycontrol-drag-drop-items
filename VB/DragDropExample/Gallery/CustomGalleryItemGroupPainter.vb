Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars.ViewInfo
Imports DevExpress.XtraBars.Ribbon.Drawing
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace DragDropExample.Gallery
	Public Class CustomGalleryItemGroupPainter
		Inherits GalleryControlItemGroupPainter
		Public Overrides Sub Draw(ByVal cache As GraphicsCache, ByVal viewInfo As GalleryItemGroupViewInfo, ByVal gi As ImageGalleryInfoArgs)
			MyBase.Draw(cache, viewInfo, gi)
			Dim galleryControl As CustomGalleryControl = CType((CType(viewInfo.Gallery, GalleryControlGallery)).GalleryControl, CustomGalleryControl)
			Dim mousePosition As Point = galleryControl.PointToClient(Control.MousePosition)
			If (Not galleryControl.IsDragDrop) Then
				Return
			End If
			For Each itemViewInfo As GalleryItemViewInfo In viewInfo.Items
				If itemViewInfo.Bounds.Contains(mousePosition) Then
					CType(New CustomPrimitivesPainter(galleryControl.GetController().PaintStyle), CustomPrimitivesPainter).DrawGalleryItemDropMark(cache.Graphics, itemViewInfo, LinkDropTargetEnum.Before)
				End If
			Next itemViewInfo
		End Sub
	End Class
End Namespace
