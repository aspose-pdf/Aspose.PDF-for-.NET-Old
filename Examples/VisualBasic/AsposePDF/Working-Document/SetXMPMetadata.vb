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
    Public Class SetXMPMetadata
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            'open document
            Dim pdfDocument As New Document(dataDir & "SetXMPMetadata.pdf")

            'set properties
            pdfDocument.Metadata("xmp:CreateDate") = DateTime.Now
            pdfDocument.Metadata("xmp:Nickname") = "Nickname"
            pdfDocument.Metadata("xmp:CustomProperty") = "Custom Value"

            'save document
            pdfDocument.Save(dataDir & "SetXMPMetadata_out.pdf")

        End Sub
    End Class
End Namespace