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
    Public Class AddAttachment
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Attachments()
            'open document
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & "AddAttachment.pdf")

            'add attachment
            contentEditor.AddDocumentAttachment(dataDir & "test.txt", "Attachment Description")

            'save updated PDF
            contentEditor.Save(dataDir & "AddAttachment_out.pdf")

        End Sub
    End Class
End Namespace