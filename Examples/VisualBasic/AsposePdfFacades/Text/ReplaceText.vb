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

Namespace VisualBasic.AsposePDFFacades.Text
    Public Class ReplaceText
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Text()
            'open input PDF
            Dim pdfContentEditor As New PdfContentEditor()
            pdfContentEditor.BindPdf(dataDir & "input1.pdf")
            'replace text on all pages
            pdfContentEditor.ReplaceText("Hello", "World")
            'save output PDF
            pdfContentEditor.Save(dataDir & "ReplaceTextOnAllPages.pdf")

        End Sub
    End Class
End Namespace