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
Imports System

Namespace VisualBasic.AsposePdf.WorkingDocuments
    Public Class GetFileInfo
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            'open document
            Dim pdfDocument As New Document(dataDir & "GetFileInfo.pdf")
            'get document information
            Dim docInfo As DocumentInfo = pdfDocument.Info
            'show document information
            Console.WriteLine("Author: {0}", docInfo.Author)
            Console.WriteLine("Creation Date: {0}", docInfo.CreationDate)
            Console.WriteLine("Keywords: {0}", docInfo.Keywords)
            Console.WriteLine("Modify Date: {0}", docInfo.ModDate)
            Console.WriteLine("Subject: {0}", docInfo.Subject)
            Console.WriteLine("Title: {0}", docInfo.Title)

        End Sub
    End Class
End Namespace