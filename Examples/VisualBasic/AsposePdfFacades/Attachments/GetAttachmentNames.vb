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

Namespace VisualBasic.AsposePDFFacades.Attachments
    Public Class GetAttachmentNames
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Attachments()
            'open document
            Dim pdfExtractor As New PdfExtractor()
            pdfExtractor.BindPdf(dataDir & "GetAttachmentNames.pdf")

            'extract attachments
            pdfExtractor.ExtractAttachment()

            'get attachment names
            Dim attachmentNames As System.Collections.IList = CType(pdfExtractor.GetAttachNames(), System.Collections.IList)

            For Each attachmentName As String In attachmentNames
                Console.WriteLine("Name : {0}", attachmentName)
            Next attachmentName

        End Sub
    End Class
End Namespace