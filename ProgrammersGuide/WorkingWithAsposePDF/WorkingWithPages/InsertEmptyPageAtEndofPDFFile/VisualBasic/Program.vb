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

Namespace InsertEmptyPageAtEndofPDFFile
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument1 As New Document(dataDir & "input.pdf")

			'insert an empty page at the end of a PDF file
			pdfDocument1.Pages.Add()

			'save output file
			pdfDocument1.Save(dataDir & "output.pdf")

		End Sub
	End Class
End Namespace