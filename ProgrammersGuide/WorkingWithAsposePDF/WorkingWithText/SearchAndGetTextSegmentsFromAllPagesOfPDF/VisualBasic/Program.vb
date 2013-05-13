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
Imports System

Namespace SearchAndGetTextSegmentsFromAllPagesOfPDF
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
				For Each textSegment As TextSegment In textFragment.Segments
					Console.WriteLine("Text : {0} ", textSegment.Text)
					Console.WriteLine("Position : {0} ", textSegment.Position)
					Console.WriteLine("XIndent : {0} ", textSegment.Position.XIndent)
					Console.WriteLine("YIndent : {0} ", textSegment.Position.YIndent)
					Console.WriteLine("Font - Name : {0}", textSegment.TextState.Font.FontName)
					Console.WriteLine("Font - IsAccessible : {0} ", textSegment.TextState.Font.IsAccessible)
					Console.WriteLine("Font - IsEmbedded : {0} ", textSegment.TextState.Font.IsEmbedded)
					Console.WriteLine("Font - IsSubset : {0} ", textSegment.TextState.Font.IsSubset)
					Console.WriteLine("Font Size : {0} ", textSegment.TextState.FontSize)
					Console.WriteLine("Foreground Color : {0} ", textSegment.TextState.ForegroundColor)
				Next textSegment

			Next textFragment
		End Sub
	End Class
End Namespace