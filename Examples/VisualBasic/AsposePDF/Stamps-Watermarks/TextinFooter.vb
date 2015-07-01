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

Namespace VisualBasic.AsposePdf.StampsWatermarks
    Public Class TextinFooter
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()


            'open document
            Dim pdfDocument As New Document(dataDir & "TextinFooter.pdf")
            'create footer
            Dim textStamp As New TextStamp("Footer Text")
            'set properties of the stamp
            textStamp.BottomMargin = 10
            textStamp.HorizontalAlignment = HorizontalAlignment.Center
            textStamp.VerticalAlignment = VerticalAlignment.Bottom
            'add footer on all pages
            For Each page As Page In pdfDocument.Pages
                page.AddStamp(textStamp)
            Next page

            'save updated PDF file
            pdfDocument.Save(dataDir & "TextinFooter_out.pdf")

        End Sub
    End Class
End Namespace