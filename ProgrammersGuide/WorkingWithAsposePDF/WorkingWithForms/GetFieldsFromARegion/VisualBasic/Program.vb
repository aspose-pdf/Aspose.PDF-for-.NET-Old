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
Imports Aspose.Pdf.InteractiveFeatures.Forms
Imports System

Namespace GetFieldsFromARegion
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Open pdf file
			Dim doc As New Aspose.Pdf.Document(dataDir & "input.pdf")

			'Create rectangle object to get fields in that area
			Dim rectangle As New Aspose.Pdf.Rectangle(35, 30, 500, 500)

			'Get the PDF form
			Dim form As Aspose.Pdf.InteractiveFeatures.Forms.Form = doc.Form

			'get fields in the rectangular area
			Dim fields() As Aspose.Pdf.InteractiveFeatures.Forms.Field = form.GetFieldsInRect(rectangle)

			'Display Field names and values
			For Each field As Field In fields

				'Display image placement properties for all placements
				Console.Out.WriteLine("Field Name: " & field.FullName & "-" & "Field Value: " & field.Value)
			Next field

		End Sub
	End Class
End Namespace