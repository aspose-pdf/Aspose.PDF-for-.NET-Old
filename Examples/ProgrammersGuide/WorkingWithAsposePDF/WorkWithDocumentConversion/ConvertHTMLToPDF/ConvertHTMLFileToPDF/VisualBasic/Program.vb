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
Imports System

Namespace ConvertHTMLFileToPDFExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Specify the The base path/url for the html file which serves as images database
			Dim basePath As String = "C:/temp/"
			Dim htmloptions As HtmlLoadOptions = New HtmlLoadOptions(basePath)
			' Load HTML file
			Dim doc As Document = New Document(dataDir & "Input.html", htmloptions)
			' Save HTML file
			doc.Save(dataDir & "output.pdf")
		End Sub
	End Class
End Namespace