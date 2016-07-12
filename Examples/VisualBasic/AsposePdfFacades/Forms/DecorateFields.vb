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

Namespace AsposePDFFacades.Forms
    Public Class DecorateFields
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()
            'create FormEditor object and open PDF file
            Dim form As New FormEditor(dataDir & "input_form.pdf", dataDir & "DecorateFields_out.pdf")
            'create a new facade object
            Dim facade As New FormFieldFacade()
            'assign the facade to form editor
            form.Facade = facade
            'set the backgroud color as red
            facade.BackgroundColor = System.Drawing.Color.Red
            'set the alignment as center
            facade.Alignment = FormFieldFacade.AlignCenter
            'all text fields will be modified:
            form.DecorateField(FieldType.Text)
            'close and validate the modification like this:
            form.Save()

        End Sub
    End Class
End Namespace