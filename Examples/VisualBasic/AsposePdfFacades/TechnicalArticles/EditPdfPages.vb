Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.TechnicalArticles
    Public Class EditPdfPages
        Public Shared Sub Run()
            ' ExStart:EditPdfPages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Create a new instance of PdfPageEditor class
            Dim pEditor As New Aspose.Pdf.Facades.PdfPageEditor()
            ' Bind an existing pdf file
            pEditor.BindPdf(dataDir & Convert.ToString("FilledForm.pdf"))
            ' Specify an array of pages which need to be manipulated pages can be multiple, here we have specified only one page
            pEditor.ProcessPages = New Integer() {1}

            'alignment related code

            ' Horizontal alignment
            pEditor.HorizontalAlignment = HorizontalAlignment.Right

            ' Specify transition type for the pages
            pEditor.TransitionType = 2
            'specify transition duration
            pEditor.TransitionDuration = 5

            ' Display related code

            ' Select a page size from the enumeration and assign to property
            pEditor.PageSize = PageSize.PageLedger
            ' Assign page rotation
            pEditor.Rotation = 90
            ' Specify zoom factor for the page
            pEditor.Zoom = 100
            ' Assign display duration for the page
            pEditor.DisplayDuration = 5

            ' Methods provided by the class page rotation specified already can be fetched using this method
            Dim rotation As Integer = pEditor.GetPageRotation(1)
            ' Already specified page can be fetched with the help of this method
            Dim pagesize__1 As PageSize = pEditor.GetPageSize(1)
            ' This method gets the page count
            Dim totalpages As Integer = pEditor.GetPages()
            ' This method changes the origin from (0,0) to specified number
            pEditor.MovePosition(100, 100)

            ' Finally save the output file
            pEditor.Save(dataDir & Convert.ToString("EditPdfPages_out_.pdf"))
            ' ExEnd:EditPdfPages                      
        End Sub
    End Class
End Namespace

