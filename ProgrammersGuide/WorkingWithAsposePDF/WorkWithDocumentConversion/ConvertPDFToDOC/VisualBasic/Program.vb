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

Namespace ConvertPDFToDOC
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open the source PDF document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			' 1.
			' saving using direct method
			' save the file into MS document format
			pdfDocument.Save(dataDir & "simpleOutput.doc", SaveFormat.Doc)

			' 2.
			' save using save options
			' create DocSaveOptions object
			Dim saveOptions As New DocSaveOptions()

			' set the recognition mode as Flow
			saveOptions.Mode = DocSaveOptions.RecognitionMode.Flow

			' set the Horizontal proximity as 2.5
			saveOptions.RelativeHorizontalProximity = 2.5f

			' enable the value to recognize bullets during conversion process
			saveOptions.RecognizeBullets = True

			' save the resultant DOC file
			pdfDocument.Save(dataDir & "saveOptionsOutput.doc", saveOptions)
		End Sub
	End Class
End Namespace