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

Namespace SetTextBackgroundColor
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Instantiate Pdf instance by calling its empty constructor
Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

'Create a section in the Pdf object
Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

'Create a text paragraph
Dim text1 As New Aspose.Pdf.Generator.Text(sec1,"Hello Aspose.Pdf")

'Set the BackgroundColor of the text paragraph to Red
text1.TextInfo.BackgroundColor = New Aspose.Pdf.Generator.Color("Red")

'Add the text paragraph to the section
sec1.Paragraphs.Add(text1)

'Save the Pdf
pdf1.Save(dataDir & "AsposeOutput.pdf")


		End Sub
	End Class
End Namespace