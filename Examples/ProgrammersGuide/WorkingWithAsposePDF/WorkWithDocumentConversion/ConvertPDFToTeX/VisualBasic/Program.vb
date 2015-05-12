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

Namespace ConvertPDFToTeX
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' create Document object
			Dim doc As New Aspose.Pdf.Document(dataDir & "input.pdf")

			' instantiate LaTex save option            
			Dim saveOptions As New LaTeXSaveOptions()

			' specify the output directory 
			Dim pathToOutputDirectory As String = dataDir

			' set the output directory path for save option object
			saveOptions.OutDirectoryPath = pathToOutputDirectory

			' save PDF file into LaTex format            
			doc.Save(dataDir & "Output.tex", saveOptions)
		End Sub
	End Class
End Namespace