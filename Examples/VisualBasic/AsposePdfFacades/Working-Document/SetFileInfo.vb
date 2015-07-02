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
    Public Class SetFileInfo
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments()
            'open document
            Dim fileInfo As New PdfFileInfo(dataDir & "SetFileInfo.pdf")
            'set PDF information
            fileInfo.Author = "Aspose"
            fileInfo.Title = "Hello World!"
            fileInfo.Keywords = "Peace and Development"
            fileInfo.Creator = "Aspose"
            fileInfo.CreationDate = DateTime.Now.ToString()
            fileInfo.ModDate = DateTime.Now.ToString()
            'save updated file
            fileInfo.SaveNewInfo(dataDir & "SetFileInfo_out.pdf")


        End Sub
    End Class
End Namespace