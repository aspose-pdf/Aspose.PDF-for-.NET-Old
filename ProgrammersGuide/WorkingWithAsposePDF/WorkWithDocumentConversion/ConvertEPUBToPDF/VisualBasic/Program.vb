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

Namespace ConvertEPUBToPDF
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Instantiate LoadOption object using EPUB load option
			Dim epubload As New EpubLoadOptions()

			' Create Document object
			Dim pdf As New Aspose.Pdf.Document(dataDir & "Sample.epub", epubload)

			' Save the resultant PDF document
			pdf.Save(dataDir & "output.pdf")
		End Sub
	End Class
End Namespace