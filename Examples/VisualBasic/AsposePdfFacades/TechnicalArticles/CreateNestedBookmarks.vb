Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.TechnicalArticles
    Public Class CreateNestedBookmarks
        Public Shared Sub Run()
            ' ExStart:CreateNestedBookmarks
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' New a object of Class PdfContentEditor
            Dim editor As New PdfContentEditor()
            editor.BindPdf(dataDir + "inFile.pdf")
            ' Creating child items of a chapter, in this example, the first child item also include a child item.
            Dim bm11 As New Bookmark()
            ' Set the action type of BookMark
            bm11.Action = "GoTo"
            ' Set the BookMark Destination page
            bm11.PageNumber = 3
            ' Set the BookMark title. 
            bm11.Title = "Section - 1.1.1"

            Dim bm1 As New Bookmark()
            bm1.Action = "GoTo"
            bm1.PageNumber = 2
            bm1.Title = "Section - 1.1"

            Dim bms1 As New Aspose.Pdf.Facades.Bookmarks()
            bms1.Add(bm11)
            bm1.ChildItems = bms1

            ' Creating a child item of a chapter.
            Dim bm2 As New Bookmark()
            bm2.Action = "GoTo"
            bm2.PageNumber = 4
            bm2.Title = "Section - 1.2"

            ' Creating a chapter (Parent Level Bookmark)
            Dim bm As New Bookmark()
            bm.Action = "GoTo"
            bm.PageNumber = 1
            bm.Title = "Chapter - 1"

            Dim bms As New Aspose.Pdf.Facades.Bookmarks()
            ' Add the Section - 1.1, bookmark to bookmarks collection
            bms.Add(bm1)
            ' Add the Section - 1.2, bookmark to bookmarks collection
            bms.Add(bm2)
            ' Add the Bookmarks collection as child_Item of Chapter_Level bookmark
            bm.ChildItems = bms

            ' Creating a chapter (Parent Level Bookmark)
            Dim bm_parent2 As New Bookmark()
            bm_parent2.Action = "GoTo"
            bm_parent2.PageNumber = 5
            bm_parent2.Title = "Chapter - 2"

            ' Creating a child item of a chapter.
            Dim bm22 As New Bookmark()
            bm22.Action = "GoTo"
            bm22.PageNumber = 6
            bm22.Title = "Section - 2.1"

            Dim bms_parent2 As New Aspose.Pdf.Facades.Bookmarks()
            ' Add the Section - 2.1, bookmark to bookmarks collection
            bms_parent2.Add(bm22)
            ' Add the Bookmarks collection as child_Item of Chapter2_Level bookmark
            bm_parent2.ChildItems = bms_parent2

            ' Saves the result PDF to file
            editor.Save(dataDir & Convert.ToString("Nested_BookMarks_out_.pdf"))
            ' ExEnd:CreateNestedBookmarks                      
        End Sub
    End Class
End Namespace
