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

Namespace ConvertSVGToPDF
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Instantiate LoadOption object using SVG load option
			Dim loadopt As Aspose.Pdf.LoadOptions = New Aspose.Pdf.SvgLoadOptions()

			' Create Document object
			Dim doc As New Aspose.Pdf.Document(dataDir & "example.svg", loadopt)

			' Save the resultant PDF document
			doc.Save(dataDir & "converted.pdf")
		End Sub
	End Class
End Namespace