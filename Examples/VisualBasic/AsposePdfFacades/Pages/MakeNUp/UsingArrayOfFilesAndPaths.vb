Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.MakeNUp
    Public Class UsingArrayOfFilesAndPaths
        Public Shared Sub Run()
            ' ExStart:UsingArrayOfFilesAndPaths
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create array of files
            Dim filesArray As String() = New String(1) {}
            filesArray(0) = dataDir & Convert.ToString("input.pdf")
            filesArray(1) = dataDir & Convert.ToString("input2.pdf")
            ' Make NUp
            pdfEditor.MakeNUp(filesArray, dataDir & Convert.ToString("UsingArrayOfFilesAndPaths_out_.pdf"), True)
            ' ExEnd:UsingArrayOfFilesAndPaths
        End Sub
    End Class
End Namespace

