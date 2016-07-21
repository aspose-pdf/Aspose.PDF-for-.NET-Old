Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.Append
    Public Class AppendFilesUsingStreams
        Public Shared Sub Run()
            ' ExStart:AppendFilesUsingStreams
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create streams
            Dim inputStream As New FileStream(dataDir & Convert.ToString("input.pdf"), FileMode.Open)
            Dim portStream As New FileStream(dataDir & Convert.ToString("input2.pdf"), FileMode.Open)
            Dim outputStream As New FileStream(dataDir & Convert.ToString("AppendFilesUsingStreams_out_.pdf"), FileMode.Create)
            ' Append file
            pdfEditor.Append(inputStream, portStream, 1, 1, outputStream)
            ' ExEnd:AppendFilesUsingStreams
        End Sub
    End Class
End Namespace
