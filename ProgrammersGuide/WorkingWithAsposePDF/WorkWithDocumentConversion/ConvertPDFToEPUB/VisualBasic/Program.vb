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

Namespace ConvertPDFToEPUB
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' load PDF document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			' instantiate Epub Save options
			Dim options As New EpubSaveOptions()

			' specify the layout for contents
			options.ContentRecognitionMode = EpubSaveOptions.RecognitionMode.Flow

			' save the ePUB document
			pdfDocument.Save(dataDir & "Sample.epub", options)
		End Sub
	End Class
End Namespace