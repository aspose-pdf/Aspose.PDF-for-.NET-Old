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

Namespace SetDocumentInformation
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

			'Set the properties of Pdf instance
			pdf1.Author = "Nayyer Shahbaz"
			pdf1.Creator = "Aspose.Pdf"
			pdf1.Keywords = "Hello World"
			pdf1.Subject = "Example"
			pdf1.Title = "Example"
			pdf1.Save(dataDir & "DocInfo.pdf")

		End Sub
	End Class
End Namespace