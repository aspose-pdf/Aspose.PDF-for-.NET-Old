Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePDF.StampsWatermarks
    Public Class GetWatermark
        Public Shared Sub Run()
            ' ExStart:GetWatermark
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("watermark.pdf"))
            ' Iterate through and get tub-type, text and location of artifact
            For Each artifact As Artifact In pdfDocument.Pages(1).Artifacts
                Console.WriteLine(artifact.Subtype.ToString() + " " + artifact.Text.ToString() + " " + artifact.Rectangle.ToString())
            Next
            ' ExEnd:GetWatermark            
        End Sub
    End Class
End Namespace
