Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.Append
    Public Class AppendArrayOfFilesUsingStream
        Public Shared Sub Run()
            ' ExStart:AppendArrayOfFilesUsingStream
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Input and output stream
            Dim inputStream As New FileStream(dataDir & Convert.ToString("inputvb.pdf"), FileMode.Open)
            Dim outputStream As New FileStream(dataDir & Convert.ToString("AppendArrayOfFilesUsingStream_out_.pdf"), FileMode.Create)
            ' Srray of streams
            Dim portStreams As FileStream() = New FileStream(1) {}
            portStreams(0) = New FileStream(dataDir & Convert.ToString("input2vb.pdf"), FileMode.Open)
            portStreams(1) = New FileStream(dataDir & Convert.ToString("input3vb.pdf"), FileMode.Open)

            'Append file
            pdfEditor.Append(inputStream, portStreams, 1, 1, outputStream)
            ' ExEnd:AppendArrayOfFilesUsingStream
        End Sub
    End Class
End Namespace
