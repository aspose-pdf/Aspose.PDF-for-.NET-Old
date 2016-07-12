Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.WorkingDocuments
    Public Class SetDocumentWindow
        Public Shared Sub Run()
            ' ExStart:SetDocumentWindow
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("SetDocumentWindow.pdf"))

            ' Set different document properties
            ' Sepcify to position document's window - Default: false
            pdfDocument.CenterWindow = True

            ' Predominant reading order; determins the position of page
            ' When displayed side by side - Default: L2R
            pdfDocument.Direction = Direction.R2L

            ' Specify whether window's title bar should display document title
            ' If false, title bar displays PDF file name - Default: false
            pdfDocument.DisplayDocTitle = True

            ' Specify whether to resize the document's window to fit the size of
            ' First displayed page - Default: false
            pdfDocument.FitWindow = True

            ' Specify whether to hide menu bar of the viewer application - Default: false
            pdfDocument.HideMenubar = True

            ' Specify whether to hide tool bar of the viewer application - Default: false
            pdfDocument.HideToolBar = True

            ' Specify whether to hide UI elements like scroll bars
            ' And leaving only the page contents displayed - Default: false
            pdfDocument.HideWindowUI = True

            ' Document's page mode. specify how to display document on exiting full-screen mode.
            pdfDocument.NonFullScreenPageMode = PageMode.UseOC

            ' Specify the page layout i.e. single page, one column
            pdfDocument.PageLayout = PageLayout.TwoColumnLeft

            ' Specify how the document should display when opened
            ' i.e. show thumbnails, full-screen, show attachment panel
            pdfDocument.PageMode = PageMode.UseThumbs

            dataDir = dataDir & Convert.ToString("SetDocumentWindow_out_.pdf")
            ' Save updated PDF file
            pdfDocument.Save(dataDir)
            ' ExEnd:SetDocumentWindow 
            Console.WriteLine(Convert.ToString(vbLf & "Document window and page display properties setup successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
