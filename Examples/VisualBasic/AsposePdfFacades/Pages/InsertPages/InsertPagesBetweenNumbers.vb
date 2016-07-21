Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.InsertPages
    Public Class InsertPagesBetweenNumbers
        Public Shared Sub Run()
            ' ExStart:InsertPagesBetweenNumbers
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Insert pages
            pdfEditor.Insert(dataDir & Convert.ToString("MultiplePages.pdf"), 1, dataDir & Convert.ToString("InsertPages.pdf"), 2, 5, dataDir & Convert.ToString("InsertPagesBetweenNumbers_out_.pdf"))
            ' ExEnd:InsertPagesBetweenNumbers
        End Sub
    End Class
End Namespace
