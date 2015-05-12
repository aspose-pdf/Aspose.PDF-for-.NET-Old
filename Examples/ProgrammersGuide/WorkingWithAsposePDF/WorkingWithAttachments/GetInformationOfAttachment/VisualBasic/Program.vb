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

Namespace GetInformationOfAttachment
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'get particular embedded file
			Dim fileSpecification As FileSpecification = pdfDocument.EmbeddedFiles(1)

			'get the file properties
			Console.WriteLine("Name: {0}", fileSpecification.Name)
			Console.WriteLine("Description: {0}", fileSpecification.Description)
			Console.WriteLine("Mime Type: {0}", fileSpecification.MIMEType)

			'check if parameter object contains the parameters
			If fileSpecification.Params IsNot Nothing Then
				Console.WriteLine("CheckSum: {0}", fileSpecification.Params.CheckSum)
				Console.WriteLine("Creation Date: {0}", fileSpecification.Params.CreationDate)
				Console.WriteLine("Modification Date: {0}", fileSpecification.Params.ModDate)
				Console.WriteLine("Size: {0}", fileSpecification.Params.Size)
			End If


		End Sub
	End Class
End Namespace