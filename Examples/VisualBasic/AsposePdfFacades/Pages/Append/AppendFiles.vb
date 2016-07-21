Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.Append
    Public Class AppendFiles
        Public Shared Sub Run()
            ' ExStart:AppendFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Append file
            pdfEditor.Append(dataDir & Convert.ToString("input.pdf"), dataDir & Convert.ToString("input2.pdf"), 1, 1, dataDir & Convert.ToString("AppendFiles_out_.pdf"))
            ' ExEnd:AppendFiles
        End Sub
    End Class
End Namespace
