Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Ribbon.Drawing

Namespace DragDropExample.Gallery
	Public Class CustomGalleryControlGalleryPainter
		Inherits GalleryControlGalleryPainter
		Protected Overrides Function CreateGroupPainter() As GalleryItemGroupPainter
			Return New CustomGalleryItemGroupPainter()
		End Function
	End Class
End Namespace
