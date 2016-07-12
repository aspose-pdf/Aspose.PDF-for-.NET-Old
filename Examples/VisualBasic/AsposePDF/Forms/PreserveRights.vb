Imports System.IO
Imports System
Imports Aspose.Pdf
Imports APF = Aspose.Pdf.Facades
Imports Aspose.Pdf.Forms

Namespace AsposePDF.Forms
    Public Class PreserveRights
        Public Shared Sub Run()
            ' ExStart:PreserveRights
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Read the source PDF form with FileAccess of Read and Write.
            ' We need ReadWrite permission because after modification,
            ' we need to save the updated contents in same document/file.
            Dim fs As New FileStream(dataDir & Convert.ToString("input.pdf"), FileMode.Open, FileAccess.ReadWrite)
            ' Instantiate Document instance
            Dim pdfDocument As New Document(fs)
            ' Get values from all fields
            For Each formField As Field In pdfDocument.Form
                ' If the fullname of field contains A1, perform the operation
                If formField.FullName.Contains("A1") Then
                    ' Cast form field as TextBox
                    Dim textBoxField As TextBoxField = TryCast(formField, TextBoxField)
                    ' Modify field value
                    textBoxField.Value = "Testing"
                End If
            Next
            ' Save the updated document in save FileStream
            pdfDocument.Save()
            ' Close the File Stream object
            fs.Close()
            ' ExEnd:PreserveRights            
        End Sub
        Public Shared Sub PreserveRightsUsingFormClass()
            ' ExStart:PreserveRightsUsingFormClass
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()
            ' Input and output file paths are equal, this forces incremental update when form saved.
            Dim form As New APF.Form(dataDir & Convert.ToString("input.pdf"))
            ' Fill value in form field
            form.FillField("topmostSubform[0].Page1[0].f1_29_0_[0]", "Nayyer")
            ' Save updated document
            form.Save(dataDir & Convert.ToString("PreserveRightsUsingFormClass_out_.pdf"))
            ' ExEnd:PreserveRightsUsingFormClass
        End Sub
    End Class
End Namespace
