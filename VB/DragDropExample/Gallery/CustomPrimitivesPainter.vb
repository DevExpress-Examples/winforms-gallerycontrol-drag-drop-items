Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraBars.Styles
Imports DevExpress.XtraBars.ViewInfo
Imports DevExpress.XtraBars.Painters
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace DragDropExample.Gallery
	Public Class CustomPrimitivesPainter
		Inherits PrimitivesPainter
		Public Sub New(ByVal paintStyle As BarManagerPaintStyle)
			MyBase.New(paintStyle)
		End Sub

		Public Overrides Sub DrawGalleryItemDropMark(ByVal g As Graphics, ByVal item As GalleryItemViewInfo, ByVal dropTarget As LinkDropTargetEnum)
			DrawHorizontalDropMark(g, item.Bounds, dropTarget, Color.Orange)
		End Sub

		Public Overrides Sub DrawDropMark(ByVal g As Graphics, ByVal r As Rectangle, ByVal location As DropMarkLocation, ByVal color As Color)
			If location = DropMarkLocation.None Then
				Return
			End If
			Using pen As New Pen(color, 5)
				g.DrawLine(pen, New Point(r.X, r.Y + 3), New Point(r.Right - 1, r.Y + 3))
				g.DrawLine(pen, New Point(r.X, r.Y + 1), New Point(r.X, r.Y + 5))
				g.DrawLine(pen, New Point(r.Right - 1, r.Y + 1), New Point(r.Right - 1, r.Y + 5))
			End Using
		End Sub
	End Class
End Namespace
