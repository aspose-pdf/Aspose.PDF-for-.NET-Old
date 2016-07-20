Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.StampsWatermarks
    Public Class AddPageStampPage
        Public Shared Sub Run()
            ' ExStart:AddPageStampPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks()

            ' Create PdfFileStamp object
            Dim fileStamp As New PdfFileStamp()

            ' Open Document
            fileStamp.BindPdf(dataDir & Convert.ToString("AddPageStamp-Page.pdf"))

            ' Create stamp
            Dim stamp As New Global.Aspose.Pdf.Facades.Stamp()
            stamp.BindPdf(dataDir & Convert.ToString("temp.pdf"), 1)
            stamp.SetOrigin(200, 200)
            stamp.Rotation = 90.0F
            stamp.IsBackground = True

            ' Set particular pages
            stamp.Pages = New Integer() {2}

            ' Add stamp to PDF file
            fileStamp.AddStamp(stamp)

            ' Save updated PDF file
            fileStamp.Save(dataDir & Convert.ToString("AddPageStamp-Page_out_.pdf"))

            ' Close fileStamp
            fileStamp.Close()
            ' ExEnd:AddPageStampPage

        End Sub
    End Class
End Namespace
