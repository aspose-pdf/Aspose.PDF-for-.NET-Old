Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.WorkingDocuments
    Public Class OptimizeFileSize
        Public Shared Sub Run()
            ' ExStart:OptimizeFileSize
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("OptimizeDocument.pdf"))

            ' Optimzie the file size by removing unused objects
            pdfDocument.OptimizeResources(New Document.OptimizationOptions() With {
                 .LinkDuplcateStreams = True,
                 .RemoveUnusedObjects = True,
                 .RemoveUnusedStreams = True,
                 .CompressImages = True,
                 .ImageQuality = 10
            })
            dataDir = dataDir & Convert.ToString("OptimizeFileSize_out_.pdf")
            ' Save output document
            pdfDocument.Save(dataDir)
            ' ExEnd:OptimizeFileSize
            Console.WriteLine(Convert.ToString(vbLf & "File size optimized successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
