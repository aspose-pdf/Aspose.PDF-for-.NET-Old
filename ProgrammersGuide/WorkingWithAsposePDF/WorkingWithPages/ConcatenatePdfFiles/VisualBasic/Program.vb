'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Pdf

Namespace ConcatenatePdfFiles
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open first document
			Dim pdfDocument1 As New Document(dataDir & "input1.pdf")
			'open second document
			Dim pdfDocument2 As New Document(dataDir & "input2.pdf")

			'add pages of second document to the first
			pdfDocument1.Pages.Add(pdfDocument2.Pages)

			'save concatenated output file
			pdfDocument1.Save(dataDir & "output.pdf")

			' Display result.
			System.Console.WriteLine("PDFs are concatenated successfully!")
		End Sub
	End Class
End Namespace