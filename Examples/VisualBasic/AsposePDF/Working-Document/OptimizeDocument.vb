Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.WorkingDocuments
    Public Class OptimizeDocument
        Public Shared Sub Run()
            ' ExStart:OptimizeDocument
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("OptimizeDocument.pdf"))

            ' Optimize for web
            pdfDocument.Optimize()

            dataDir = dataDir & Convert.ToString("OptimizeDocument_out_.pdf")

            ' Save output document
            pdfDocument.Save(dataDir)
            ' ExEnd:OptimizeDocument
            Console.WriteLine(Convert.ToString(vbLf & "Document optimized successfully for web." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace

