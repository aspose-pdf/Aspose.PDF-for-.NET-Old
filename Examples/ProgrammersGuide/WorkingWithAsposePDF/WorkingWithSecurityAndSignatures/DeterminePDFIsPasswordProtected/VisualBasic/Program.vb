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
Imports Aspose.Pdf.Facades
Imports System

Namespace DeterminePDFIsPasswordProtected
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")


			' load the source PDF doucment
			Dim fileInfo As New PdfFileInfo(dataDir & "input.pdf")
			' determine that source PDF file is Encrypted with password
			Dim encrypted As Boolean = fileInfo.IsEncrypted
			' MessageBox displays the current status related to PDf encryption
		   Console.WriteLine(encrypted.ToString())

		End Sub
	End Class
End Namespace