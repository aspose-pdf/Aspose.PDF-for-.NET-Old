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
Imports Aspose.Pdf.Text

Namespace ReplaceTextInSinglePageOfPDF
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'create TextAbsorber object to find all instances of the input search phrase
			Dim textFragmentAbsorber As New TextFragmentAbsorber("text")

			'accept the absorber for a particular page
			pdfDocument.Pages(2).Accept(textFragmentAbsorber)

			'get the extracted text fragments
			Dim textFragmentCollection As TextFragmentCollection = textFragmentAbsorber.TextFragments

			'loop through the fragments
			For Each textFragment As TextFragment In textFragmentCollection
				'update text and other properties
				textFragment.Text = "New Phrase"
				textFragment.TextState.Font = FontRepository.FindFont("Verdana")
				textFragment.TextState.FontSize = 22
				textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Blue)
				textFragment.TextState.BackgroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Green)
			Next textFragment

			pdfDocument.Save(dataDir & "output.pdf")
		End Sub
	End Class
End Namespace