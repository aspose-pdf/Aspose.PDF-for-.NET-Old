Imports System.IO
Imports System
Imports System.Collections
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.TechnicalArticles
    Public Class PageRotation
        Public Shared Sub Run()
            ' ExStart:PageRotation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Create PdfPageEditor object
            Dim pEdit As New PdfPageEditor()

            ' Rotate odd pages at 180 degrees
            pEdit.BindPdf(dataDir & Convert.ToString("inFile1.pdf"))
            pEdit.ProcessPages = New Integer() {1}
            pEdit.Rotation = 180
            pEdit.Save(dataDir & Convert.ToString("Aspose.Pdf.Facades_rotate_180_out_.pdf"))

            ' Rotate even pages at 270 degrees
            pEdit.BindPdf(dataDir & Convert.ToString("inFile2.pdf"))
            pEdit.ProcessPages = New Integer() {1}
            pEdit.Rotation = 270
            pEdit.Save(dataDir & Convert.ToString("Aspose.Pdf.Facades_rotate_270_out_.pdf"))

            ' Find at what degrees a page was rotated
            pEdit.BindPdf(dataDir & Convert.ToString("inFile.pdf"))
            Dim degrees As Integer = pEdit.GetPageRotation(1)
            pEdit = Nothing
            ' ExEnd:PageRotation                      
        End Sub
    End Class
End Namespace

