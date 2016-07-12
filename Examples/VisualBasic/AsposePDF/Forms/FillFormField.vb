Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Forms
Imports Aspose.Pdf
Namespace AsposePDF.Forms
    Public Class FillFormField
        Public Shared Sub Run()
            ' ExStart:FillFormField
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("FillFormField.pdf"))

            ' Get a field
            Dim textBoxField As TextBoxField = TryCast(pdfDocument.Form("textbox1"), TextBoxField)

            ' Modify field value
            textBoxField.Value = "Value to be filled in the field"
            dataDir = dataDir & Convert.ToString("FillFormField_out_.pdf")
            ' Save updated document
            pdfDocument.Save(dataDir)
            ' ExEnd:FillFormField
            Console.WriteLine(Convert.ToString(vbLf & "Form field filled successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
