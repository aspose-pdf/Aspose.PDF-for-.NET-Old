Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.DocumentConversion
    Public Class PDFAToPDF
        Public Shared Sub Run()
            ' ExStart:PDFAToPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()
            ' Open document
            Dim doc As New Document(dataDir & Convert.ToString("PDFAToPDF.pdf"))
            ' Remove PDF/A compliance information
            doc.RemovePdfaCompliance()
            ' Save updated document 
            doc.Save(dataDir & Convert.ToString("PDFAToPDF_out_.pdf"))
            ' ExEnd:PDFAToPDF
        End Sub
    End Class
End Namespace
