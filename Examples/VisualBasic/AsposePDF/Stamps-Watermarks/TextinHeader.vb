Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.StampsWatermarks
    Public Class TextinHeader
        Public Shared Sub Run()
            ' ExStart:TextinHeader
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("TextinHeader.pdf"))

            ' Create header
            Dim textStamp As New TextStamp("Header Text")
            ' Set properties of the stamp
            textStamp.TopMargin = 10
            textStamp.HorizontalAlignment = HorizontalAlignment.Center
            textStamp.VerticalAlignment = VerticalAlignment.Top
            ' Add header on all pages
            For Each page As Page In pdfDocument.Pages
                page.AddStamp(textStamp)
            Next

            ' Save updated document
            pdfDocument.Save(dataDir & Convert.ToString("TextinHeader_out_.pdf"))
            ' ExEnd:TextinHeader
            Console.WriteLine(Convert.ToString(vbLf & "Text in header added successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
