Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Ribbon
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
			Me.galleryControl1 = New DevExpress.XtraBars.Ribbon.GalleryControl()
			Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
			Me.galleryControl2 = New DevExpress.XtraBars.Ribbon.GalleryControl()
			Me.galleryControlClient2 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
			CType(Me.galleryControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.galleryControl1.SuspendLayout()
			CType(Me.galleryControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.galleryControl2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' galleryControl1
			' 
			Me.galleryControl1.Controls.Add(Me.galleryControlClient1)
			Me.galleryControl1.DesignGalleryGroupIndex = 0
			Me.galleryControl1.DesignGalleryItemIndex = 0
			' 
			' galleryControlGallery1
			' 
			galleryItemGroup1.Caption = "Drag&Drop"
			Me.galleryControl1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
			Me.galleryControl1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple
			Me.galleryControl1.Gallery.ShowItemText = True
			Me.galleryControl1.Location = New System.Drawing.Point(13, 13)
			Me.galleryControl1.Name = "galleryControl1"
			Me.galleryControl1.Size = New System.Drawing.Size(243, 243)
			Me.galleryControl1.TabIndex = 0
			Me.galleryControl1.Text = "customGalleryControl1"
			' 
			' galleryControlClient1
			' 
			Me.galleryControlClient1.GalleryControl = Me.galleryControl1
			Me.galleryControlClient1.Location = New System.Drawing.Point(2, 2)
			Me.galleryControlClient1.Size = New System.Drawing.Size(222, 239)
			' 
			' galleryControl2
			' 
			Me.galleryControl2.Controls.Add(Me.galleryControlClient2)
			Me.galleryControl2.DesignGalleryGroupIndex = 0
			Me.galleryControl2.DesignGalleryItemIndex = 0
			' 
			' galleryControlGallery2
			' 
			galleryItemGroup2.Caption = "Drag&Drop"
			Me.galleryControl2.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup2})
			Me.galleryControl2.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple
			Me.galleryControl2.Gallery.ShowItemText = True
			Me.galleryControl2.Location = New System.Drawing.Point(262, 13)
			Me.galleryControl2.Name = "galleryControl2"
			Me.galleryControl2.Size = New System.Drawing.Size(250, 243)
			Me.galleryControl2.TabIndex = 1
			Me.galleryControl2.Text = "customGalleryControl2"
			' 
			' galleryControlClient2
			' 
			Me.galleryControlClient2.GalleryControl = Me.galleryControl2
			Me.galleryControlClient2.Location = New System.Drawing.Point(2, 2)
			Me.galleryControlClient2.Size = New System.Drawing.Size(229, 239)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(522, 268)
			Me.Controls.Add(Me.galleryControl2)
			Me.Controls.Add(Me.galleryControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.galleryControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.galleryControl1.ResumeLayout(False)
			CType(Me.galleryControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.galleryControl2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private galleryControl1 As GalleryControl
		Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
		Private galleryControl2 As GalleryControl
		Private galleryControlClient2 As DevExpress.XtraBars.Ribbon.GalleryControlClient



	End Class
End Namespace

