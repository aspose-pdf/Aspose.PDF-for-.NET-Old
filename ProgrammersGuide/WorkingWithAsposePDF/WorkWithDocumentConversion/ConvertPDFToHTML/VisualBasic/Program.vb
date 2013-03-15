'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Pdf

Namespace ConvertPDFToHTML
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open the source PDF document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			' save the file into MS document format
			pdfDocument.Save(dataDir & "output.html", SaveFormat.Html)
		End Sub
	End Class
End Namespace