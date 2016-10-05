Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.TechnicalArticles
    Public Class RotatingStamp
        Public Shared Sub Run()
            ' ExStart:RotatingStamp
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Set path of the image to be set as watermark
            Dim imageFile As String = dataDir & Convert.ToString("aspose-logo.jpg")

            ' Set input file path
            Dim inFile As String = dataDir & Convert.ToString("inFile.pdf")

            ' Set output file path
            Dim outFile As String = dataDir & Convert.ToString("RotatingStamp_out_.pdf")

            ' Create PdfFileInfo object to get height and width of the pages
            Dim fileInfo As New PdfFileInfo(inFile)

            ' Create Stamp object
            Dim aStamp As New Aspose.Pdf.Facades.Stamp()

            ' Bind image file with the Stamp object
            aStamp.BindImage(imageFile)

            ' Specify whether the stamp will be added as a background or not
            aStamp.IsBackground = False

            ' Specifies at which pages to add the watermark
            aStamp.Pages = New Integer() {1}

            ' Specifies the watermark rotation - rotate at 90 degrees the stamp is rotated about the center point of the stamp object
            aStamp.Rotation = 90

            ' Specifies the position of stamp - lower left corner of the stamp
            aStamp.SetOrigin(fileInfo.GetPageWidth(1) / 2, fileInfo.GetPageHeight(1) / 2)

            ' Set the size of the watermark
            aStamp.SetImageSize(100, 100)

            ' Create PdfFileStamp class to bind input and output files
            Dim stamper As New PdfFileStamp(inFile, outFile)

            ' Add the stamp in the PDF file
            stamper.AddStamp(aStamp)

            ' Close the PdfFileStamp object
            stamper.Close()
            ' ExEnd:RotatingStamp                      
        End Sub
    End Class
End Namespace
