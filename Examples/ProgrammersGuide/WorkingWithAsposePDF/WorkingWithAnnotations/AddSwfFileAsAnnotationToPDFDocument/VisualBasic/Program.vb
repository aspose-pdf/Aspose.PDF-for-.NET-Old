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

Namespace AddSwfFileAsAnnotationToPDFDocument
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Open the PDF document
			Dim doc As New Document(dataDir & "input.pdf")

			' get reference of the page to which you need to add the annotation
			Dim page As Page = doc.Pages(1)

			' create ScreenAnnotation object with .swf multimedia file as an argument
			Dim annotation As New ScreenAnnotation(page, New Aspose.Pdf.Rectangle(0, 400, 600, 700), dataDir & "input.swf")

			' add the annotation to annotations collection of page
			page.Annotations.Add(annotation)

			' save the update PDF document with annotation
			doc.Save(dataDir & "output.pdf")

		End Sub
	End Class
End Namespace