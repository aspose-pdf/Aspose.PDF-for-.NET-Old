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

Namespace AddingJavaScript
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If


			'Instantiate a PDF Object 
			Dim pdf As New Aspose.Pdf.Generator.Pdf()

			'Instantiate a Aspose PDF JavaScript Object
			pdf.JavaScripts = New Aspose.Pdf.Generator.JavaScripts()

			'Call the Add method and pass JavaScript statement as an argument, to show Print Dialog
			pdf.JavaScripts.Add("this.print(true);")

			'Call the Add method and JavaScript statement as an argument, to show alert
			pdf.JavaScripts.Add("app.alert(""hello world"");")

			'Save Pdf Document
			pdf.Save(dataDir & "Aspose.pdf")


		End Sub
	End Class
End Namespace