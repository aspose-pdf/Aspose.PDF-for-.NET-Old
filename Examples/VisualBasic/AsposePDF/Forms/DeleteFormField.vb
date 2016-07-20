Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Forms
    Public Class DeleteFormField
        Public Shared Sub Run()
            ' ExStart:DeleteFormField
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("DeleteFormField.pdf"))

            ' Delete a particular field by name
            pdfDocument.Form.Delete("textbox1")
            dataDir = dataDir & Convert.ToString("DeleteFormField_out_.pdf")
            ' Save modified document
            pdfDocument.Save(dataDir)
            ' ExEnd:DeleteFormField
            Console.WriteLine(Convert.ToString(vbLf & "Particular field deleted successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace

