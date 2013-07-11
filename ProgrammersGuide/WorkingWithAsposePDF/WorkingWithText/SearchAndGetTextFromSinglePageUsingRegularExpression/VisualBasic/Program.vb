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
Imports Aspose.Pdf.Text.TextOptions
Imports System

Namespace SearchAndGetTextFromSinglePageUsingRegularExpression
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'create TextAbsorber object to find all the phrases matching the regular expression
			Dim textFragmentAbsorber As New TextFragmentAbsorber("\d{4}-\d{4}") 'like 1999-2000

			'set text search option to specify regular expression usage
			Dim textSearchOptions As New TextSearchOptions(True)
			textFragmentAbsorber.TextSearchOptions = textSearchOptions

			'accept the absorber for a single page
			pdfDocument.Pages(1).Accept(textFragmentAbsorber)

			'get the extracted text fragments
			Dim textFragmentCollection As TextFragmentCollection = textFragmentAbsorber.TextFragments

			'loop through the fragments
			For Each textFragment As TextFragment In textFragmentCollection
				Console.WriteLine("Text : {0} ", textFragment.Text)
				Console.WriteLine("Position : {0} ", textFragment.Position)
				Console.WriteLine("XIndent : {0} ", textFragment.Position.XIndent)
				Console.WriteLine("YIndent : {0} ", textFragment.Position.YIndent)
				Console.WriteLine("Font - Name : {0}", textFragment.TextState.Font.FontName)
				Console.WriteLine("Font - IsAccessible : {0} ", textFragment.TextState.Font.IsAccessible)
				Console.WriteLine("Font - IsEmbedded : {0} ", textFragment.TextState.Font.IsEmbedded)
				Console.WriteLine("Font - IsSubset : {0} ", textFragment.TextState.Font.IsSubset)
				Console.WriteLine("Font Size : {0} ", textFragment.TextState.FontSize)
				Console.WriteLine("Foreground Color : {0} ", textFragment.TextState.ForegroundColor)
			Next textFragment
		End Sub
	End Class
End Namespace