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

Namespace ExtractSignatureInformation
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim input As String = dataDir & "input.pdf"
			Using pdfDocument As New Document(input)
				For Each field As Field In pdfDocument.Form
					Dim sf As SignatureField = TryCast(field, SignatureField)
					If sf IsNot Nothing Then
						Dim cerStream As Stream = sf.ExtractCertificate()
						If cerStream IsNot Nothing Then
							Using cerStream
								Dim bytes(cerStream.Length - 1) As Byte
								Using fs As New FileStream(dataDir & "input.cer", FileMode.CreateNew)
									cerStream.Read(bytes, 0, bytes.Length)
									fs.Write(bytes, 0, bytes.Length)
								End Using
							End Using
						End If
					End If
				Next field
			End Using


		End Sub
	End Class
End Namespace