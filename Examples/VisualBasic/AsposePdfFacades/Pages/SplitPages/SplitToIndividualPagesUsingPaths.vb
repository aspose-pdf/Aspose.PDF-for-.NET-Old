Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.SplitPages
    Public Class SplitToIndividualPagesUsingPaths
        Public Shared Sub Run()
            ' ExStart:SplitToIndividualPagesUsingPaths
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            Dim fileNumber As Integer = 1
            ' Split to pages
            Dim outBuffer As MemoryStream() = pdfEditor.SplitToPages(dataDir & Convert.ToString("splitpages.pdf"))
            ' Save individual files
            For Each aStream As MemoryStream In outBuffer
                Dim outStream As New FileStream((dataDir & Convert.ToString("File_")) + fileNumber.ToString() + "_out_.pdf", FileMode.Create)
                aStream.WriteTo(outStream)
                outStream.Close()
                fileNumber += 1
            Next
            ' ExEnd:SplitToIndividualPagesUsingPaths
        End Sub
    End Class
End Namespace

