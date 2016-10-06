Imports System.IO
Imports System
Imports System.Collections
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Annotations

Namespace AsposePDFFacades.TechnicalArticles
    Public Class PdfExtractorFeatures
        Public Shared Sub Run()
            ' ExStart:PdfExtractorFeatures
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Create an instance of PdfExtractor class
            Dim extractor As New PdfExtractor()

            ' Set PDF file password
            extractor.Password = ""
            ' Specify start and end pages of the PDF
            extractor.StartPage = 1
            extractor.EndPage = 10

            ' Bind PDF file with the extractor object
            extractor.BindPdf(dataDir & Convert.ToString("inFile.pdf"))
            ' Extract all text from the PDF
            extractor.ExtractText()
            ' Save extracted text in a text file
            extractor.GetText(dataDir & Convert.ToString("PdfExtractorFeatures_text_out_.txt"))

            ' Text of individual pages can also be saved individually in single text files
            If extractor.HasNextPageText() Then
                extractor.GetNextPageText((dataDir & DateTime.Now.Ticks.ToString()) + "_out_.txt")
            End If

            ' Extract images from PDF file
            extractor.ExtractImage()
            ' Save each individual image in an image file
            If extractor.HasNextImage() Then
                extractor.GetNextImage((dataDir & DateTime.Now.Ticks.ToString()) + "_out_.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            End If

            ' Extract attachments
            extractor.ExtractAttachment()
            extractor.GetAttachment(dataDir)
            ' ExEnd:PdfExtractorFeatures                      
        End Sub
    End Class
End Namespace
