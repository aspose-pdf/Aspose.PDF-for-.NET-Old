Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.Append
    Public Class AppendArrayOfFiles
        Public Shared Sub Run()
            ' ExStart:AppendArrayOfFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Array of files
            Dim portFiles As String() = New String(1) {}
            portFiles(0) = dataDir & Convert.ToString("input.pdf")
            portFiles(1) = dataDir & Convert.ToString("input2.pdf")
            ' Append file
            pdfEditor.Append(dataDir & Convert.ToString("input3.pdf"), portFiles, 1, 1, dataDir & Convert.ToString("AppendArrayOfFiles_out_.pdf"))
            ' ExEnd:AppendArrayOfFiles
        End Sub
    End Class
End Namespace
