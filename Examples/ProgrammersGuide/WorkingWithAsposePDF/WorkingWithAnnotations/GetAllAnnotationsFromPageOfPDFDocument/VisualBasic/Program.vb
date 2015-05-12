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
Imports Aspose.Pdf.InteractiveFeatures.Annotations
Imports System

Namespace GetAllAnnotationsFromPageOfPDFDocument
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'loop through all the annotations
			For Each annotation As MarkupAnnotation In pdfDocument.Pages(1).Annotations

				'get annotation properties
				Console.WriteLine("Title : {0} ", annotation.Title)
				Console.WriteLine("Subject : {0} ", annotation.Subject)
				Console.WriteLine("Contents : {0} ", annotation.Contents)

			Next annotation

		End Sub
	End Class
End Namespace