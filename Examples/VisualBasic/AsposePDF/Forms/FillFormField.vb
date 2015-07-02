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
Imports Aspose.Pdf.InteractiveFeatures.Forms

Namespace VisualBasic.AsposePdf.Forms
    Public Class FillFormField
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            'open document
            Dim pdfDocument As New Document(dataDir & "FillFormField.pdf")

            'get a field
            Dim textBoxField As TextBoxField = TryCast(pdfDocument.Form("textbox1"), TextBoxField)

            'modify field value
            textBoxField.Value = "Value to be filled in the field"

            'save updated document
            pdfDocument.Save(dataDir & "FillFormField_out.pdf")

        End Sub
    End Class
End Namespace