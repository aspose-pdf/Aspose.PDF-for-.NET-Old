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
Imports System

Namespace VisualBasic.AsposePDFFacades.WorkingDocument
    Public Class GetFileInfo
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments()
            'open document
            Dim fileInfo As New PdfFileInfo(dataDir & "GetFileInfo.pdf")
            'get PDF information
            Console.WriteLine("Subject: {0}", fileInfo.Subject)
            Console.WriteLine("Title: {0}", fileInfo.Title)
            Console.WriteLine("Keywords: {0}", fileInfo.Keywords)
            Console.WriteLine("Creator: {0}", fileInfo.Creator)
            Console.WriteLine("Creation Date: {0}", fileInfo.CreationDate)
            Console.WriteLine("Modification Date: {0}", fileInfo.ModDate)
            'find whether is it valid PDF and it is encrypted as well
            Console.WriteLine("Is Valid PDF: {0}", fileInfo.IsPdfFile)
            Console.WriteLine("Is Encrypted: {0}", fileInfo.IsEncrypted)


        End Sub
    End Class
End Namespace