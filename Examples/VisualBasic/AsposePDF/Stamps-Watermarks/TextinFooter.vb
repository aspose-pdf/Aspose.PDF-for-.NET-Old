Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.StampsWatermarks
    Public Class TextinFooter
        Public Shared Sub Run()
            ' ExStart:TextinFooter
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("TextinFooter.pdf"))
            ' Create footer
            Dim textStamp As New TextStamp("Footer Text")
            ' Set properties of the stamp
            textStamp.BottomMargin = 10
            textStamp.HorizontalAlignment = HorizontalAlignment.Center
            textStamp.VerticalAlignment = VerticalAlignment.Bottom
            ' Add footer on all pages
            For Each page As Page In pdfDocument.Pages
                page.AddStamp(textStamp)
            Next
            dataDir = dataDir & Convert.ToString("TextinFooter_out_.pdf")
            ' Save updated PDF file
            pdfDocument.Save(dataDir)
            ' ExEnd:TextinFooter
            Console.WriteLine(Convert.ToString(vbLf & "Text in footer added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
