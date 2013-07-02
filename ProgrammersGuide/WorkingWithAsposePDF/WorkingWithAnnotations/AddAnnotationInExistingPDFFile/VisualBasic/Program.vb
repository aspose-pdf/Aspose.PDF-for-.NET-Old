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

Namespace AddAnnotationInExistingPDFFile
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'create annotation
			Dim textAnnotation As New TextAnnotation(pdfDocument.Pages(1), New Aspose.Pdf.Rectangle(200, 400, 400, 600))
			textAnnotation.Title = "Sample Annotation Title"
			textAnnotation.Subject = "Sample Subject"
			textAnnotation.State = AnnotationState.Accepted
			textAnnotation.Contents = "Sample contents for the annotation"
			textAnnotation.Open = True
			textAnnotation.Icon = TextIcon.Key

			Dim border As New Border(textAnnotation)
			border.Width = 5
			border.Dash = New Dash(1, 1)
			textAnnotation.Border = border
			textAnnotation.Rect = New Aspose.Pdf.Rectangle(200, 400, 400, 600)

			'add annotation in the annotations collection of the page
			pdfDocument.Pages(1).Annotations.Add(textAnnotation)

			'//save output file
			pdfDocument.Save(dataDir & "output.pdf")

		End Sub
	End Class
End Namespace