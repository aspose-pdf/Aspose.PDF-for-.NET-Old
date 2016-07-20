Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.StampsWatermarks
    Public Class AddImageStampAll
        Public Shared Sub Run()
            ' ExStart:AddImageStampAll
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks()

            ' Create PdfFileStamp object
            Dim fileStamp As New PdfFileStamp()

            ' Open Document
            fileStamp.BindPdf(dataDir & Convert.ToString("AddImageStampAll.pdf"))

            ' Create stamp
            Dim stamp As New Global.Aspose.Pdf.Facades.Stamp()
            stamp.BindImage(dataDir & Convert.ToString("aspose-logo.jpg"))
            stamp.SetOrigin(200, 200)
            stamp.Rotation = 90.0F
            stamp.IsBackground = True

            ' Add stamp to PDF file
            fileStamp.AddStamp(stamp)

            ' Save updated PDF file
            fileStamp.Save(dataDir & Convert.ToString("AddImageStampAll_out_.pdf"))

            ' Close fileStamp
            fileStamp.Close()
            ' ExEnd:AddImageStampAll

        End Sub
    End Class
End Namespace
