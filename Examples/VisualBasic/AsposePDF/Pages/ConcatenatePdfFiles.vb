Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.Pages
    Public Class ConcatenatePdfFiles
        Public Shared Sub Run()
            ' ExStart:ConcatenatePdfFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            ' Open first document
            Dim pdfDocument1 As New Document(dataDir & Convert.ToString("Concat1.pdf"))
            ' Open second document
            Dim pdfDocument2 As New Document(dataDir & Convert.ToString("Concat2.pdf"))

            ' Add pages of second document to the first
            pdfDocument1.Pages.Add(pdfDocument2.Pages)

            dataDir = dataDir & Convert.ToString("ConcatenatePdfFiles_out_.pdf")
            ' Save concatenated output file
            pdfDocument1.Save(dataDir)
            ' ExEnd:ConcatenatePdfFiles
            System.Console.WriteLine(Convert.ToString(vbLf & "PDFs are concatenated successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
