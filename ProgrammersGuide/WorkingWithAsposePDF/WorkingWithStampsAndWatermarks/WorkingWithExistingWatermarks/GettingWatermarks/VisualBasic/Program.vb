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
Imports System

Namespace GettingWatermarks
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")
			' Iterate through and get tub-type, text and location of artifact
			For Each artifact As Artifact In pdfDocument.Pages(1).Artifacts
				Console.WriteLine(artifact.Subtype & " " & artifact.Text & " " & artifact.Rectangle)
			Next artifact


		End Sub
	End Class
End Namespace