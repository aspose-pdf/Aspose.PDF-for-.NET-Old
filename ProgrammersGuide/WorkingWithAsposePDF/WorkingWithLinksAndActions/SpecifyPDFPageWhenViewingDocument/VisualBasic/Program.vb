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
Imports Aspose.Pdf.InteractiveFeatures

Namespace SpecifyPDFPageWhenViewingDocument
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' load the PDF file
			Dim doc As New Document(dataDir & "input.pdf")
			' get the instance of second page of document
			Dim page2 As Page = doc.Pages(2)
			' create the variable to set the zoom factor of target page
			Dim zoom As Double = 1
			' create GoToAction instance
			Dim action As New Aspose.Pdf.InteractiveFeatures.GoToAction()
			' Go to 2 page
			action.Destination = New XYZExplicitDestination(page2, 0, page2.Rect.Height, zoom)
			' set the document open action
			doc.OpenAction = action
			' save updated document
			doc.Save(dataDir & "goto2page.pdf")



		End Sub
	End Class
End Namespace