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
Imports Aspose.Pdf.Text

Namespace AddingTextStamp
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'create text stamp
			Dim textStamp As New TextStamp("Sample Stamp")
			'set whether stamp is background
			textStamp.Background = True
			'set origin
			textStamp.XIndent = 100
			textStamp.YIndent = 100
			'rotate stamp
			textStamp.Rotate = Rotation.on90
			'set text properties
			textStamp.TextState.Font = FontRepository.FindFont("Arial")
			textStamp.TextState.FontSize = 14.0F
			textStamp.TextState.FontStyle = FontStyles.Bold
			textStamp.TextState.FontStyle = FontStyles.Italic
			textStamp.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Aqua)
			'add stamp to particular page
			pdfDocument.Pages(1).AddStamp(textStamp)

			'save output document
			pdfDocument.Save(dataDir & "output.pdf")


		End Sub
	End Class
End Namespace