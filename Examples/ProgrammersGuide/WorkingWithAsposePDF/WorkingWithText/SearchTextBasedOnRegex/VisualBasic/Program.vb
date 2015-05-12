'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
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
Imports Aspose.Pdf.Facades
Imports System

Namespace SearchTextBasedOnRegexExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'create absorber object to find all instances of the input search phrase
			Dim absorber As New TextFragmentAbsorber("D[a-z]{7}:")
			'Enable regular expression search
			absorber.TextSearchOptions = New TextSearchOptions(True)
			'open document            
			Dim editor As New PdfContentEditor()
			' bind source PDF file
			editor.BindPdf(dataDir & "Input_new.pdf")
			'accept the absorber for the page
			editor.Document.Pages(1).Accept(absorber)

			Dim dashArray() As Integer = { }
			Dim LEArray() As String = { }
			Dim blue As System.Drawing.Color = System.Drawing.Color.Blue

			'loop through the fragments
			For Each textFragment As TextFragment In absorber.TextFragments
				textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.Blue
				Dim rect As New System.Drawing.Rectangle(CInt(Fix(textFragment.Rectangle.LLX)), CInt(Fix(Math.Round(textFragment.Rectangle.LLY))), CInt(Fix(Math.Round(textFragment.Rectangle.Width + 2))), CInt(Fix(Math.Round(textFragment.Rectangle.Height + 1))))
				Dim actionName() As System.Enum = New [Enum](1) { Aspose.Pdf.InteractiveFeatures.PredefinedAction.Document_AttachFile, Aspose.Pdf.InteractiveFeatures.PredefinedAction.Document_ExtractPages }
				editor.CreateWebLink(rect, "http://www.aspose.com", 1, blue, actionName)
				editor.CreateLine(rect, "", CSng(textFragment.Rectangle.LLX) + 1, CSng(textFragment.Rectangle.LLY) - 1, CSng(textFragment.Rectangle.URX), CSng(textFragment.Rectangle.LLY) - 1, 1, 1, blue, "S", dashArray, LEArray)
			Next textFragment
			'Save & Close the document
			editor.Save(dataDir & "TextReplaced_with_Links.pdf")
			editor.Close()



		End Sub
	End Class
End Namespace