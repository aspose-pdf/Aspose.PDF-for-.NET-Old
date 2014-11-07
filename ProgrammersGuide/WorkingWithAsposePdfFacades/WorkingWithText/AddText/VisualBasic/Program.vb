'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AddTextExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'create PdfFileMend object to add text
			Dim mender As New PdfFileMend("input.pdf", "output.pdf")

			'create formatted text
			Dim text As New FormattedText("Aspose - Your File Format Experts!", System.Drawing.Color.AliceBlue, System.Drawing.Color.Gray, Aspose.Pdf.Facades.FontStyle.Courier, EncodingType.Winansi, True, 14)

			'set whether to use Word Wrap or not and using which mode
			mender.IsWordWrap = True
			mender.WrapMode = WordWrapMode.Default

			'add text in the PDF file
			mender.AddText(text, 1, 100, 200, 200, 400)

			'close PdfFileMend object
			mender.Close()

		End Sub
	End Class
End Namespace