Imports System.IO
Imports System
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Annotations

Namespace AsposePDFFacades.TechnicalArticles
    Public Class FormEditorFeatures
        Public Shared Sub Run()
            ' ExStart:FormEditorFeatures
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            Dim doc As New Document(dataDir & Convert.ToString("inFile.pdf"))
            ' Create instance of FormEditor
            Dim editor As New FormEditor(doc)

            ' Add field in the PDF file
            editor.AddField(FieldType.Text, "field1", 1, 300, 500, 350, _
                525)

            ' Add List field in PDF file
            editor.AddField(FieldType.ListBox, "field2", 1, 300, 200, 350, _
                225)

            ' Add list items
            editor.AddListItem("field2", "item 1")
            editor.AddListItem("field2", "item 2")

            ' Add submit button
            editor.AddSubmitBtn("submitbutton", 1, "Submit Form", "http://testwebsite.com/testpage", 200, 200, _
                250, 225)

            ' Delete list item
            editor.DelListItem("field2", "item 1")

            ' Move field to new position
            editor.MoveField("field1", 10, 10, 50, 50)

            ' Remove existing field from the PDF
            editor.RemoveField("field1")

            ' Rename an existing field
            editor.RenameField("field1", "newfieldname")

            ' Reset all visual attributes to empty value
            editor.ResetFacade()

            ' Set the alignment style of a text field
            editor.SetFieldAlignment("field1", FormFieldFacade.AlignLeft)

            ' Set appearance of the field
            editor.SetFieldAppearance("field1", AnnotationFlags.NoRotate)

            ' Set field attributes i.e. ReadOnly, Required
            editor.SetFieldAttribute("field1", PropertyFlag.[ReadOnly])

            ' Set field limit
            editor.SetFieldLimit("field1", 25)

            ' Save modifications in the output file
            editor.Save(dataDir & Convert.ToString("FormEditorFeatures2_out_.pdf"))
            ' ExEnd:FormEditorFeatures                      
        End Sub
    End Class
End Namespace
