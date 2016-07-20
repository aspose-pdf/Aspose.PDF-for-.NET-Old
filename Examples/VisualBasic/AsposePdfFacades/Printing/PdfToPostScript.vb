Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Printing
    Public Class PdfToPostScript
        Public Shared Sub Run()
            Try
                ' ExStart:PdfToPostScript
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Printing()

                Dim viewer As New Aspose.Pdf.Facades.PdfViewer()
                viewer.BindPdf(dataDir & Convert.ToString("input.pdf"))
                ' Set PrinterSettings and PageSettings
                Dim printerSetttings As New System.Drawing.Printing.PrinterSettings()
                printerSetttings.Copies = 1
                ' Set PS printer, one can find this driver in the list of preinstalled printer drivers in Windows
                printerSetttings.PrinterName = "HP LaserJet 2300 Series PS"
                ' Set output file name and PrintToFile attribute
                printerSetttings.PrintFileName = dataDir & Convert.ToString("PdfToPostScript_out_.ps")
                printerSetttings.PrintToFile = True
                ' Disable print page dialog
                viewer.PrintPageDialog = False
                ' Pass printer settings object to the method
                viewer.PrintDocumentWithSettings(printerSetttings)
                ' ExEnd:PdfToPostScript
                viewer.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
