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

Namespace VisualBasic.AsposePDFFacades.Forms
    Public Class CopyInnerField
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()
            'create FormEditor object
            Dim formEditor As New FormEditor()
            'Open Document
            formEditor.BindPdf(dataDir & "CopyInnerField.pdf")
            'copy a field to another page
            formEditor.CopyInnerField("textfield", "newfieldname", 0)

            'close and save the output document
            formEditor.Save(dataDir & "CopyInnerField_out.pdf")


        End Sub
    End Class
End Namespace