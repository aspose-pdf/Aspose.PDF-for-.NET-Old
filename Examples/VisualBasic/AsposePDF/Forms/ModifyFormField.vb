Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Forms
Imports Aspose.Pdf

Namespace AsposePDF.Forms
    Public Class ModifyFormField
        Public Shared Sub Run()
            ' ExStart:ModifyFormField
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("ModifyFormField.pdf"))

            ' Get a field
            Dim textBoxField As TextBoxField = TryCast(pdfDocument.Form("textbox1"), TextBoxField)

            ' Modify field value
            textBoxField.Value = "New Value"
            textBoxField.[ReadOnly] = True
            dataDir = dataDir & Convert.ToString("ModifyFormField_out_.pdf")
            ' Save updated document
            pdfDocument.Save(dataDir)
            ' ExEnd:ModifyFormField
            Console.WriteLine(Convert.ToString(vbLf & "Form field modified successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
