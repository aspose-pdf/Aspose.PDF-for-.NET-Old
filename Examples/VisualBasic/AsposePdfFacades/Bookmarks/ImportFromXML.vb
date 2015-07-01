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
    Public Class ImportFromXML
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            'create PdfBookmarkEditor class
            Dim bookmarkEditor As New PdfBookmarkEditor()
            'open PDF file
            bookmarkEditor.BindPdf(dataDir & "ImportFromXML.pdf")
            'import bookmarks
            bookmarkEditor.ImportBookmarksWithXML(dataDir & "bookmarks.xml")
            'save updated PDF file
            bookmarkEditor.Save(dataDir & "ImportFromXML_out.pdf")



        End Sub
    End Class
End Namespace