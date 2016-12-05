Imports System.IO
Imports System
Imports System.Collections
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Drawing

Namespace AsposePDFFacades.TechnicalArticles
    Public Class ChangingFieldAppearance
        Public Shared Sub Run()
            ' ExStart:ChangingFieldAppearance
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            Dim doc As New Document(dataDir & Convert.ToString("FilledForm.pdf"))
            ' Open the document and create a Form object
            Dim formEditor As New FormEditor(doc)
            ' Add a text field
            formEditor.AddField(FieldType.Text, "text1", 1, 200, 550, 300, _
                575)

            ' Set field attribute - PropertyFlag enumeration contains 4 options
            formEditor.SetFieldAttribute("text1", PropertyFlag.Required)
            ' Set field limit - this field will take maximum 20 characters as input
            formEditor.SetFieldLimit("text1", 20)

            ' Close the document
            formEditor.Save(dataDir & Convert.ToString("ChangingFieldAppearance_out_.pdf"))
            ' ExEnd:ChangingFieldAppearance                      
        End Sub
    End Class
End Namespace
