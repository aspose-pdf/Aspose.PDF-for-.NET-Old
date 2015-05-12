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

Namespace AddAttachmentInPDFDocument
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'setup new file to be added as attachment
			Dim fileSpecification As New FileSpecification(dataDir & "test.txt", "Sample text file")

			'add attachment to document's attachment collection
			pdfDocument.EmbeddedFiles.Add(fileSpecification)

			'save new output
			pdfDocument.Save(dataDir & "output.pdf")

		End Sub
	End Class
End Namespace