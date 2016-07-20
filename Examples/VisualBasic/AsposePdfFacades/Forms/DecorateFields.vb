Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Forms
    Public Class DecorateFields
        Public Shared Sub Run()
            ' ExStart:DecorateFields
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Forms()

            ' Open document
            Dim form As New FormEditor()

            ' Open the document and create a FormEditor object
            form.BindPdf(dataDir & Convert.ToString("DecorateFields.pdf"))

            ' Create a new facade object
            Dim facade As New FormFieldFacade()

            ' Assign the facade to form editor
            form.Facade = facade

            ' Set the backgroud color as red
            facade.BackgroundColor = System.Drawing.Color.Red

            ' Set the alignment as center
            facade.Alignment = FormFieldFacade.AlignCenter

            ' All text fields will be modified:
            form.DecorateField(FieldType.Text)

            ' Close and validate the modification like this:
            form.Save(dataDir & Convert.ToString("DecorateFields_out_.pdf"))
            ' ExEnd:DecorateFields
        End Sub
    End Class
End Namespace
