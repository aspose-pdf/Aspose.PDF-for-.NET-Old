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

Namespace ConvertXPSToPDF
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' instantiate LoadOption object using XPS load option
			Dim options As Aspose.Pdf.LoadOptions = New XpsLoadOptions()

			' create document object 
			Dim document As New Aspose.Pdf.Document(dataDir & "test.xps", options)

			' save the resultant PDF document
			document.Save(dataDir & "resultant.pdf")
		End Sub
	End Class
End Namespace