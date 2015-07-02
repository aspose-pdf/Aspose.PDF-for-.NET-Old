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
    Public Class PDFToEPUB
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' load PDF document
            Dim pdfDocument As New Document(dataDir & "PDFToEPUB.pdf")

            ' instantiate Epub Save options
            Dim options As New EpubSaveOptions()

            ' specify the layout for contents
            options.ContentRecognitionMode = EpubSaveOptions.RecognitionMode.Flow

            ' save the ePUB document
            pdfDocument.Save(dataDir & "Sample.epub", options)
        End Sub
    End Class
End Namespace