'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace VisualBasic.AsposePDFFacades.Bookmarks
    Public Class CreateBookmarksPagesProperties
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            'open document
            Dim bookmarkEditor As New PdfBookmarkEditor()
            bookmarkEditor.BindPdf(dataDir & "CreateBookmarks-PagesProperties.pdf")
            'create bookmark of all pages
            bookmarkEditor.CreateBookmarks(System.Drawing.Color.Green, True, True)
            'save updated PDF file
            bookmarkEditor.Save(dataDir & "CreateBookmarks-PagesProperties_out.pdf")


        End Sub
    End Class
End Namespace