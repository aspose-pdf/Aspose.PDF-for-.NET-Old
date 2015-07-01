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
    Public Class InsertEmptyPage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            'open document
            Dim pdfDocument1 As New Document(dataDir & "InsertEmptyPage.pdf")

            'insert a empty page in a PDF
            pdfDocument1.Pages.Insert(2)

            'save output file
            pdfDocument1.Save(dataDir & "InsertEmptyPage_out.pdf")

        End Sub
    End Class
End Namespace