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
Imports System

Namespace VisualBasic.AsposePdf.Forms
    Public Class GetValueFromField
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            'open document
            Dim pdfDocument As New Document(dataDir & "GetValueFromField.pdf")

            'get a field
            Dim textBoxField As TextBoxField = TryCast(pdfDocument.Form("textbox1"), TextBoxField)

            'get field value
            Console.WriteLine("PartialName : {0} ", textBoxField.PartialName)
            Console.WriteLine("Value : {0} ", textBoxField.Value)

        End Sub
    End Class
End Namespace