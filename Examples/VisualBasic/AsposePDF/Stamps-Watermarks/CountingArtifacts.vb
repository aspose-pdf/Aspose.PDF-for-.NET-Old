Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePDF.StampsWatermarks
    Public Class CountingArtifacts
        Public Shared Sub Run()
            ' ExStart:CountingArtifacts
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("watermark.pdf"))
            Dim count As Integer = 0
            For Each artifact__1 As Artifact In pdfDocument.Pages(1).Artifacts
                ' If artifact type is watermark, increate the counter
                If artifact__1.Subtype = Artifact.ArtifactSubtype.Watermark Then
                    count += 1
                End If
            Next
            Console.WriteLine("Page contains " + count.ToString() + " watermarks")
            ' ExEnd:CountingArtifacts            
        End Sub
    End Class
End Namespace
