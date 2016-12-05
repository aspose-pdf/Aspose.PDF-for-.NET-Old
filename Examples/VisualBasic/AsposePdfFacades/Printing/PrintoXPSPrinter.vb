Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Printing
    Public Class PrintoXPSPrinter
        Public Shared Sub Run()
            ' ExStart:PrintoXPSPrinter
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

            ' Set XPS/PDF printer name
            ps.PrinterName = "Microsoft XPS Document Writer"
            ' or set the PDF printer
            ' Ps.PrinterName = "Adobe PDF";

            ' Set PageSize (if required)
            pgs.PaperSize = New System.Drawing.Printing.PaperSize("A4", 827, 1169)

            ' Set PageMargins (if required)
            pgs.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)

            ' Print document using printer and page settings
            viewer.PrintDocumentWithSettings(pgs, ps)

            ' Close the PDF file after priting
            viewer.Close()
            ' ExEnd:PrintoXPSPrinter
        End Sub
        Public Shared Sub HideDialgo()
            ' ExStart:HideDialgo
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Printing()

            ' Create PdfViewer object and bind PDF file
            Dim pdfViewer As New PdfViewer()
            pdfViewer.BindPdf(dataDir & Convert.ToString("input.pdf"))

            ' Set PrinterSettings and PageSettings
            Dim printerSetttings As New System.Drawing.Printing.PrinterSettings()
            printerSetttings.Copies = 1
            printerSetttings.PrinterName = "Microsoft XPS Document Writer"

            ' Set output file name and PrintToFile attribute
            printerSetttings.PrintFileName = dataDir & Convert.ToString("print_out_.xps")
            printerSetttings.PrintToFile = True

            ' Disable print page dialog
            pdfViewer.PrintPageDialog = False

            ' Pass printer settings object to the method
            pdfViewer.PrintDocumentWithSettings(printerSetttings)
            pdfViewer.Close()
            ' ExEnd:HideDialgo
        End Sub
        Public Shared Sub FontsNotEmbedded()

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

            ' Set XPS/PDF printer name
            ps.PrinterName = "Microsoft XPS Document Writer"
            ' or set the PDF printer
            ' Ps.PrinterName = "Adobe PDF";

            ' Set PageSize (if required)
            pgs.PaperSize = New System.Drawing.Printing.PaperSize("A4", 827, 1169)

            ' Set PageMargins (if required)
            pgs.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)

            ' ExStart:FontsNotEmbedded
            ' Render all system fonts with native system approach (embed the fonts to output documents)
            viewer.RenderingOptions.SystemFontsNativeRendering = True
            ' ExEnd:FontsNotEmbedded

            ' Print document using printer and page settings
            viewer.PrintDocumentWithSettings(pgs, ps)

            ' Close the PDF file after priting
            viewer.Close()
        End Sub


    End Class
End Namespace
