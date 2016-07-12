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

Namespace AsposePDFFacades.Bookmarks
    Public Class ExportToXML
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            'Create PdfBookmarkEditor object
            Dim bookmarkEditor As New PdfBookmarkEditor()
            'Open PDF file
            bookmarkEditor.BindPdf(dataDir & "ExportToXML.pdf")
            'Export bookmarks
            bookmarkEditor.ExportBookmarksToXML(dataDir & "bookmarks.xml")
            'Save updated PDF
            bookmarkEditor.Save(dataDir & "ExportToXML_out.pdf")


        End Sub
    End Class
End Namespace