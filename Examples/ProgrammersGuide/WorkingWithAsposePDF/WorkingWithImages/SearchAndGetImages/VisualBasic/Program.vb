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

Namespace SearchAndGetImages
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Open document
			Dim doc As New Aspose.Pdf.Document(dataDir & "input.pdf")

			' Create ImagePlacementAbsorber object to perform image placement search
			Dim abs As New ImagePlacementAbsorber()

			' Accept the absorber for all the pages
			doc.Pages.Accept(abs)

			'Loop through all ImagePlacements, get image and ImagePlacement Properties
			For Each imagePlacement As ImagePlacement In abs.ImagePlacements
				'Get the image using ImagePlacement object
				Dim image As XImage = imagePlacement.Image

				'Display image placement properties for all placements
				Console.Out.WriteLine("image width:" & imagePlacement.Rectangle.Width)
				Console.Out.WriteLine("image height:" & imagePlacement.Rectangle.Height)
				Console.Out.WriteLine("image LLX:" & imagePlacement.Rectangle.LLX)
				Console.Out.WriteLine("image LLY:" & imagePlacement.Rectangle.LLY)
				Console.Out.WriteLine("image horizontal resolution:" & imagePlacement.Resolution.X)
				Console.Out.WriteLine("image vertical resolution:" & imagePlacement.Resolution.Y)
			Next imagePlacement



		End Sub
	End Class
End Namespace