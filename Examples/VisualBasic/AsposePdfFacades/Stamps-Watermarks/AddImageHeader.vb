Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.StampsWatermarks
    Public Class AddImageHeader
        Public Shared Sub Run()
            ' ExStart:AddImageHeader
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks()

            ' Create PdfFileStamp object
            Dim fileStamp As New PdfFileStamp()

            ' Open Document
            fileStamp.BindPdf(dataDir & Convert.ToString("AddImage-Header.pdf"))

            ' Add Header
            fileStamp.AddHeader(New FileStream(dataDir & Convert.ToString("aspose-logo.jpg"), FileMode.Open), 10)

            ' Save updated PDF file
            fileStamp.Save(dataDir & Convert.ToString("AddImage-Header_out_.pdf"))

            ' Close fileStamp
            fileStamp.Close()
            ' ExEnd:AddImageHeader

        End Sub
    End Class
End Namespace
