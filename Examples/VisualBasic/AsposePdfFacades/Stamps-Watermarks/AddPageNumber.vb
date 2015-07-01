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
Imports System.Drawing

Namespace VisualBasic.AsposePDFFacades.StampsWatermarks
    Public Class AddPageNumber
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks()
            'open document
            Dim fileStamp As New PdfFileStamp(dataDir & "Input_new.pdf", dataDir & "AddPageNumber_out.pdf")

            'get total number of pages

            Dim totalPages As Integer = New PdfFileInfo(dataDir & "Input_new.pdf").NumberOfPages
            'create formatted text for page number
            Dim formattedText As New FormattedText("Page # Of " & totalPages, System.Drawing.Color.Blue, System.Drawing.Color.Gray, Aspose.Pdf.Facades.FontStyle.Courier, EncodingType.Winansi, False, 14)

            'set starting number for first page; you might want to start from 2 or more
            fileStamp.StartingNumber = 1
            'add page number
            fileStamp.AddPageNumber(formattedText, 0)

            'save updated PDF file
            fileStamp.Close()

        End Sub
    End Class
End Namespace