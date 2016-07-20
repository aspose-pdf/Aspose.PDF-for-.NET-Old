Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Printing
    Public Class PrintToDefaultPrinter
        Public Shared Sub Run()
            ' ExStart:PrintToDefaultPrinter
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Printing()

            ' Create PdfViewer object
            Dim viewer As New PdfViewer()

            ' Open input PDF file
            viewer.BindPdf(dataDir & Convert.ToString("input.pdf"))

            ' Set attributes for printing
            viewer.AutoResize = True
            ' Print the file with adjusted size
            viewer.AutoRotate = True
            ' Print the file with adjusted rotation
            viewer.PrintPageDialog = False
            ' Do not produce the page number dialog when printing
            ' Create objects for printer and page settings and PrintDocument
            Dim ps As New System.Drawing.Printing.PrinterSettings()
            Dim pgs As New System.Drawing.Printing.PageSettings()
            Dim prtdoc As New System.Drawing.Printing.PrintDocument()

            ' Set printer name
            ps.PrinterName = prtdoc.PrinterSettings.PrinterName

            ' Set PageSize (if required)
            pgs.PaperSize = New System.Drawing.Printing.PaperSize("A4", 827, 1169)

            ' Set PageMargins (if required)
            pgs.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)

            ' Print document using printer and page settings
            viewer.PrintDocumentWithSettings(pgs, ps)

            ' Close the PDF file after priting
            viewer.Close()
            ' ExEnd:PrintToDefaultPrinter
        End Sub
        Public Shared Sub ShowPrintDialog()
            ' ExStart:PrintToDefaultPrinter
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Printing()

            ' Create PdfViewer object
            Dim viewer As New PdfViewer()

            ' Open input PDF file
            viewer.BindPdf(dataDir & Convert.ToString("input.pdf"))

            ' Set attributes for printing
            viewer.AutoResize = True
            ' Print the file with adjusted size
            viewer.AutoRotate = True
            ' Print the file with adjusted rotation
            viewer.PrintPageDialog = False
            ' Do not produce the page number dialog when printing
            ' Create objects for printer and page settings and PrintDocument
            Dim ps As New System.Drawing.Printing.PrinterSettings()
            Dim pgs As New System.Drawing.Printing.PageSettings()
            Dim prtdoc As New System.Drawing.Printing.PrintDocument()

            ' Set printer name
            ps.PrinterName = prtdoc.PrinterSettings.PrinterName

            ' Set PageSize (if required)
            pgs.PaperSize = New System.Drawing.Printing.PaperSize("A4", 827, 1169)

            ' Set PageMargins (if required)
            pgs.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
            ' ExStart:PrintDialog
            Dim printDialog As New System.Windows.Forms.PrintDialog()
            If printDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                ' Document printing code goes here
                ' Print document using printer and page settings
                viewer.PrintDocumentWithSettings(pgs, ps)
            End If
            ' ExEnd:PrintDialog            

            ' Close the PDF file after priting
            viewer.Close()
        End Sub

    End Class
End Namespace
