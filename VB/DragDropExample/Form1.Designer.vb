Imports Microsoft.VisualBasic
Imports System
Namespace DragDropExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItemGroup2 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Me.customGalleryControl1 = New DragDropExample.Gallery.CustomGalleryControl()
			Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
			Me.customGalleryControl2 = New DragDropExample.Gallery.CustomGalleryControl()
			Me.galleryControlClient2 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
			CType(Me.customGalleryControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.customGalleryControl1.SuspendLayout()
			CType(Me.customGalleryControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.customGalleryControl2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' customGalleryControl1
			' 
			Me.customGalleryControl1.AllowDrop = True
			Me.customGalleryControl1.Controls.Add(Me.galleryControlClient1)
			Me.customGalleryControl1.DesignGalleryGroupIndex = 0
			Me.customGalleryControl1.DesignGalleryItemIndex = 0
			' 
			' customGalleryControlGallery1
			' 
			galleryItemGroup1.Caption = "Drag&Drop"
			Me.customGalleryControl1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
			Me.customGalleryControl1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple
			Me.customGalleryControl1.Gallery.ShowItemText = True
			Me.customGalleryControl1.Location = New System.Drawing.Point(13, 13)
			Me.customGalleryControl1.Name = "customGalleryControl1"
			Me.customGalleryControl1.Size = New System.Drawing.Size(243, 243)
			Me.customGalleryControl1.TabIndex = 0
			Me.customGalleryControl1.Text = "customGalleryControl1"
'			Me.customGalleryControl1.DragOver += New System.Windows.Forms.DragEventHandler(Me.OnGalleryControlDragOver);
'			Me.customGalleryControl1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.OnGalleryControlMouseMove);
'			Me.customGalleryControl1.DragDrop += New System.Windows.Forms.DragEventHandler(Me.OnGalleryControlDragDrop);
'			Me.customGalleryControl1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.OnGalleryControlMouseDown);
			' 
			' galleryControlClient1
			' 
			Me.galleryControlClient1.GalleryControl = Me.customGalleryControl1
			Me.galleryControlClient1.Location = New System.Drawing.Point(2, 2)
			Me.galleryControlClient1.Size = New System.Drawing.Size(222, 239)
			' 
			' customGalleryControl2
			' 
			Me.customGalleryControl2.AllowDrop = True
			Me.customGalleryControl2.Controls.Add(Me.galleryControlClient2)
			Me.customGalleryControl2.DesignGalleryGroupIndex = 0
			Me.customGalleryControl2.DesignGalleryItemIndex = 0
			' 
			' customGalleryControlGallery2
			' 
			galleryItemGroup2.Caption = "Drag&Drop"
			Me.customGalleryControl2.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup2})
			Me.customGalleryControl2.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple
			Me.customGalleryControl2.Gallery.ShowItemText = True
			Me.customGalleryControl2.Location = New System.Drawing.Point(262, 13)
			Me.customGalleryControl2.Name = "customGalleryControl2"
			Me.customGalleryControl2.Size = New System.Drawing.Size(250, 243)
			Me.customGalleryControl2.TabIndex = 1
			Me.customGalleryControl2.Text = "customGalleryControl2"
'			Me.customGalleryControl2.DragOver += New System.Windows.Forms.DragEventHandler(Me.OnGalleryControlDragOver);
'			Me.customGalleryControl2.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.OnGalleryControlMouseMove);
'			Me.customGalleryControl2.DragDrop += New System.Windows.Forms.DragEventHandler(Me.OnGalleryControlDragDrop);
'			Me.customGalleryControl2.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.OnGalleryControlMouseDown);
			' 
			' galleryControlClient2
			' 
			Me.galleryControlClient2.GalleryControl = Me.customGalleryControl2
			Me.galleryControlClient2.Location = New System.Drawing.Point(2, 2)
			Me.galleryControlClient2.Size = New System.Drawing.Size(229, 239)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(522, 268)
			Me.Controls.Add(Me.customGalleryControl2)
			Me.Controls.Add(Me.customGalleryControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.customGalleryControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.customGalleryControl1.ResumeLayout(False)
			CType(Me.customGalleryControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.customGalleryControl2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents customGalleryControl1 As DragDropExample.Gallery.CustomGalleryControl
		Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
		Private WithEvents customGalleryControl2 As DragDropExample.Gallery.CustomGalleryControl
		Private galleryControlClient2 As DevExpress.XtraBars.Ribbon.GalleryControlClient



	End Class
End Namespace

