Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePDF.Pages
    Public Class SplitToPages
        Public Shared Sub Run()
            ' ExStart:SplitToPages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("SplitToPages.pdf"))

            Dim pageCount As Integer = 1

            ' Loop through all the pages
            For Each pdfPage As Page In pdfDocument.Pages
                Dim newDocument As New Document()
                newDocument.Pages.Add(pdfPage)
                newDocument.Save((dataDir & Convert.ToString("page_")) + pageCount.ToString() + "_out_" + ".pdf")
                pageCount += 1
            Next
            ' ExEnd:SplitToPages       

        End Sub
    End Class
End Namespace
