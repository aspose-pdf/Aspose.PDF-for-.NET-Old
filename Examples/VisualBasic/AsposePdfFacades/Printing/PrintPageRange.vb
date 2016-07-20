Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Printing
    Public Class PrintPageRange
        Public Shared Sub Run()
            Try
                ' ExStart:PrintPageRange
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Printing()

                Dim pdfv As New Aspose.Pdf.Facades.PdfViewer()

                AddHandler pdfv.PdfQueryPageSettings, AddressOf PdfvOnPdfQueryPageSettings

                Dim pgs As New System.Drawing.Printing.PageSettings()
                Dim prin As New System.Drawing.Printing.PrinterSettings()

                pdfv.BindPdf(dataDir & Convert.ToString("Print-PageRange.pdf"))
                prin.PrinterName = "HP LaserJet M9050 MFP PCL6"
                prin.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("A4", 827, 1169)

                Dim pageEditor As New Aspose.Pdf.Facades.PdfPageEditor()
                pageEditor.BindPdf(dataDir & Convert.ToString("input.pdf"))

                pgs.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
                pgs.PaperSize = prin.DefaultPageSettings.PaperSize

                pdfv.PrintDocumentWithSettings(pgs, prin)
                ' ExEnd:PrintPageRange
                pdfv.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        ' ExStart:PdfvOnPdfQueryPageSettings
        Private Shared Sub PdfvOnPdfQueryPageSettings(sender As Object, queryPageSettingsEventArgs As System.Drawing.Printing.QueryPageSettingsEventArgs, currentPageInfo As PdfPrintPageInfo)
            Dim isOdd As Boolean = currentPageInfo.PageNumber Mod 2 <> 0

            Dim paperSources As System.Drawing.Printing.PrinterSettings.PaperSourceCollection = queryPageSettingsEventArgs.PageSettings.PrinterSettings.PaperSources

            If isOdd Then
                queryPageSettingsEventArgs.PageSettings.PaperSource = paperSources(0)
            Else
                queryPageSettingsEventArgs.PageSettings.PaperSource = paperSources(1)
            End If
        End Sub
        ' ExEnd:PdfvOnPdfQueryPageSettings

    End Class
End Namespace

'=======================================================