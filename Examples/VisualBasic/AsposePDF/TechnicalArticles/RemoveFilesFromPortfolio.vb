Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePDF.TechnicalArticles
    Public Class RemoveFilesFromPortfolio
        Public Shared Sub Run()
            ' ExStart:RemoveFilesFromPortfolio
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_TechnicalArticles()

            ' Load source PDF Portfolio
            Dim pdfDocument As New Aspose.Pdf.Document(dataDir & "PDFPortfolio.pdf")
            pdfDocument.Collection.Delete()
            pdfDocument.Save(dataDir & "No_PortFolio_out_.pdf")
            ' ExEnd:RemoveFilesFromPortfolio                      
        End Sub
    End Class
End Namespace
