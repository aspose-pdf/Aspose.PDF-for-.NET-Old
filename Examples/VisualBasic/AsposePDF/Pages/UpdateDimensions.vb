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
    Public Class UpdateDimensions
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            'open document
            Dim pdfDocument As New Document(dataDir & "UpdateDimensions.pdf")

            'get page collection
            Dim pageCollection As PageCollection = pdfDocument.Pages

            'get particular page
            Dim pdfPage As Page = pageCollection(1)

            ' set the page size as A4 (11.7 x 8.3 in) and in Aspose.Pdf, 1 inch = 72 points
            ' so A4 dimensions in points will be (842.4, 597.6)
            pdfPage.SetPageSize(597.6, 842.4)

            ' save the updated document
            pdfDocument.Save(dataDir & "UpdateDimensions_out.pdf")

        End Sub
    End Class
End Namespace