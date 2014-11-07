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

Namespace AddImageStamp
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'Create image stamp
			Dim imageStamp As New ImageStamp(dataDir & "aspose-logo.jpg")
			imageStamp.Background = True
			imageStamp.XIndent = 100
			imageStamp.YIndent = 100
			imageStamp.Height = 300
			imageStamp.Width = 300
			imageStamp.Rotate = Rotation.on270
			imageStamp.Opacity = 0.5
			'Add stamp to particular page
			pdfDocument.Pages(1).AddStamp(imageStamp)

			'Save output document
			pdfDocument.Save(dataDir & "output.pdf")


		End Sub
	End Class
End Namespace