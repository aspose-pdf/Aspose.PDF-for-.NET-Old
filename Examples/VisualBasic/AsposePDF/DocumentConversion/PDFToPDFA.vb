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

Namespace VisualBasic.AsposePdf.DocumentConversion
    Public Class PDFToPDFA
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            'open document
            Dim pdfDocument As New Document(dataDir & "PDFToPDFA.pdf")

            'Convert to PDF/A compliant document
            'during conversion process, the validation is also performed
            pdfDocument.Convert(dataDir & "log.xml", PdfFormat.PDF_A_1B, ConvertErrorAction.Delete)

            'save output document
            pdfDocument.Save(dataDir & "PDFToPDFA_out.pdf")
        End Sub
    End Class
End Namespace