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
    Public Class ConcatenatePdfFiles
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            'open first document
            Dim pdfDocument1 As New Document(dataDir & "input1.pdf")
            'open second document
            Dim pdfDocument2 As New Document(dataDir & "input2.pdf")

            'add pages of second document to the first
            pdfDocument1.Pages.Add(pdfDocument2.Pages)

            'save concatenated output file
            pdfDocument1.Save(dataDir & "ConcatenatePdfFiles_out.pdf")

            ' Display result.
            System.Console.WriteLine("PDFs are concatenated successfully!")
        End Sub
    End Class
End Namespace