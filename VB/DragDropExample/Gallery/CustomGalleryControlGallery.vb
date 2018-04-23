Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Drawing
Imports DevExpress.XtraBars.Ribbon.Gallery

Namespace DragDropExample.Gallery
	Public Class CustomGalleryControlGallery
		Inherits GalleryControlGallery
		Public Sub New(ByVal galleryControl As GalleryControl)
			MyBase.New(galleryControl)
		End Sub

		Protected Overrides Function CreatePainter() As GalleryControlPainter
			Return New CustomGalleryControlGalleryPainter()
		End Function
	End Class
End Namespace
