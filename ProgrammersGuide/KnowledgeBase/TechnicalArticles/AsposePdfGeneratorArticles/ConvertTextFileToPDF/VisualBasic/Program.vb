'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Pdf

Namespace ConvertTextFileToPDF
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'read the source text file
			Dim tr As System.IO.TextReader = New StreamReader(dataDir & "test.txt")

			'Instantiate Pdf pbject by calling its empty constructor
			Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

			'Create a new section in the Pdf object
			Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

			'Create a new text paragraph and pass the text to its constructor as argument
			Dim t2 As New Aspose.Pdf.Generator.Text(tr.ReadToEnd())
			sec1.Paragraphs.Add(t2)

			pdf1.Save(dataDir & "output.pdf")
		End Sub
	End Class
End Namespace