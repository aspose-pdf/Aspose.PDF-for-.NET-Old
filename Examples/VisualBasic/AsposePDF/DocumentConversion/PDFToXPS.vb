Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion
    Public Class PDFToXPS
        Public Shared Sub Run()
            ' ExStart:PDFToXPS
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Load PDF document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("input.pdf"))

            ' Instantiate XPS Save options
            Dim saveOptions As New XpsSaveOptions()

            ' Save the XPS document
            pdfDocument.Save("PDFToXPS_out_.xps", saveOptions)
            ' ExEnd:PDFToXPS
        End Sub
    End Class
End Namespace
