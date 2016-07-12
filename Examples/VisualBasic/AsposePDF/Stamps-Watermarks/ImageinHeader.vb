Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.StampsWatermarks
    Public Class ImageinHeader
        Public Shared Sub Run()
            ' ExStart:ImageinHeader
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("ImageinHeader.pdf"))

            ' Create header
            Dim imageStamp As New ImageStamp(dataDir & Convert.ToString("aspose-logo.jpg"))
            ' Set properties of the stamp
            imageStamp.TopMargin = 10
            imageStamp.HorizontalAlignment = HorizontalAlignment.Center
            imageStamp.VerticalAlignment = VerticalAlignment.Top
            ' Add header on all pages
            For Each page As Page In pdfDocument.Pages
                page.AddStamp(imageStamp)
            Next
            dataDir = dataDir & Convert.ToString("ImageinHeader_out_.pdf")
            ' Save updated document
            pdfDocument.Save(dataDir)
            ' ExEnd:ImageinHeader
            Console.WriteLine(Convert.ToString(vbLf & "Image in header added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace

