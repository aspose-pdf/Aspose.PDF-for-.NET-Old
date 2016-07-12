Imports System.IO
Imports System
Imports Aspose.Pdf
Imports System.Web
Namespace AsposePdfGenerator.AdvanceFeatures
    Public Class SendingPdfToBrowser
        Public Shared Sub Run()
            ' ExStart:SendingPdfToBrowser
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_AdvanceFeatures()

            ' Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            Dim stream As New MemoryStream()
            Dim Response As New HttpResponse(Nothing)
            pdf1.Save(stream)
            Response.Clear()
            Response.ClearHeaders()
            Response.ClearContent()
            Response.Charset = "UTF-8"
            Response.AddHeader("Content-Length", stream.Length.ToString())
            Response.AddHeader("content-disposition", [String].Format("attachment;filename={0}", dataDir & Convert.ToString("SendingPdfToBrowser.pdf")))
            Response.ContentType = "application/pdf"
            Response.BinaryWrite(stream.ToArray())
            Response.Flush()
            Response.[End]()
            ' ExEnd:SendingPdfToBrowser           
        End Sub
    End Class
End Namespace