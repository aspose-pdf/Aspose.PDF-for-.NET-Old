Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePDF.WorkingDocuments
    Public Class GetDocumentWindow
        Public Shared Sub Run()
            ' ExStart:GetDocumentWindow
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("GetDocumentWindow.pdf"))

            ' Get different document properties
            ' Position of document's window - Default: false
            Console.WriteLine("CenterWindow : {0}", pdfDocument.CenterWindow)

            ' Predominant reading order; determins the position of page
            ' When displayed side by side - Default: L2R
            Console.WriteLine("Direction : {0}", pdfDocument.Direction)

            ' Whether window's title bar should display document title
            ' If false, title bar displays PDF file name - Default: false
            Console.WriteLine("DisplayDocTitle : {0}", pdfDocument.DisplayDocTitle)

            ' Whether to resize the document's window to fit the size of
            ' First displayed page - Default: false
            Console.WriteLine("FitWindow : {0}", pdfDocument.FitWindow)

            ' Whether to hide menu bar of the viewer application - Default: false
            Console.WriteLine("HideMenuBar : {0}", pdfDocument.HideMenubar)

            ' Whether to hide tool bar of the viewer application - Default: false
            Console.WriteLine("HideToolBar : {0}", pdfDocument.HideToolBar)

            ' Whether to hide UI elements like scroll bars
            ' And leaving only the page contents displayed - Default: false
            Console.WriteLine("HideWindowUI : {0}", pdfDocument.HideWindowUI)

            ' Document's page mode. How to display document on exiting full-screen mode.
            Console.WriteLine("NonFullScreenPageMode : {0}", pdfDocument.NonFullScreenPageMode)

            ' The page layout i.e. single page, one column
            Console.WriteLine("PageLayout : {0}", pdfDocument.PageLayout)

            ' How the document should display when opened
            ' i.e. show thumbnails, full-screen, show attachment panel
            Console.WriteLine("pageMode : {0}", pdfDocument.PageMode)
            ' ExEnd:GetDocumentWindow
        End Sub
    End Class
End Namespace
