Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports System.Collections.Generic
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System.Drawing
Imports DragDropExample.Gallery

Namespace DragDropExample
	Partial Public Class Form1
		Inherits Form
		Private Shared Index As Integer
		Private DragItemHitInfo As RibbonHitInfo
		Private DragSource As GalleryControl

		Public Sub New()
			InitializeComponent()
			InsertSample(customGalleryControl1.Gallery.Groups(0).Items, 5)
			InsertSample(customGalleryControl2.Gallery.Groups(0).Items, 20)
		End Sub

		Private Shared Sub InsertSample(ByVal items As GalleryItemCollection, ByVal count As Integer)
			For i As Integer = 0 To count - 1
				Index += 1
				items.Add(New GalleryItem(Nothing, Nothing, String.Concat("DX Sample ", Index), String.Concat("The Drag&Drop gallery items example."), -1, -1, Nothing, String.Empty, True, False))
			Next i
		End Sub

		Private Sub OnGalleryControlMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles customGalleryControl1.MouseDown, customGalleryControl2.MouseDown
			Dim gallery As GalleryControl = CType(sender, GalleryControl)
			Dim hitInfo As RibbonHitInfo = gallery.CalcHitInfo(e.Location)
			If hitInfo.InGalleryItem AndAlso gallery.Gallery.GetCheckedItems().Count > 0 Then
				DragItemHitInfo = hitInfo
				DragSource = gallery
			Else
				DragItemHitInfo = Nothing
			End If
		End Sub

		Private Sub OnGalleryControlMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles customGalleryControl1.MouseMove, customGalleryControl2.MouseMove
			If e.Button <> MouseButtons.Left OrElse ModifierKeys <> Keys.None OrElse DragItemHitInfo Is Nothing Then
				Return
			End If
			Dim gallery As GalleryControl = CType(sender, GalleryControl)
			Dim checkedItems As List(Of GalleryItem) = gallery.Gallery.GetCheckedItems()
			If checkedItems.Count = 0 Then
				Return
			End If
			If (Not New Rectangle(DragItemHitInfo.HitPoint.X - SystemInformation.DragSize.Width \ 2, DragItemHitInfo.HitPoint.Y - SystemInformation.DragSize.Height \ 2, SystemInformation.DragSize.Width, SystemInformation.DragSize.Height).Contains(e.Location)) Then
				gallery.DoDragDrop(checkedItems, DragDropEffects.All)
			End If
		End Sub

		Private Sub OnGalleryControlDragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles customGalleryControl1.DragOver, customGalleryControl2.DragOver
			If e.Data.GetDataPresent(GetType(List(Of GalleryItem))) Then
				e.Effect = DragDropEffects.Move
			End If
			Dim gallery As CustomGalleryControl = CType(sender, CustomGalleryControl)
			gallery.BeginDrag()
			gallery.Invalidate()
		End Sub

		Private Sub OnGalleryControlDragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles customGalleryControl1.DragDrop, customGalleryControl2.DragDrop
			If (Not e.Data.GetDataPresent(GetType(List(Of GalleryItem)))) OrElse DragSource Is Nothing Then
				Return
			End If
			Dim dragTarget As CustomGalleryControl = CType(sender, CustomGalleryControl)
			Dim source As GalleryItemCollection = DragSource.Gallery.Groups(0).Items
			Dim target As GalleryItemCollection = dragTarget.Gallery.Groups(0).Items
			Dim index As Integer = target.IndexOf(dragTarget.CalcHitInfo(dragTarget.PointToClient(New Point(e.X, e.Y))).GalleryItem)
			For Each item As GalleryItem In CType(e.Data.GetData(GetType(List(Of GalleryItem))), List(Of GalleryItem))
				source.Remove(item)
				target.Insert(index, item)
				index += 1
			Next item
			dragTarget.EndDrag()
		End Sub
	End Class
End Namespace
