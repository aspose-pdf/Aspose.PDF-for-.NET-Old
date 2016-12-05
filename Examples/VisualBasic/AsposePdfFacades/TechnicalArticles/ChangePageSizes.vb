Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.TechnicalArticles
    Public Class ChangePageSizes
        Public Shared Sub Run()
            ' ExStart:ChangePageSizes
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Create PdfPageEditor object
            Dim pEdit As New PdfPageEditor()

            ' Bind pdf file
            pEdit.BindPdf(dataDir & Convert.ToString("FilledForm.pdf"))

            ' Change page size of the selected pages
            pEdit.ProcessPages = New Integer() {1}

            ' Here we select a member named ' LETTER' From the list of members of PageSize class and assign it to PageSize property of the PdfPageEditor class
            pEdit.PageSize = PageSize.PageLetter

            ' Save the file
            pEdit.Save(dataDir & Convert.ToString("ChangePageSizes_out_.pdf"))

            ' Find at what size a page has been assigned
            pEdit.BindPdf(dataDir & Convert.ToString("FilledForm.pdf"))
            Dim size As PageSize = pEdit.GetPageSize(1)
            pEdit = Nothing
            ' ExEnd:ChangePageSizes                      
        End Sub
    End Class
End Namespace
