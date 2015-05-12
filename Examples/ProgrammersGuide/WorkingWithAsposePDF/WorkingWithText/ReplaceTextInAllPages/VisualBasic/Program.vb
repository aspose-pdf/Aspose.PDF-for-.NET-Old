'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace ReplaceTextInAllPages
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'create TextAbsorber object to find all instances of the input search phrase
			Dim textFragmentAbsorber As New TextFragmentAbsorber("text")

			'accept the absorber for all the pages
			pdfDocument.Pages.Accept(textFragmentAbsorber)

			'get the extracted text fragments
			Dim textFragmentCollection As TextFragmentCollection = textFragmentAbsorber.TextFragments

			'loop through the fragments
			For Each textFragment As TextFragment In textFragmentCollection
				'update text and other properties
				textFragment.Text = "TEXT"
				textFragment.TextState.Font = FontRepository.FindFont("Verdana")
				textFragment.TextState.FontSize = 22
				textFragment.TextState.ForegroundColor = System.Drawing.Color.Blue
				textFragment.TextState.BackgroundColor = System.Drawing.Color.Green
			Next textFragment

			' Save resulting PDF document.
			pdfDocument.Save(dataDir & "output.pdf")

			' Let user know about the outcome of the processing.
			System.Console.WriteLine("Text replaced successfully!")
		End Sub
	End Class
End Namespace