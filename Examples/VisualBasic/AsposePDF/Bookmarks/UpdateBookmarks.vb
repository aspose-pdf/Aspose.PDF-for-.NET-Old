'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf

Namespace VisualBasic.AsposePdf.Bookmarks
    Public Class UpdateBookmarks
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Bookmarks()

            'open document
            Dim pdfDocument As New Document(dataDir & "UpdateBookmarks.pdf")

            'get a bookmark object
            Dim pdfOutline As OutlineItemCollection = pdfDocument.Outlines(1)
            pdfOutline.Title = "Updated Outline"
            pdfOutline.Italic = True
            pdfOutline.Bold = True

            'save output
            pdfDocument.Save(dataDir & "UpdateBookmarks_out.pdf")

        End Sub
    End Class
End Namespace