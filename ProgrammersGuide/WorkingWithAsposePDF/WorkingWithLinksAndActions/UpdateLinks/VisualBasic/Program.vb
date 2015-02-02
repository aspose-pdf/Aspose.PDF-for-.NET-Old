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
Imports Aspose.Pdf.InteractiveFeatures

Namespace UpdateLinks
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Load the PDF file
			Dim doc As New Document(dataDir & "input.pdf")
			' Get the first link annotation from first page of document
			Dim linkAnnot As LinkAnnotation = CType(doc.Pages(1).Annotations(1), LinkAnnotation)
			' Modification link: change link destination
			Dim goToAction As GoToAction = CType(linkAnnot.Action, GoToAction)
			' Specify the destination for link object
			' The first parameter is document object, second is destination page number.
			' The 5ht argument is zoom factor when displaying the respective page. When using 2, the page will be displayed in 200% zoom
			goToAction.Destination = New Aspose.Pdf.InteractiveFeatures.XYZExplicitDestination(doc, 1, 1, 2, 2)
			' Save the document with updated link
			doc.Save(dataDir & "PDFLINK_Modified_output.pdf")



		End Sub
	End Class
End Namespace