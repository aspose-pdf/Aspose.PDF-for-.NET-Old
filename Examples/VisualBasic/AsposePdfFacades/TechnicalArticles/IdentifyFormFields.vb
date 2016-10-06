Imports System.IO
Imports System
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Annotations

Namespace AsposePDFFacades.TechnicalArticles
    Public Class IdentifyFormFields
        Public Shared Sub Run()
            ' ExStart:IdentifyFormFields
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' First a input pdf file should be assigned
            Dim form As New Aspose.Pdf.Facades.Form(dataDir & Convert.ToString("FilledForm.pdf"))
            ' Get all field names
            Dim allfields As [String]() = form.FieldNames
            ' Create an array which will hold the location coordinates of Form fields
            Dim box As System.Drawing.Rectangle() = New System.Drawing.Rectangle(allfields.Length - 1) {}
            For i As Integer = 0 To allfields.Length - 1
                ' Get the appearance attributes of each field, consequtively
                Dim facade As FormFieldFacade = form.GetFieldFacade(allfields(i))
                ' Box in FormFieldFacade class holds field's location.
                box(i) = facade.Box
            Next
            form.Save(dataDir & Convert.ToString("IdentifyFormFields_1_out_.pdf"))

            Dim doc As New Document(dataDir & Convert.ToString("FilledForm - 2.pdf"))
            ' Now we need to add a textfield just upon the original one
            Dim editor As New FormEditor(doc)
            For i As Integer = 0 To allfields.Length - 1
                ' Add text field beneath every existing form field
                editor.AddField(FieldType.Text, "TextField" + i.ToString(), allfields(i), 1, box(i).Left, box(i).Top, _
                    box(i).Left + 50, box(i).Top + 10)
            Next
            ' Close the document
            editor.Save(dataDir & Convert.ToString("IdentifyFormFields_out_.pdf"))
            ' ExEnd:IdentifyFormFields                      
        End Sub
    End Class
End Namespace
