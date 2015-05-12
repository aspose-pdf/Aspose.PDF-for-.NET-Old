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

Namespace PrintingDifferentPageRangeExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim pdfv As New Aspose.Pdf.Facades.PdfViewer()

			AddHandler pdfv.PdfQueryPageSettings, AddressOf PdfvOnPdfQueryPageSettings

			Dim pgs As New System.Drawing.Printing.PageSettings()
			Dim prin As New System.Drawing.Printing.PrinterSettings()

			pdfv.BindPdf(dataDir & "NewInput.pdf")
			prin.PrinterName = "HP LaserJet M9050 MFP PCL6"
			prin.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("A4", 827, 1169)

			Dim pageEditor As New Aspose.Pdf.Facades.PdfPageEditor()
			pageEditor.BindPdf(dataDir & "temp.pdf")

			pgs.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
			pgs.PaperSize = prin.DefaultPageSettings.PaperSize

			pdfv.PrintDocumentWithSettings(pgs, prin)
			pdfv.Close()
		End Sub

		Private Shared Sub PdfvOnPdfQueryPageSettings(ByVal sender As Object, ByVal queryPageSettingsEventArgs As System.Drawing.Printing.QueryPageSettingsEventArgs, ByVal currentPageInfo As PdfPrintPageInfo)
			Dim isOdd As Boolean = currentPageInfo.PageNumber Mod 2 <> 0

			Dim paperSources As System.Drawing.Printing.PrinterSettings.PaperSourceCollection = queryPageSettingsEventArgs.PageSettings.PrinterSettings.PaperSources

			If isOdd Then
				queryPageSettingsEventArgs.PageSettings.PaperSource = paperSources(0)
			Else
				queryPageSettingsEventArgs.PageSettings.PaperSource = paperSources(1)
			End If
		End Sub


	End Class
End Namespace