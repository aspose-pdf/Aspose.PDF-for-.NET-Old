Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Drawing

Namespace AsposePDFFacades.StampsWatermarks
    Public Class AddTextStampAll
        Public Shared Sub Run()
            ' ExStart:AddTextStampAll
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks()

            ' Create PdfFileStamp object
            Dim fileStamp As New PdfFileStamp()

            ' Open Document
            fileStamp.BindPdf(dataDir & Convert.ToString("AddTextStampAll.pdf"))

            ' Create stamp
            Dim stamp As New Aspose.Pdf.Facades.Stamp()
            stamp.BindLogo(New FormattedText("Hello World!", System.Drawing.Color.Blue, System.Drawing.Color.Gray, Aspose.Pdf.Facades.FontStyle.Helvetica, EncodingType.Winansi, True, _
                14))
            stamp.SetOrigin(200, 200)
            stamp.Rotation = 90.0F
            stamp.IsBackground = True

            ' Add stamp to PDF file
            fileStamp.AddStamp(stamp)

            ' Save updated PDF file
            fileStamp.Save(dataDir & Convert.ToString("AddTextStampAll_out_.pdf"))

            'close fileStamp
            fileStamp.Close()
            ' ExEnd:AddTextStampAll
        End Sub
    End Class
End Namespace