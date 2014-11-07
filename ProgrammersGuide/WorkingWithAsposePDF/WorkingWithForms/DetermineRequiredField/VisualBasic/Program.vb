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

Namespace DetermineRequiredField
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Load source PDF file
			Dim pdf As New Document(dataDir & "input.pdf")

			' Instantiate Form object
			Dim pdfForm As New Aspose.Pdf.Facades.Form(pdf)

			' Iterate through each field inside PDF form
			For Each field As Aspose.Pdf.InteractiveFeatures.Forms.Field In pdf.Form.Fields
				' Determine if the field is marked as required or not
				If field.Required Then
					' Print either the field is marked as required or not
					Console.WriteLine("The field named " & field.FullName & " is required")
				End If
			Next field

		End Sub
	End Class
End Namespace