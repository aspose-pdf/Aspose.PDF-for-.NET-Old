Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Forms
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations

Namespace AsposePDF.Forms
    Public Class TextBox
        Public Shared Sub Run()
            ' ExStart:AddTextBoxField
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            'Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("TextField.pdf"))

            ' Create a field
            Dim textBoxField As New TextBoxField(pdfDocument.Pages(1), New Rectangle(100, 200, 300, 300))
            textBoxField.PartialName = "textbox1"
            textBoxField.Value = "Text Box"

            ' TextBoxField.Border = new Border(
            Dim border As New Border(textBoxField)
            border.Width = 5
            border.Dash = New Dash(1, 1)
            textBoxField.Border = border

            textBoxField.Color = Color.FromRgb(System.Drawing.Color.Green)

            ' Add field to the document
            pdfDocument.Form.Add(textBoxField, 1)

            dataDir = dataDir & Convert.ToString("TextBox_out_.pdf")
            ' Save modified PDF
            pdfDocument.Save(dataDir)
            ' ExEnd:AddTextBoxField
            Console.WriteLine(Convert.ToString(vbLf & "Textbox field added successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
