Imports System.IO
Imports System
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Annotations

Namespace AsposePDFFacades.TechnicalArticles
    Public Class AddTextImagesUsingPdfFileMend
        Public Shared Sub Run()
            ' ExStart:AddTextImagesUsingPdfFileMend
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Specify input and output PDF file paths
            Dim inputFile As String = dataDir & Convert.ToString("inFile.pdf")
            Dim outputFile As String = dataDir & Convert.ToString("AddTextImagesUsingPdfFileMend_out_.pdf")

            ' Specify image file path
            Dim imageName As String = dataDir & Convert.ToString("aspose-logo.jpg")

            ' Create file streams for all of the files to be used in the example           
            Dim inImgStream As New FileStream(imageName, FileMode.Open)
            Dim outputStream As New FileStream(outputFile, FileMode.Create)

            Dim doc As New Document(inputFile)
            ' Create instance of PdfFileMend class
            Dim mendor As New PdfFileMend(doc)

            ' Add image to the input PDF file on page number 1 at specified location
            mendor.AddImage(inImgStream, 1, 50, 50, 100, 100)

            ' Create new FormattedText type object to add text in the PDF file
            Dim ft As New FormattedText("PdfFileMend testing! 0 rotation.", System.Drawing.Color.FromArgb(0, 200, 0), FontStyle.TimesRoman, EncodingType.Winansi, False, 12)

            ' Add text in the existing PDF file
            mendor.AddText(ft, 1, 50, 100, 100, 200)

            ' Claose the PdfFileMend type object
            mendor.Close()
            ' Close output file stream
            outputStream.Close()
            ' ExEnd:AddTextImagesUsingPdfFileMend                      
        End Sub
    End Class
End Namespace
