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

Namespace VisualBasic.AsposePDFFacades.Annotations
    Public Class CreateFileAnnotation
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Annotations()

            ' instantiate PdfContentEditor object
            Dim editor As New PdfContentEditor()
            ' bind input PDF file
            editor.BindPdf(dataDir & "CreateFileAnnotation.pdf")
            ' the last argumnet is for transparency of icon
            editor.CreateFileAttachment(New System.Drawing.Rectangle(50, 50, 10, 10), "here", "simple.doc", 1, "Paperclip", 0.005)
            ' save the updated PDF file
            editor.Save(dataDir & "PdfWith_Transparent_Annotation.pdf")

        End Sub
    End Class
End Namespace