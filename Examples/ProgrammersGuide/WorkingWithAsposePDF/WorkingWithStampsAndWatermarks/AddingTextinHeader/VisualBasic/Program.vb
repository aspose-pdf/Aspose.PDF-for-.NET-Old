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

Namespace AddingTextinHeader
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'create header
			Dim textStamp As New TextStamp("Header Text")
			'set properties of the stamp
			textStamp.TopMargin = 10
			textStamp.HorizontalAlignment = HorizontalAlignment.Center
			textStamp.VerticalAlignment = VerticalAlignment.Top
			'add header on all pages
			For Each page As Page In pdfDocument.Pages
				page.AddStamp(textStamp)
			Next page

			'save updated document
			pdfDocument.Save(dataDir & "output.pdf")



		End Sub
	End Class
End Namespace