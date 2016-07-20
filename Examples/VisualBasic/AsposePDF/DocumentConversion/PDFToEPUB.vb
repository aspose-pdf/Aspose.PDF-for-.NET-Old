Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion
    Public Class PDFToEPUB
        Public Shared Sub Run()
            ' ExStart:PDFToEPUB
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Load PDF document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("PDFToEPUB.pdf"))

            ' Instantiate Epub Save options
            Dim options As New EpubSaveOptions()

            ' Specify the layout for contents
            options.ContentRecognitionMode = EpubSaveOptions.RecognitionMode.Flow

            ' Save the ePUB document
            pdfDocument.Save(dataDir & Convert.ToString("PDFToEPUB_out_.epub"), options)
            ' ExEnd:PDFToEPUB
        End Sub
    End Class
End Namespace