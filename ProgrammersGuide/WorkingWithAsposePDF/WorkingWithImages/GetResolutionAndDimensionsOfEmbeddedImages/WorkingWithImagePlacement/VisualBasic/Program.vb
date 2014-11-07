'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports System
Imports System.Drawing

Namespace WorkingWithImagePlacement
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")


			' Load the source PDF document
			Dim doc As New Aspose.Pdf.Document(dataDir & "input.pdf")
			Dim abs As New ImagePlacementAbsorber()
			' Load the contents of first page
			doc.Pages(1).Accept(abs)

			For Each imagePlacement As ImagePlacement In abs.ImagePlacements
				' Get image properties
				Console.Out.WriteLine("image width:" & imagePlacement.Rectangle.Width)
				Console.Out.WriteLine("image height:" & imagePlacement.Rectangle.Height)
				Console.Out.WriteLine("image LLX:" & imagePlacement.Rectangle.LLX)
				Console.Out.WriteLine("image LLY:" & imagePlacement.Rectangle.LLY)
				Console.Out.WriteLine("image horizontal resolution:" & imagePlacement.Resolution.X)
				Console.Out.WriteLine("image vertical resolution:" & imagePlacement.Resolution.Y)

				' Retrieve image with visible dimensions
				Dim scaledImage As Bitmap
				Using imageStream As New MemoryStream()
					' Retrieve image from resources
					imagePlacement.Image.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png)
					Dim resourceImage As Bitmap = CType(Bitmap.FromStream(imageStream), Bitmap)
					' Create bitmap with actual dimensions
					scaledImage = New Bitmap(resourceImage, CInt(Fix(imagePlacement.Rectangle.Width)), CInt(Fix(imagePlacement.Rectangle.Height)))
				End Using
			Next imagePlacement

		End Sub
	End Class
End Namespace