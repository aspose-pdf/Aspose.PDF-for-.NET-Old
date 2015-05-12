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

Namespace GetAlltheAttachmentsFromPDF
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'get embedded files collection
			Dim embeddedFiles As EmbeddedFileCollection = pdfDocument.EmbeddedFiles

			'get count of the embedded files
			Console.WriteLine("Total files : {0}", embeddedFiles.Count)

			Dim count As Integer = 1

			'loop through the collection to get all the attachments
			For Each fileSpecification As FileSpecification In embeddedFiles
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

				'get the attachment and write to file or stream
				Dim fileContent(fileSpecification.Contents.Length - 1) As Byte
				fileSpecification.Contents.Read(fileContent, 0, fileContent.Length)
				Dim fileStream As New FileStream(dataDir & count & ".txt", FileMode.Create)
				fileStream.Write(fileContent, 0, fileContent.Length)
				fileStream.Close()
				count+=1
			Next fileSpecification

		End Sub
	End Class
End Namespace