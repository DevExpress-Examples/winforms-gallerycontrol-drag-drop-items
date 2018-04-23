Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports System.Collections.Generic
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System.Drawing
Imports System.Diagnostics

Namespace DragDropExample
	Partial Public Class Form1
		Inherits Form

		Private Shared Index As Integer
		Private dragDropHelper As DragDropHelper

		Public Sub New()
			InitializeComponent()
			InsertSample(galleryControl1.Gallery.Groups(0).Items, 5)
			InsertSample(galleryControl2.Gallery.Groups(0).Items, 20)

			dragDropHelper = New DragDropHelper(galleryControl1, galleryControl2)
			dragDropHelper.EnableDragDrop()
		End Sub

		Private Shared Sub InsertSample(ByVal items As GalleryItemCollection, ByVal count As Integer)
			For i As Integer = 0 To count - 1
				Index += 1
				items.Add(New GalleryItem(Nothing, Nothing, String.Concat("DX Sample ", Index), String.Concat("The Drag&Drop gallery items example."), -1, -1, Nothing, String.Empty, True, False))
			Next i
		End Sub

		Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
			MyBase.OnFormClosing(e)
			dragDropHelper.DisableDragDrop()
		End Sub
	End Class
End Namespace