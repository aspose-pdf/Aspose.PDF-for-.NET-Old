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

Namespace AddTOCInExistingPDF
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Load an existing PDF files
			Dim doc As New Document(dataDir & "input.pdf")

			' Get access to first page of PDF file
			Dim tocPage As Page = doc.Pages.Insert(1)

			' Create object to represent TOC information
			Dim tocInfo As New TocInfo()
			Dim title As New TextFragment("Table Of Contents")
			title.TextState.FontSize = 20
			title.TextState.FontStyle = FontStyles.Bold

			' Set the title for TOC
			tocInfo.Title = title
			tocPage.TocInfo = tocInfo

			' Create string objects which will be used as TOC elements
			Dim titles(3) As String
			titles(0) = "First page"
			titles(1) = "Second page"
			titles(2) = "Third page"
			titles(3) = "Fourth page"
			For i As Integer = 0 To 1
				' Create Heading object
				Dim heading2 As New Aspose.Pdf.Heading(1)
				Dim segment2 As New TextSegment()
				heading2.TocPage = tocPage
				heading2.Segments.Add(segment2)

				' Specify the destination page for heading object
				heading2.DestinationPage = doc.Pages(i + 2)

				' Destination page
				heading2.Top = doc.Pages(i + 2).Rect.Height

				' Destination coordinate
				segment2.Text = titles(i)

				' Add heading to page containing TOC
				tocPage.Paragraphs.Add(heading2)
			Next i
			' Save the updated document
			doc.Save(dataDir & "TOC_Output.pdf")

		End Sub
	End Class
End Namespace