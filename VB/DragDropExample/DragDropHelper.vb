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
	Public Class DragDropHelper
		Private galleryControl1, galleryControl2, DragSource As GalleryControl
		Private _SelectedPen As New Pen(Color.Indigo, 3)
		Private targetHighlightItem As GalleryItem
		Private DragItemHitInfo As RibbonHitInfo

		Public Sub New(ByVal galleryControl1 As GalleryControl, ByVal galleryControl2 As GalleryControl)
			Me.galleryControl1 = galleryControl1
			Me.galleryControl2 = galleryControl2
		End Sub

		Public Property SelectedPen() As Pen
			Get
				Return _SelectedPen
			End Get
			Set(ByVal value As Pen)
				_SelectedPen = value
			End Set
		End Property

		Public Sub EnableDragDrop()
			galleryControl2.AllowDrop = True
			galleryControl1.AllowDrop = galleryControl2.AllowDrop
			AddHandler galleryControl1.MouseDown, AddressOf OnGalleryControlMouseDown
			AddHandler galleryControl2.MouseDown, AddressOf OnGalleryControlMouseDown
			AddHandler galleryControl1.MouseMove, AddressOf OnGalleryControlMouseMove
			AddHandler galleryControl2.MouseMove, AddressOf OnGalleryControlMouseMove
			AddHandler galleryControl1.DragOver, AddressOf OnGalleryControlDragOver
			AddHandler galleryControl2.DragOver, AddressOf OnGalleryControlDragOver
			AddHandler galleryControl1.DragDrop, AddressOf OnGalleryControlDragDrop
			AddHandler galleryControl2.DragDrop, AddressOf OnGalleryControlDragDrop
			AddHandler galleryControl1.Gallery.CustomDrawItemText, AddressOf OnCustomDrawItemText
			AddHandler galleryControl2.Gallery.CustomDrawItemText, AddressOf OnCustomDrawItemText
		End Sub

		Private Sub OnGalleryControlMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim gallery As GalleryControl = CType(sender, GalleryControl)
			Dim hitInfo As RibbonHitInfo = gallery.CalcHitInfo(e.Location)
			If hitInfo.InGalleryItem Then
				DragItemHitInfo = hitInfo
				DragSource = gallery
			Else
				DragItemHitInfo = Nothing
			End If
		End Sub

		Private Sub OnGalleryControlMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			If e.Button <> MouseButtons.Left OrElse Control.ModifierKeys <> Keys.None OrElse DragItemHitInfo Is Nothing Then
				Return
			End If
			Dim gallery As GalleryControl = CType(sender, GalleryControl)
			Dim checkedItems As List(Of GalleryItem) = gallery.Gallery.GetCheckedItems()
			If checkedItems.Count = 0 Then
				checkedItems.Add(DragItemHitInfo.GalleryItem)
			End If
			If (Not New Rectangle(DragItemHitInfo.HitPoint.X - SystemInformation.DragSize.Width / 2, DragItemHitInfo.HitPoint.Y - SystemInformation.DragSize.Height / 2, SystemInformation.DragSize.Width, SystemInformation.DragSize.Height).Contains(e.Location)) Then
				gallery.DoDragDrop(checkedItems, DragDropEffects.All)
			End If
		End Sub

		Private Sub OnGalleryControlDragOver(ByVal sender As Object, ByVal e As DragEventArgs)
			If e.Data.GetDataPresent(GetType(List(Of GalleryItem))) Then
				e.Effect = DragDropEffects.Move
			End If
			Dim gallery As GalleryControl = CType(sender, GalleryControl)

			Dim hitInfo As RibbonHitInfo = gallery.CalcHitInfo(gallery.PointToClient(New Point(e.X, e.Y)))
			targetHighlightItem = hitInfo.GalleryItem
			gallery.Invalidate()
		End Sub

		Private Sub OnGalleryControlDragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
			If (Not e.Data.GetDataPresent(GetType(List(Of GalleryItem)))) OrElse DragSource Is Nothing Then
				Return
			End If
			Dim dragTarget As GalleryControl = CType(sender, GalleryControl)
			Dim hitInfo As RibbonHitInfo = dragTarget.CalcHitInfo(dragTarget.PointToClient(New Point(e.X, e.Y)))
			Dim targetItem As GalleryItem = hitInfo.GalleryItem
			If targetItem IsNot Nothing Then
				Dim target As GalleryItemCollection = targetItem.GalleryGroup.Items
				Dim index As Integer = target.IndexOf(targetItem)
				Dim draggedItems As List(Of GalleryItem) = CType(e.Data.GetData(GetType(List(Of GalleryItem))), List(Of GalleryItem))
				For Each item As GalleryItem In draggedItems
					Dim source As GalleryItemCollection = item.GalleryGroup.Items
					source.Remove(item)
					target.Insert(index, item)
					index += 1
				Next item
			End If
			targetHighlightItem = Nothing
		End Sub

		Private Sub OnCustomDrawItemText(ByVal sender As Object, ByVal e As GalleryItemCustomDrawEventArgs)
            If e.Item.Equals(targetHighlightItem) Then
                Dim newPoint As New Point(e.Bounds.X, e.Bounds.Bottom)
                e.Cache.Graphics.DrawLine(SelectedPen, newPoint, New Point(e.Bounds.Right, e.Bounds.Bottom))
            End If
		End Sub

		Public Sub DisableDragDrop()
			galleryControl2.AllowDrop = True
			galleryControl1.AllowDrop = galleryControl2.AllowDrop
			RemoveHandler galleryControl1.MouseDown, AddressOf OnGalleryControlMouseDown
			RemoveHandler galleryControl2.MouseDown, AddressOf OnGalleryControlMouseDown
			RemoveHandler galleryControl1.MouseMove, AddressOf OnGalleryControlMouseMove
			RemoveHandler galleryControl2.MouseMove, AddressOf OnGalleryControlMouseMove
			RemoveHandler galleryControl1.DragOver, AddressOf OnGalleryControlDragOver
			RemoveHandler galleryControl2.DragOver, AddressOf OnGalleryControlDragOver
			RemoveHandler galleryControl1.DragDrop, AddressOf OnGalleryControlDragDrop
			RemoveHandler galleryControl2.DragDrop, AddressOf OnGalleryControlDragDrop
			RemoveHandler galleryControl1.Gallery.CustomDrawItemText, AddressOf OnCustomDrawItemText
			RemoveHandler galleryControl2.Gallery.CustomDrawItemText, AddressOf OnCustomDrawItemText
		End Sub
	End Class
End Namespace
