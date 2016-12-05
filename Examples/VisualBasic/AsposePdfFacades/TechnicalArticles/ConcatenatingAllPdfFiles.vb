Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.TechnicalArticles
    Public Class ConcatenatingAllPdfFiles
        Public Shared Sub Run()
            ' ExStart:ConcatenatingAllPdfFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Retrieve names of all the Pdf files in a particular Directory
            Dim fileEntries As String() = Directory.GetFiles(dataDir, "*.pdf")

            ' Get the current System date and set its format
            Dim [date] As String = DateTime.Now.ToString("MM-dd-yyyy")
            ' Get the current System time and set its format
            Dim hoursSeconds As String = DateTime.Now.ToString("hh-mm")
            ' Set the value for the final Resultant Pdf document
            Dim masterFileName As String = (Convert.ToString([date] & Convert.ToString("_")) & hoursSeconds) + "_out_.pdf"

            ' Instantiate PdfFileEditor object
            Dim pdfEditor As Aspose.Pdf.Facades.PdfFileEditor = New PdfFileEditor()

            ' Call Concatenate method of PdfFileEditor object to concatenate all input files
            ' Into a single output file
            pdfEditor.Concatenate(fileEntries, dataDir & masterFileName)
            ' ExEnd:ConcatenatingAllPdfFiles                      
        End Sub
    End Class
End Namespace
