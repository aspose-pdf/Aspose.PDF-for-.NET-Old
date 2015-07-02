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

Namespace VisualBasic.AsposePdf.Pages
    Public Class SplitToPages
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            'open document
            Dim pdfDocument As New Document(dataDir & "SplitToPages.pdf")

            Dim pageCount As Integer = 1

            'loop through all the pages
            For Each pdfPage As Page In pdfDocument.Pages
                Dim newDocument As New Document()
                newDocument.Pages.Add(pdfPage)
                newDocument.Save(dataDir & "page_" & pageCount & ".pdf")
                pageCount += 1
            Next pdfPage


        End Sub
    End Class
End Namespace