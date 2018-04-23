Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery

Namespace DragDropExample.Gallery
	Public Class CustomGalleryControl
		Inherits GalleryControl
		Private fIsDragDrop As Boolean
		Friend ReadOnly Property IsDragDrop() As Boolean
			Get
				Return fIsDragDrop
			End Get
		End Property

		Public Sub BeginDrag()
			fIsDragDrop = True
		End Sub

		Public Sub EndDrag()
			fIsDragDrop = False
		End Sub

		Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
			MyBase.OnMouseLeave(e)
			EndDrag()
		End Sub

		Protected Overrides Function CreateGallery() As GalleryControlGallery
			Return New CustomGalleryControlGallery(Me)
		End Function
	End Class
End Namespace
