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

Namespace RightToLeftAlignedLanguages
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Instantiate Pdf instance by calling it empty constructor
			Dim pdf As New Aspose.Pdf.Generator.Pdf()
			'Create a section in the Pdf object
			pdf.Sections.Add()

			pdf.IsTruetypeFontMapCached = True
			'Specify the location where to save TruetypeFontMap.xml
			pdf.TruetypeFontMapPath = dataDir & ""

			'Create a text object and pass the string object carrying arabic text in it
			Dim text1 As New Aspose.Pdf.Generator.Text()
			'Create a segment and add it to segments collection of text object
			Dim seg0 As Aspose.Pdf.Generator.Segment = text1.Segments.Add()
			'specify contents for segment
			seg0.Content = "????? ?? ???? ???? ??"
			Dim seg1 As Aspose.Pdf.Generator.Segment = text1.Segments.Add()
			seg1.Content = ".NET"
			Dim seg2 As Aspose.Pdf.Generator.Segment = text1.Segments.Add()
			seg2.Content = "??????"

			'Enable text alignment from right to left
			seg0.TextInfo.IsRightToLeft = True
			seg1.TextInfo.IsRightToLeft = False 'default
			seg2.TextInfo.IsRightToLeft = True

			'Enable unicode character set for the text segment
			seg0.TextInfo.IsUnicode = True
			seg1.TextInfo.IsUnicode = True
			seg2.TextInfo.IsUnicode = True

			'Set Font Name
			seg0.TextInfo.FontName = "Times New Roman"
			seg1.TextInfo.FontName = "Times New Roman"
			seg2.TextInfo.FontName = "Times New Roman"
			'Set font size
			seg0.TextInfo.FontSize = 14
			seg1.TextInfo.FontSize = 14
			seg2.TextInfo.FontSize = 14

			'Align text to right hand side using AlignmentType enumeration    
			'Make the text right aligned(The meaning of Alignment.Left and AlignmentType.Right are //exchanged when processing RTL language).
			text1.TextInfo.Alignment = Aspose.Pdf.Generator.AlignmentType.Left

			pdf.Sections(0).Paragraphs.Add(text1)
			pdf.IsRtlInSegmentMode = True 'default

			pdf.Save(dataDir & "AsposeOutput.pdf")


		End Sub
	End Class
End Namespace