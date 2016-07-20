Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.StampsWatermarks
    Public Class AddImageFooter
        Public Shared Sub Run()
            ' ExStart:AddImageFooter
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks()

            ' Create PdfFileStamp object
            Dim fileStamp As New PdfFileStamp()

            ' Open Document
            fileStamp.BindPdf(dataDir & Convert.ToString("AddImage-Footer.pdf"))

            ' Add footer
            fileStamp.AddFooter(New FileStream(dataDir & Convert.ToString("aspose-logo.jpg"), FileMode.Open), 10)

            ' Save updated PDF file
            fileStamp.Save(dataDir & Convert.ToString("AddImage-Footer_out_.pdf"))

            ' Close fileStamp
            fileStamp.Close()
            ' ExEnd:AddImageFooter

        End Sub
    End Class
End Namespace
