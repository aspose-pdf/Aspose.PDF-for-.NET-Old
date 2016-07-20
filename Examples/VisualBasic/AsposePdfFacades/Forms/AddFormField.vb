Imports System.IO
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class AddFormField
        Public Shared Sub Run()
            ' ExStart:AddFormField
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            Dim formEditor As New FormEditor()
            ' Open Document
            formEditor.BindPdf(dataDir & "AddFormField.pdf")

            ' Add field
            formEditor.AddField(FieldType.Text, "textfield", 1, 100, 100, 200, _
                150)
            formEditor.AddField(FieldType.CheckBox, "checkboxfield", 1, 100, 200, 200, _
                250)
            formEditor.AddField(FieldType.ComboBox, "comboboxfield", 1, 100, 300, 200, _
                350)
            formEditor.AddField(FieldType.ListBox, "listboxfield", 1, 100, 400, 200, _
                450)
            formEditor.AddField(FieldType.MultiLineText, "multilinetextfield", 1, 100, 500, 200, _
                550)

            ' Save updated file
            formEditor.Save(dataDir & "AddFormField_out_.pdf")
            ' ExEnd:AddFormField
        End Sub
    End Class
End Namespace
