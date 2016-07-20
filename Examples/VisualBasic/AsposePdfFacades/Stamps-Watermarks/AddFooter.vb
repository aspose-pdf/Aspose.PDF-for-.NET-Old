Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Drawing

Namespace AsposePDFFacades.StampsWatermarks
    Public Class AddFooter
        Public Shared Sub Run()
            ' ExStart:AddFooter
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks()

            ' Create PdfFileStamp object
            Dim fileStamp As New PdfFileStamp()

            ' Open Document
            fileStamp.BindPdf(dataDir & Convert.ToString("AddFooter.pdf"))

            ' Create formatted text for page number
            Dim formattedText As New FormattedText("Aspose - Your File Format Experts!", System.Drawing.Color.Blue, System.Drawing.Color.Gray, Aspose.Pdf.Facades.FontStyle.Courier, EncodingType.Winansi, False, _
                14)

            ' Add footer
            fileStamp.AddFooter(formattedText, 10)

            ' Save updated PDF file
            fileStamp.Save(dataDir & Convert.ToString("AddFooter_out_.pdf"))

            ' Close fileStamp
            fileStamp.Close()
            ' ExEnd:AddFooter
        End Sub
    End Class
End Namespace