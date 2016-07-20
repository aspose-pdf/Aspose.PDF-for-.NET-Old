Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.StampsWatermarks
    Public Class ImageInFooter
        Public Shared Sub Run()
            ' ExStart:ImageInFooter
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("ImageInFooter.pdf"))
            ' Create footer
            Dim imageStamp As New ImageStamp(dataDir & Convert.ToString("aspose-logo.jpg"))
            ' Set properties of the stamp
            imageStamp.BottomMargin = 10
            imageStamp.HorizontalAlignment = HorizontalAlignment.Center
            imageStamp.VerticalAlignment = VerticalAlignment.Bottom
            ' Add footer on all pages
            For Each page As Page In pdfDocument.Pages
                page.AddStamp(imageStamp)
            Next
            dataDir = dataDir & Convert.ToString("ImageInFooter_out_.pdf")
            ' Save updated PDF file
            pdfDocument.Save(dataDir)
            ' ExEnd:ImageInFooter
            Console.WriteLine(Convert.ToString(vbLf & "Image in footer added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace

