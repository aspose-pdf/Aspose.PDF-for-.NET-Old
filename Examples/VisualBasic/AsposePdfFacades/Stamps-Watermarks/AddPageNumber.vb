Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Drawing

Namespace AsposePDFFacades.StampsWatermarks
    Public Class AddPageNumber
        Public Shared Sub Run()
            ' ExStart:AddPageNumber
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks()

            ' Create PdfFileStamp object
            Dim fileStamp As New PdfFileStamp()

            ' Open Document
            fileStamp.BindPdf(dataDir & Convert.ToString("AddPageNumber.pdf"))

            ' Get total number of pages
            Dim totalPages As Integer = New PdfFileInfo(dataDir & Convert.ToString("AddPageNumber.pdf")).NumberOfPages

            ' Create formatted text for page number
            Dim formattedText As New FormattedText("Page # Of " + totalPages.ToString(), System.Drawing.Color.Blue, System.Drawing.Color.Gray, Aspose.Pdf.Facades.FontStyle.Courier, EncodingType.Winansi, False, _
                14)

            ' Set starting number for first page; you might want to start from 2 or more
            fileStamp.StartingNumber = 1

            ' Add page number
            fileStamp.AddPageNumber(formattedText, 0)

            ' Save updated PDF file
            fileStamp.Save(dataDir & Convert.ToString("AddPageNumber_out_.pdf"))

            ' Close fileStamp
            fileStamp.Close()
            ' ExEnd:AddPageNumber

        End Sub
    End Class
End Namespace