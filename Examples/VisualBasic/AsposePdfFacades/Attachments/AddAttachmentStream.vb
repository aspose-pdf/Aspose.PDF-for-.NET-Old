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

Namespace VisualBasic.AsposePDFFacades.Attachments
    Public Class AddAttachmentStream
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Attachments()
            'open document
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & "AddAttachment-Stream.pdf")

            'read file into stream (FileStream or MemoryStream)
            Dim fileStream As New FileStream(dataDir & "test.txt", FileMode.Open)
            'add attachment
            contentEditor.AddDocumentAttachment(fileStream, "Attachment Name", "Attachment Description")

            'save updated PDF
            contentEditor.Save(dataDir & "AddAttachment-Stream_out.pdf")


        End Sub
    End Class
End Namespace